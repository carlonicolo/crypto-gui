namespace cryptoGUI_Tools
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cmbFiat = new System.Windows.Forms.ComboBox();
            this.cmbCrypto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDebugOutput = new System.Windows.Forms.TextBox();
            this.cmdDeserialise2 = new System.Windows.Forms.Button();
            this.cmdClear2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBTS = new System.Windows.Forms.CheckBox();
            this.checkZEC = new System.Windows.Forms.CheckBox();
            this.checkBCC = new System.Windows.Forms.CheckBox();
            this.checkEOS = new System.Windows.Forms.CheckBox();
            this.checkXRM = new System.Windows.Forms.CheckBox();
            this.checkDASH = new System.Windows.Forms.CheckBox();
            this.checkMIOTA = new System.Windows.Forms.CheckBox();
            this.checkETH = new System.Windows.Forms.CheckBox();
            this.checkLTC = new System.Windows.Forms.CheckBox();
            this.checkXLM = new System.Windows.Forms.CheckBox();
            this.checkADA = new System.Windows.Forms.CheckBox();
            this.checkBCH = new System.Windows.Forms.CheckBox();
            this.checkXRP = new System.Windows.Forms.CheckBox();
            this.checkTRX = new System.Windows.Forms.CheckBox();
            this.checkBTC = new System.Windows.Forms.CheckBox();
            this.btnTopTen = new System.Windows.Forms.Button();
            this.btnTopPercentageHour = new System.Windows.Forms.Button();
            this.btnTopPercentageDay = new System.Windows.Forms.Button();
            this.btnCheckBoxSelection = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lblResult);
            this.groupBox4.Controls.Add(this.textQuantity);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.cmbFiat);
            this.groupBox4.Controls.Add(this.cmbCrypto);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(568, 80);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exchange tool";
            // 
            // textQuantity
            // 
            this.textQuantity.Location = new System.Drawing.Point(149, 40);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 20);
            this.textQuantity.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(255, 39);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 2;
            this.button6.Text = "Exchange";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cmbFiat
            // 
            this.cmbFiat.FormattingEnabled = true;
            this.cmbFiat.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.cmbFiat.SelectedIndex = 0;
            this.cmbFiat.Location = new System.Drawing.Point(336, 40);
            this.cmbFiat.Name = "cmbFiat";
            this.cmbFiat.Size = new System.Drawing.Size(121, 21);
            this.cmbFiat.TabIndex = 1;
            // 
            // cmbCrypto
            // 
            this.cmbCrypto.FormattingEnabled = true;
            this.cmbCrypto.Items.AddRange(new object[] {
            "Bitcoin",
            "Verge",
            "Ripple",
            "Cardano",
            "Tron"});
            this.cmbCrypto.SelectedIndex = 0;
            this.cmbCrypto.Location = new System.Drawing.Point(22, 40);
            this.cmbCrypto.Name = "cmbCrypto";
            this.cmbCrypto.Size = new System.Drawing.Size(121, 21);
            this.cmbCrypto.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Result";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(367, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fiat currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(181, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Crypto";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtDebugOutput);
            this.groupBox5.Location = new System.Drawing.Point(10, 284);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(568, 178);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output Console";
            // 
            // txtDebugOutput
            // 
            this.txtDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDebugOutput.Location = new System.Drawing.Point(7, 19);
            this.txtDebugOutput.Multiline = true;
            this.txtDebugOutput.Name = "txtDebugOutput";
            this.txtDebugOutput.Size = new System.Drawing.Size(555, 153);
            this.txtDebugOutput.TabIndex = 0;
            // 
            // cmdDeserialise2
            // 
            this.cmdDeserialise2.Location = new System.Drawing.Point(126, 261);
            this.cmdDeserialise2.Name = "cmdDeserialise2";
            this.cmdDeserialise2.Size = new System.Drawing.Size(75, 23);
            this.cmdDeserialise2.TabIndex = 2;
            this.cmdDeserialise2.Text = "All Crypto";
            this.cmdDeserialise2.UseVisualStyleBackColor = true;
            this.cmdDeserialise2.Click += new System.EventHandler(this.cmdDeserialise2_Click);
            // 
            // cmdClear2
            // 
            this.cmdClear2.Location = new System.Drawing.Point(481, 462);
            this.cmdClear2.Name = "cmdClear2";
            this.cmdClear2.Size = new System.Drawing.Size(88, 23);
            this.cmdClear2.TabIndex = 3;
            this.cmdClear2.Text = "Clear output";
            this.cmdClear2.UseVisualStyleBackColor = true;
            this.cmdClear2.Click += new System.EventHandler(this.cmdClear2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBTS);
            this.groupBox1.Controls.Add(this.checkZEC);
            this.groupBox1.Controls.Add(this.checkBCC);
            this.groupBox1.Controls.Add(this.checkEOS);
            this.groupBox1.Controls.Add(this.checkXRM);
            this.groupBox1.Controls.Add(this.checkDASH);
            this.groupBox1.Controls.Add(this.checkMIOTA);
            this.groupBox1.Controls.Add(this.checkETH);
            this.groupBox1.Controls.Add(this.checkLTC);
            this.groupBox1.Controls.Add(this.checkXLM);
            this.groupBox1.Controls.Add(this.checkADA);
            this.groupBox1.Controls.Add(this.checkBCH);
            this.groupBox1.Controls.Add(this.checkXRP);
            this.groupBox1.Controls.Add(this.checkTRX);
            this.groupBox1.Controls.Add(this.checkBTC);
            this.groupBox1.Location = new System.Drawing.Point(12, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 92);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypto selection tool";
            // 
            // checkBTS
            // 
            this.checkBTS.AutoSize = true;
            this.checkBTS.Location = new System.Drawing.Point(434, 65);
            this.checkBTS.Name = "checkBTS";
            this.checkBTS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBTS.Size = new System.Drawing.Size(47, 17);
            this.checkBTS.TabIndex = 0;
            this.checkBTS.Text = "BTS";
            this.checkBTS.UseVisualStyleBackColor = true;
            // 
            // checkZEC
            // 
            this.checkZEC.AutoSize = true;
            this.checkZEC.Location = new System.Drawing.Point(434, 42);
            this.checkZEC.Name = "checkZEC";
            this.checkZEC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkZEC.Size = new System.Drawing.Size(47, 17);
            this.checkZEC.TabIndex = 0;
            this.checkZEC.Text = "ZEC";
            this.checkZEC.UseVisualStyleBackColor = true;
            // 
            // checkBCC
            // 
            this.checkBCC.AutoSize = true;
            this.checkBCC.Location = new System.Drawing.Point(434, 19);
            this.checkBCC.Name = "checkBCC";
            this.checkBCC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBCC.Size = new System.Drawing.Size(47, 17);
            this.checkBCC.TabIndex = 0;
            this.checkBCC.Text = "BCC";
            this.checkBCC.UseVisualStyleBackColor = true;
            // 
            // checkEOS
            // 
            this.checkEOS.AutoSize = true;
            this.checkEOS.Location = new System.Drawing.Point(342, 65);
            this.checkEOS.Name = "checkEOS";
            this.checkEOS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkEOS.Size = new System.Drawing.Size(48, 17);
            this.checkEOS.TabIndex = 0;
            this.checkEOS.Text = "EOS";
            this.checkEOS.UseVisualStyleBackColor = true;
            // 
            // checkXRM
            // 
            this.checkXRM.AutoSize = true;
            this.checkXRM.Location = new System.Drawing.Point(340, 42);
            this.checkXRM.Name = "checkXRM";
            this.checkXRM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkXRM.Size = new System.Drawing.Size(50, 17);
            this.checkXRM.TabIndex = 0;
            this.checkXRM.Text = "XRM";
            this.checkXRM.UseVisualStyleBackColor = true;
            // 
            // checkDASH
            // 
            this.checkDASH.AutoSize = true;
            this.checkDASH.Location = new System.Drawing.Point(334, 20);
            this.checkDASH.Name = "checkDASH";
            this.checkDASH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkDASH.Size = new System.Drawing.Size(56, 17);
            this.checkDASH.TabIndex = 0;
            this.checkDASH.Text = "DASH";
            this.checkDASH.UseVisualStyleBackColor = true;
            // 
            // checkMIOTA
            // 
            this.checkMIOTA.AutoSize = true;
            this.checkMIOTA.Location = new System.Drawing.Point(230, 65);
            this.checkMIOTA.Name = "checkMIOTA";
            this.checkMIOTA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkMIOTA.Size = new System.Drawing.Size(60, 17);
            this.checkMIOTA.TabIndex = 0;
            this.checkMIOTA.Text = "MIOTA";
            this.checkMIOTA.UseVisualStyleBackColor = true;
            // 
            // checkETH
            // 
            this.checkETH.AutoSize = true;
            this.checkETH.Location = new System.Drawing.Point(151, 65);
            this.checkETH.Name = "checkETH";
            this.checkETH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkETH.Size = new System.Drawing.Size(48, 17);
            this.checkETH.TabIndex = 0;
            this.checkETH.Text = "ETH";
            this.checkETH.UseVisualStyleBackColor = true;
            // 
            // checkLTC
            // 
            this.checkLTC.AutoSize = true;
            this.checkLTC.Location = new System.Drawing.Point(244, 42);
            this.checkLTC.Name = "checkLTC";
            this.checkLTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkLTC.Size = new System.Drawing.Size(46, 17);
            this.checkLTC.TabIndex = 0;
            this.checkLTC.Text = "LTC";
            this.checkLTC.UseVisualStyleBackColor = true;
            // 
            // checkXLM
            // 
            this.checkXLM.AutoSize = true;
            this.checkXLM.Location = new System.Drawing.Point(151, 42);
            this.checkXLM.Name = "checkXLM";
            this.checkXLM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkXLM.Size = new System.Drawing.Size(48, 17);
            this.checkXLM.TabIndex = 0;
            this.checkXLM.Text = "XLM";
            this.checkXLM.UseVisualStyleBackColor = true;
            // 
            // checkADA
            // 
            this.checkADA.AutoSize = true;
            this.checkADA.Location = new System.Drawing.Point(60, 65);
            this.checkADA.Name = "checkADA";
            this.checkADA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkADA.Size = new System.Drawing.Size(48, 17);
            this.checkADA.TabIndex = 0;
            this.checkADA.Text = "ADA";
            this.checkADA.UseVisualStyleBackColor = true;
            // 
            // checkBCH
            // 
            this.checkBCH.AutoSize = true;
            this.checkBCH.Location = new System.Drawing.Point(242, 19);
            this.checkBCH.Name = "checkBCH";
            this.checkBCH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBCH.Size = new System.Drawing.Size(48, 17);
            this.checkBCH.TabIndex = 0;
            this.checkBCH.Text = "BCH";
            this.checkBCH.UseVisualStyleBackColor = true;
            // 
            // checkXRP
            // 
            this.checkXRP.AutoSize = true;
            this.checkXRP.Location = new System.Drawing.Point(60, 42);
            this.checkXRP.Name = "checkXRP";
            this.checkXRP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkXRP.Size = new System.Drawing.Size(48, 17);
            this.checkXRP.TabIndex = 0;
            this.checkXRP.Text = "XRP";
            this.checkXRP.UseVisualStyleBackColor = true;
            // 
            // checkTRX
            // 
            this.checkTRX.AutoSize = true;
            this.checkTRX.Location = new System.Drawing.Point(151, 19);
            this.checkTRX.Name = "checkTRX";
            this.checkTRX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkTRX.Size = new System.Drawing.Size(48, 17);
            this.checkTRX.TabIndex = 0;
            this.checkTRX.Text = "TRX";
            this.checkTRX.UseVisualStyleBackColor = true;
            // 
            // checkBTC
            // 
            this.checkBTC.AutoSize = true;
            this.checkBTC.Location = new System.Drawing.Point(60, 19);
            this.checkBTC.Name = "checkBTC";
            this.checkBTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBTC.Size = new System.Drawing.Size(47, 17);
            this.checkBTC.TabIndex = 0;
            this.checkBTC.Text = "BTC";
            this.checkBTC.UseVisualStyleBackColor = true;
            // 
            // btnTopTen
            // 
            this.btnTopTen.Location = new System.Drawing.Point(207, 261);
            this.btnTopTen.Name = "btnTopTen";
            this.btnTopTen.Size = new System.Drawing.Size(90, 23);
            this.btnTopTen.TabIndex = 5;
            this.btnTopTen.Text = "Top 10 Rank";
            this.btnTopTen.UseVisualStyleBackColor = true;
            // 
            // btnTopPercentageHour
            // 
            this.btnTopPercentageHour.Location = new System.Drawing.Point(303, 261);
            this.btnTopPercentageHour.Name = "btnTopPercentageHour";
            this.btnTopPercentageHour.Size = new System.Drawing.Size(75, 23);
            this.btnTopPercentageHour.TabIndex = 6;
            this.btnTopPercentageHour.Text = "Top % Hour";
            this.btnTopPercentageHour.UseVisualStyleBackColor = true;
            // 
            // btnTopPercentageDay
            // 
            this.btnTopPercentageDay.Location = new System.Drawing.Point(384, 261);
            this.btnTopPercentageDay.Name = "btnTopPercentageDay";
            this.btnTopPercentageDay.Size = new System.Drawing.Size(75, 23);
            this.btnTopPercentageDay.TabIndex = 6;
            this.btnTopPercentageDay.Text = "Top % Day";
            this.btnTopPercentageDay.UseVisualStyleBackColor = true;
            // 
            // btnCheckBoxSelection
            // 
            this.btnCheckBoxSelection.Location = new System.Drawing.Point(494, 214);
            this.btnCheckBoxSelection.Name = "btnCheckBoxSelection";
            this.btnCheckBoxSelection.Size = new System.Drawing.Size(75, 23);
            this.btnCheckBoxSelection.TabIndex = 7;
            this.btnCheckBoxSelection.Text = "Go";
            this.btnCheckBoxSelection.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(497, 43);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(35, 13);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(592, 492);
            this.Controls.Add(this.btnCheckBoxSelection);
            this.Controls.Add(this.btnTopPercentageDay);
            this.Controls.Add(this.btnTopPercentageHour);
            this.Controls.Add(this.btnTopTen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdClear2);
            this.Controls.Add(this.cmdDeserialise2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Name = "Form1";
            this.Text = "Crypto GUI Tool";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cmbFiat;
        private System.Windows.Forms.ComboBox cmbCrypto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdDeserialise2;
        private System.Windows.Forms.Button cmdClear2;
        private System.Windows.Forms.TextBox txtDebugOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTopTen;
        private System.Windows.Forms.Button btnTopPercentageHour;
        private System.Windows.Forms.Button btnTopPercentageDay;
        private System.Windows.Forms.CheckBox checkBTS;
        private System.Windows.Forms.CheckBox checkZEC;
        private System.Windows.Forms.CheckBox checkBCC;
        private System.Windows.Forms.CheckBox checkEOS;
        private System.Windows.Forms.CheckBox checkXRM;
        private System.Windows.Forms.CheckBox checkDASH;
        private System.Windows.Forms.CheckBox checkMIOTA;
        private System.Windows.Forms.CheckBox checkETH;
        private System.Windows.Forms.CheckBox checkLTC;
        private System.Windows.Forms.CheckBox checkXLM;
        private System.Windows.Forms.CheckBox checkADA;
        private System.Windows.Forms.CheckBox checkBCH;
        private System.Windows.Forms.CheckBox checkXRP;
        private System.Windows.Forms.CheckBox checkTRX;
        private System.Windows.Forms.CheckBox checkBTC;
        private System.Windows.Forms.Button btnCheckBoxSelection;
        private System.Windows.Forms.Label lblResult;
    }
}

