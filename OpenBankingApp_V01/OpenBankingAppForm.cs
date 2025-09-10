using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Xml;

namespace OpenBankingApp_V01
{
    public partial class OpenBankingAppForm : Form
    {
        public OpenBankingAppForm()
        {
            InitializeComponent();
            CheckEnabled();
        }

        private async void InvokeAPI( string methodPlusArguments, int? page = null, int? pageSize = null)
        {
            try
            {
                using (HttpClient _httpClient = new HttpClient())
                {
                    JsonSerializerOptions _jsonSerializerOptions;
                    _jsonSerializerOptions = new JsonSerializerOptions()
                    {
                        PropertyNamingPolicy = JsonNamingPolicy.CamelCase, // Automatically maps camelCase JSON to PascalCase C#
                                                                           // Or JsonNamingPolicy.SnakeCaseLower for snake_case (requires System.Text.Json.SnakeCaseLower)
                        WriteIndented = true, // For pretty-printing during serialization (usually false for API requests)
                        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull, // Don't serialize null properties
                        Converters = { new JsonStringEnumConverter() } // Convert enums to/from strings
                    };
                    var apiChosen = cboURL.Text;
                    var apiChosenElements = apiChosen.Split(":");
                    if (apiChosenElements.Length > 1)
                    {
                        var sb = new StringBuilder();
                        for (var i = 1; i < apiChosenElements.Length; i++)
                        {
                            if (sb.Length > 0)
                            {
                                sb.Append(":");
                            }
                            ;
                            sb.Append(apiChosenElements[i]);
                        }
                        var apiUri = sb.ToString();
                        var fullApiUri = string.Concat(apiUri, "/", methodPlusArguments);
                        if (page != null)
                        {
                            fullApiUri = string.Concat(fullApiUri, "?page=", page, "&page-size=", pageSize);
                        }
                            

                        var _httpRequest = new HttpRequestMessage(HttpMethod.Get, fullApiUri);
                        _httpRequest.Headers.Add("Accept", "application/json");
                        _httpRequest.Headers.Add("Accept", "application/xml");
                        _httpRequest.Headers.Add("x-v", "3");
                        //_httpRequest.Headers.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/118.0.0.0 Safari/537.36");
                        //_httpRequest.Headers.Add("x-v", "2");
                        var response = await _httpClient.SendAsync(_httpRequest);
                        response.EnsureSuccessStatusCode();

                        var responseBody = await response.Content.ReadAsStringAsync();

                        LoadJsonIntoTreeView(tvwAPIResponse, responseBody);
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }


        private async void btnInvoke_Click(object sender, EventArgs e)
        {
            btnInvoke.Enabled = false;
            this.Cursor = Cursors.WaitCursor;
            txtError.Text = "";
            try
            {
                InvokeAPI(cboMethod.Text, 1, 25);            
            }
            catch (Exception ex)
            {
                txtError.Text = string.Format($"An Error Occurred - {ex.Message}");
            }
            finally
            {
                this.Cursor = Cursors.Default;
                btnInvoke.Enabled = true;
            }
        }

        public void LoadJsonIntoTreeView(System.Windows.Forms.TreeView tvw, string jsonString)
        {
            tvw.Nodes.Clear(); // Clear existing nodes

            try
            {
                JsonNode rootNode = JsonNode.Parse(jsonString);
                if (rootNode == null)
                {
                    tvw.Nodes.Add("Empty JSON");
                    return;
                }

                // Determine if the root is an object, array, or scalar
                TreeNode rootTreeNode = null;
                if (rootNode is JsonObject rootObject)
                {
                    rootTreeNode = new TreeNode("JSON Object (Root)");
                    AddJsonObjectToTreeView(rootObject, rootTreeNode);
                }
                else if (rootNode is JsonArray rootArray)
                {
                    rootTreeNode = new TreeNode("JSON Array (Root)");
                    AddJsonArrayToTreeView(rootArray, rootTreeNode);
                }
                else // Scalar value at root
                {
                    JsonValue rootValue = rootNode.AsValue();
                    rootTreeNode = new TreeNode($"JSON Value (Root): {rootValue.ToJsonString()}");
                }

                tvw.Nodes.Add(rootTreeNode);
                rootTreeNode.ExpandAll(); // Optionally expand all nodes
            }
            catch (JsonException ex)
            {
                tvw.Nodes.Add($"Error parsing JSON: {ex.Message}");
            }
            catch (Exception ex)
            {
                tvw.Nodes.Add($"An unexpected error occurred: {ex.Message}");
            }
        }


        private void AddJsonNodeToTreeView(JsonNode node, string nodeName, TreeNode parentNode)
        {
            if (node == null)
            {
                parentNode.Nodes.Add($"{nodeName}: null");
                return;
            }

            if (node is JsonObject jsonObject)
            {
                TreeNode objectNode = parentNode.Nodes.Add($"{nodeName}: Object");
                AddJsonObjectToTreeView(jsonObject, objectNode);
            }
            else if (node is JsonArray jsonArray)
            {
                TreeNode arrayNode = parentNode.Nodes.Add($"{nodeName}: Array");
                AddJsonArrayToTreeView(jsonArray, arrayNode);
            }
            else if (node is JsonValue jsonValue)
            {
                // For scalar values (string, number, boolean, null)
                parentNode.Nodes.Add($"{nodeName}: {jsonValue.ToJsonString()}");
            }
        }

        private void AddJsonObjectToTreeView(JsonObject jsonObject, TreeNode parentNode)
        {
            foreach (var property in jsonObject)
            {
                AddJsonNodeToTreeView(property.Value, property.Key, parentNode);
            }
        }

        private void AddJsonArrayToTreeView(JsonArray jsonArray, TreeNode parentNode)
        {
            for (int i = 0; i < jsonArray.Count; i++)
            {
                AddJsonNodeToTreeView(jsonArray[i], $"[{i}]", parentNode);
            }
        }

        private void cboURL_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckEnabled();
        }

        private void CheckEnabled()
        {
            btnInvoke.Enabled = ((cboURL.SelectedIndex != -1) && (cboMethod.SelectedIndex != -1));
        }

        private void cboMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckEnabled();
        }

        private void tvwAPIResponse_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tvwAPIResponse_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var tvNode = e.Node;
            if (tvNode.Text.ToLower().StartsWith("productid"))
            {
                var nodeElements = tvNode.Text.Split(":");
                var productId = nodeElements[1].Replace("\"", "").Trim();
                var productIdGuid = new Guid(productId);
                var fullProductURL = string.Concat(cboMethod.Text, "/", productIdGuid.ToString());
                InvokeAPI(fullProductURL);
            }
        }
    }
}
