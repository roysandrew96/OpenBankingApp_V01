namespace OpenBankingApp_V01
{
    partial class OpenBankingAppForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboURL = new ComboBox();
            lblAPIURLs = new Label();
            btnInvoke = new Button();
            tvwAPIResponse = new TreeView();
            cboMethod = new ComboBox();
            label1 = new Label();
            txtError = new TextBox();
            lblError = new Label();
            cboPageNumber = new ComboBox();
            label2 = new Label();
            cboPageSize = new ComboBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // cboURL
            // 
            cboURL.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboURL.FormattingEnabled = true;
            cboURL.Items.AddRange(new object[] { "AMP - My AMP: https://api.cdr-api.amp.com.au/cds-au/v1", "AMP Bank GO: https://pub.cdr-sme.amp.com.au/api/cds-au/v1", "ANZ: https://api.anz/cds-au/v1", "ANZ Plus: https://cdr.apix.anz/cds-au/v1", "Adelaide Bank: https://api.cdr.adelaidebank.com.au/cds-au/v1", "Alex.Bank: https://public.cdr.alex.com.au/cds-au/v1", "Arab Bank Australia Limited: https://public.cdr.arabbank.com.au/cds-au/v1", "Aussie Home Loans: https://aussie.openportal.com.au/cds-au/v1", "Australian Military Bank: https://public.open.australianmilitarybank.com.au/cds-au/v1", "Australian Mutual Bank LTD: https://internetbanking.australianmutual.bank/openbanking/cds-au/v1", "Australian Unity Bank: https://open-banking.australianunity.com.au/cds-au/v1", "Auswide Bank Ltd: https://api.auswidebank.com.au/openbanking/cds-au/v1", "BCU Bank: https://public.cdr-api.bcu.com.au/cds-au/v1", "BNK Bank (Goldfields Money/BCHL): https://public.cdr.bnk.com.au/cds-au/v1", "BOQ Specialist: https://api.cds.boqspecialist.com.au/cds-au/v1", "Bank Australia: https://public.cdr.bankaust.com.au/cds-au/v1", "Bank First: https://public.cdr.bankfirst.com.au/cds-au/v1", "Bank of China: https://api-gateway.bankofchina.com.au/cds-au/v1", "Bank of Melbourne: https://digital-api.bankofmelbourne.com.au/cds-au/v1", "Bank of Queensland Limited: https://api.cds.boq.com.au/cds-au/v1", "Bank of Sydney: https://openbank.api.banksyd.com.au/cds-au/v1", "Bank of us: https://api.bankofus.com.au/OpenBanking/cds-au/v1", "BankSA: https://digital-api.banksa.com.au/cds-au/v1", "BankVic: https://ib.bankvic.com.au/openbanking/cds-au/v1", "Bankwest: https://open-api.bankwest.com.au/bwpublic/cds-au/v1", "Bendigo Bank: https://api.cdr.bendigobank.com.au/cds-au/v1", "Beyond Bank Australia: https://public.cdr.api.beyondbank.com.au/cds-au/v1", "Border Bank: https://public.cdr.prd.borderbank.com.au/cds-au/v1", "Broken Hill Bank: https://public.cdr-api.bhccu.com.au/cds-au/v1", "CBA - CommBiz: https://cdr.commbiz.api.commbank.com.au/cbzpublic/cds-au/v1", "Cairns bank: https://openbanking.cairnsbank.com.au/OpenBanking/cds-au/v1", "Card Services: https://api.openbanking.cardservicesdirect.com.au/cds-au/v1", "Central Murray Bank: https://secure.cmcu.com.au/openbanking/cds-au/v1", "Central West CUL: https://ib.cwcu.com.au/openbanking/cds-au/v1", "Citi: https://openbanking.api.citi.com.au/cds-au/v1", "Coastline Bank: https://public.cdr-api.coastline.com.au/cds-au/v1", "Coles Financial Services: https://api.openbanking.secure.coles.com.au/cds-au/v1", "CommBank: https://api.commbank.com.au/public/cds-au/v1", "CommFCU: https://netbank.communityfirst.com.au/cf-OpenBanking/cds-au/v1", "Credit Union SA: https://openbanking.api.creditunionsa.com.au/cds-au/v1", "DDH Graham: https://api.cds.ddhgraham.com.au/cds-au/v1", "Darling Downs Bank: https://openbanking.wcu.com.au/OpenBanking/cds-au/v1", "Defence Bank: https://product.defencebank.com.au/cds-au/v1", "Dnister: https://public.cdr-api.dnister.com.au/cds-au/v1", "Easy Street: https://ebranch.easystreet.com.au/es-OpenBanking/cds-au/v1", "Family First: https://public.cdr.familyfirst.com.au/cds-au/v1", "Fire Service Credit Union: https://public.cdr-api.fscu.com.au/cds-au/v1", "Firefighters Mutual Bank: https://ob.tmbl.com.au/fmbank/cds-au/v1", "First Option Bank: https://internetbanking.firstoption.com.au/OpenBanking/cds-au/v1", "G&C Mutual Bank: https://ibank.gcmutualbank.com.au/OpenBanking/cds-au/v1", "Gateway Bank: https://public.cdr-api.gatewaybank.com.au/cds-au/v1", "Geelong Bank: https://online.geelongbank.com.au/OpenBanking/cds-au/v1", "Great Southern Bank: https://api.open-banking.greatsouthernbank.com.au/cds-au/v1", "Great Southern Bank Business+: https://od1.open-banking.business.greatsouthernbank.com.au/api/cds-au/v1", "Greater Bank Limited: https://public.cdr.greater.com.au/cds-au/v1", "HSBC: https://public.ob.hsbc.com.au/cds-au/v1", "HSBC Bank Australia Limited – Wholesale Banking: https://public.ob.business.hsbc.com.au/cds-au/v1", "Health Professionals Bank: https://ob.tmbl.com.au/hpbank/cds-au/v1", "Heartland: https://api.cdr.heartlandbank.com.au/cds-au/v1", "Heritage Bank. Please do not use, please use People’s Choice.: https://product.api.heritage.com.au/cds-au/v1", "Horizon Bank: https://onlinebanking.horizonbank.com.au/openbanking/cds-au/v1", "Hume Bank: https://ibankob.humebank.com.au/OpenBanking/cds-au/v1", "IMB Bank: https://openbank.openbanking.imb.com.au/cds-au/v1", "ING BANK (Australia) Ltd: https://id.ob.ing.com.au/cds-au/v1", "Illawarra Credit Union Limited: https://onlineteller.cu.com.au/OpenBanking/cds-au/v1", "Judo Bank: https://public.open.judo.bank/cds-au/v1", "Kogan Money Credit Cards: https://api.openbanking.cards.koganmoney.com.au/cds-au/v1", "Laboratories Credit Union: https://internetbanking.lcu.com.au/OpenBanking/cds-au/v1", "Liberty Financial: https://services.liberty.com.au/api/data-holder-public/cds-au/v1", "ME Bank: https://public.openbank.mebank.com.au/cds-au/v1", "ME Bank - ME Go: https://api.cds.mebank.com.au/cds-au/v1", "MOVE Bank: https://openbanking.movebank.com.au/OpenBanking/cds-au/v1", "Macquarie Bank Limited: https://api.macquariebank.io/cds-au/v1", "Maitland Mutual Limited: https://openbanking.themutual.com.au/OpenBanking/cds-au/v1", "MyState Bank: https://public.cdr.mystate.com.au/cds-au/v1", "NATIONAL AUSTRALIA BANK: https://openbank.api.nab.com.au/cds-au/v1", "Newcastle Permanent Building Society: https://openbank.newcastlepermanent.com.au/cds-au/v1", "Northern Inland Credit Union Limited: https://secure.nicu.com.au/OpenBanking/cds-au/v1", "ORANGE CREDIT UNION LTD: https://online.orangecu.com.au/openbanking/cds-au/v1", "P&N Bank: https://public.cdr-api.pnbank.com.au/cds-au/v1", "PayPal Australia: https://api.paypal.com/v1/identity/cds-au/v1", "People's Choice: https://ob-public.peopleschoice.com.au/cds-au/v1", "Police Bank: https://public.cdr.prd.policebank.com.au/cds-au/v1", "Police Credit Union Ltd: https://api.policecu.com.au/OpenBanking/cds-au/v1", "QBANK: https://banking.qbank.com.au/openbanking/cds-au/v1", "Qantas Premier Credit Cards: https://api.openbanking.qantasmoney.com/cds-au/v1", "Qudos Bank: https://public.cdr.qudosbank.com.au/cds-au/v1", "Queensland Country Bank: https://public.cdr-api.queenslandcountry.bank/cds-au/v1", "RACQ Bank: https://cdrbank.racq.com.au/cds-au/v1", "RAMS Financial Group Pty Ltd: https://digital-api.westpac.com.au/rams/cds-au/v1", "RSL Money: https://public.open.rslmoney.com.au/cds-au/v1", "Rabobank: https://openbanking.api.rabobank.com.au/public/cds-au/v1", "Regional Australia Bank: https://public-data.cdr.regaustbank.io/cds-au/v1", "Reliance Bank: https://ibanking.reliancebank.com.au/rel-openbanking/cds-au/v1", "SWSbank: https://online.swsbank.com.au/openbanking/cds-au/v1", "Solo by MYOB: https://od1.open-banking.myob.greatsouthernbank.com.au/api/cds-au/v1", "Southern Cross Credit Union: https://cdr.sccu.com.au/openbanking/cds-au/v1", "St.George Bank: https://digital-api.stgeorge.com.au/cds-au/v1", "Summerland Bank: https://public.cdr-api.summerland.com.au/cds-au/v1", "Suncorp Bank: https://id-ob.suncorpbank.com.au/cds-au/v1", "TMCU: https://banking.transportmutual.com.au/OpenBanking/cds-au/v1", "Teachers Mutual Bank: https://ob.tmbl.com.au/tmbank/cds-au/v1", "The Capricornian: https://public.cdr.onlinebanking.capricornian.com.au/cds-au/v1", "The Mac: https://onlinebanking.themaccu.com.au/OpenBanking/cds-au/v1", "Thriday: https://public.cdr.thriday.com.au/cds-au/v1", "Traditional Credit Union: https://prd.tcu.com.au/cds-au/v1", "Tyro Banking: https://od1.cdr.banking.tyro.com/api/cds-au/v1", "Tyro Payments: https://public.cdr.tyro.com/cds-au/v1", "UBank: https://public.cdr-api.86400.com.au/cds-au/v1", "UniBank: https://ob.tmbl.com.au/unibank/cds-au/v1", "Unity Bank: https://ibanking.unitybank.com.au/OpenBanking/cds-au/v1", "Unloan: https://public.api.cdr.unloan.com.au/cds-au/v1", "Up: https://api.up.com.au/cds-au/v1", "Virgin Money: https://api.cds.virginmoney.com.au/cds-au/v1", "Westpac: https://digital-api.westpac.com.au/cds-au/v1", "Wise: https://au-cdrbanking-pub.wise.com/cds-au/v1", "Woolworths Team Bank: https://online.woolworthsteambank.com.au/OpenBanking/cds-au/v1", "bankWAW: https://onlinebanking.wawcu.com.au/OpenBanking/cds-au/v1", "gmcu: https://secure.gmcu.com.au/OpenBanking/cds-au/v1", "in1bank ltd.: https://cdr.in1bank.com.au/cds-au/v1" });
            cboURL.Location = new Point(319, 46);
            cboURL.Margin = new Padding(5, 6, 5, 6);
            cboURL.Name = "cboURL";
            cboURL.Size = new Size(1583, 38);
            cboURL.TabIndex = 0;
            cboURL.SelectedIndexChanged += cboURL_SelectedIndexChanged;
            // 
            // lblAPIURLs
            // 
            lblAPIURLs.AutoSize = true;
            lblAPIURLs.Location = new Point(63, 62);
            lblAPIURLs.Margin = new Padding(5, 0, 5, 0);
            lblAPIURLs.Name = "lblAPIURLs";
            lblAPIURLs.Size = new Size(234, 30);
            lblAPIURLs.TabIndex = 1;
            lblAPIURLs.Text = "Open Banking API URLs";
            // 
            // btnInvoke
            // 
            btnInvoke.Location = new Point(319, 256);
            btnInvoke.Margin = new Padding(5, 6, 5, 6);
            btnInvoke.Name = "btnInvoke";
            btnInvoke.Size = new Size(166, 64);
            btnInvoke.TabIndex = 2;
            btnInvoke.Text = "Invoke";
            btnInvoke.UseVisualStyleBackColor = true;
            btnInvoke.Click += btnInvoke_Click;
            // 
            // tvwAPIResponse
            // 
            tvwAPIResponse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tvwAPIResponse.Location = new Point(63, 358);
            tvwAPIResponse.Margin = new Padding(5, 6, 5, 6);
            tvwAPIResponse.Name = "tvwAPIResponse";
            tvwAPIResponse.Size = new Size(1838, 972);
            tvwAPIResponse.TabIndex = 3;
            // 
            // cboMethod
            // 
            cboMethod.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cboMethod.AutoCompleteCustomSource.AddRange(new string[] { "GetProducts" });
            cboMethod.FormattingEnabled = true;
            cboMethod.Items.AddRange(new object[] { "banking/products" });
            cboMethod.Location = new Point(319, 116);
            cboMethod.Margin = new Padding(5, 6, 5, 6);
            cboMethod.Name = "cboMethod";
            cboMethod.Size = new Size(1583, 38);
            cboMethod.TabIndex = 4;
            cboMethod.SelectedIndexChanged += cboMethod_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 132);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(86, 30);
            label1.TabIndex = 5;
            label1.Text = "Method";
            // 
            // txtError
            // 
            txtError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtError.ForeColor = Color.Red;
            txtError.Location = new Point(319, 1374);
            txtError.Margin = new Padding(5, 6, 5, 6);
            txtError.Multiline = true;
            txtError.Name = "txtError";
            txtError.Size = new Size(1583, 120);
            txtError.TabIndex = 6;
            // 
            // lblError
            // 
            lblError.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblError.AutoSize = true;
            lblError.Location = new Point(63, 1380);
            lblError.Margin = new Padding(5, 0, 5, 0);
            lblError.Name = "lblError";
            lblError.Size = new Size(180, 30);
            lblError.TabIndex = 7;
            lblError.Text = "Error(s) Generated";
            // 
            // cboPageNumber
            // 
            cboPageNumber.FormattingEnabled = true;
            cboPageNumber.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            cboPageNumber.Location = new Point(319, 188);
            cboPageNumber.Margin = new Padding(5, 6, 5, 6);
            cboPageNumber.Name = "cboPageNumber";
            cboPageNumber.Size = new Size(205, 38);
            cboPageNumber.TabIndex = 8;
            cboPageNumber.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 194);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 30);
            label2.TabIndex = 9;
            label2.Text = "Page Number";
            // 
            // cboPageSize
            // 
            cboPageSize.FormattingEnabled = true;
            cboPageSize.Items.AddRange(new object[] { "5", "10", "15", "20", "25", "30", "40", "50" });
            cboPageSize.Location = new Point(861, 194);
            cboPageSize.Margin = new Padding(5, 6, 5, 6);
            cboPageSize.Name = "cboPageSize";
            cboPageSize.Size = new Size(205, 38);
            cboPageSize.TabIndex = 10;
            cboPageSize.Text = "25";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(614, 204);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(95, 30);
            label3.TabIndex = 11;
            label3.Text = "PageSize";
            // 
            // OpenBankingAppForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1968, 1522);
            Controls.Add(label3);
            Controls.Add(cboPageSize);
            Controls.Add(label2);
            Controls.Add(cboPageNumber);
            Controls.Add(lblError);
            Controls.Add(txtError);
            Controls.Add(label1);
            Controls.Add(cboMethod);
            Controls.Add(tvwAPIResponse);
            Controls.Add(btnInvoke);
            Controls.Add(lblAPIURLs);
            Controls.Add(cboURL);
            Margin = new Padding(5, 6, 5, 6);
            Name = "OpenBankingAppForm";
            Text = "OpenBankingAppForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboURL;
        private Label lblAPIURLs;
        private Button btnInvoke;
        private TreeView tvwAPIResponse;
        private ComboBox cboMethod;
        private Label label1;
        private TextBox txtError;
        private Label lblError;
        private ComboBox cboPageNumber;
        private Label label2;
        private ComboBox cboPageSize;
        private Label label3;
    }
}