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
            this.components = new System.ComponentModel.Container();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkSum = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.textQuantity = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cmbFiat = new System.Windows.Forms.ComboBox();
            this.cmbCrypto = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtDebugOutput = new System.Windows.Forms.TextBox();
            this.cmdDeserialise2 = new System.Windows.Forms.Button();
            this.cmdClear2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkXVG = new System.Windows.Forms.CheckBox();
            this.checkBTS = new System.Windows.Forms.CheckBox();
            this.checkZEC = new System.Windows.Forms.CheckBox();
            this.checkBCC = new System.Windows.Forms.CheckBox();
            this.checkEOS = new System.Windows.Forms.CheckBox();
            this.checkXRM = new System.Windows.Forms.CheckBox();
            this.checkDASH = new System.Windows.Forms.CheckBox();
            this.checkMIOTA = new System.Windows.Forms.CheckBox();
            this.checkTRX = new System.Windows.Forms.CheckBox();
            this.checkETH = new System.Windows.Forms.CheckBox();
            this.checkXLM = new System.Windows.Forms.CheckBox();
            this.checkLTC = new System.Windows.Forms.CheckBox();
            this.checkADA = new System.Windows.Forms.CheckBox();
            this.checkXRP = new System.Windows.Forms.CheckBox();
            this.checkBTC = new System.Windows.Forms.CheckBox();
            this.btnTopTen = new System.Windows.Forms.Button();
            this.btnCheckBoxSelection = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.lblSum);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.checkSum);
            this.groupBox4.Controls.Add(this.lblResult);
            this.groupBox4.Controls.Add(this.textQuantity);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.cmbFiat);
            this.groupBox4.Controls.Add(this.cmbCrypto);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(25, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(656, 100);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Exchange tool";
            this.toolTip1.SetToolTip(this.groupBox4, "Tool for exchanging crypto currencies in EUR or USD.\r\nChoose a Crypto, insert the" +
        " amount you want exchange\r\nand select the fiat currency. Press Exchange and see " +
        "the\r\nresult also in Output Console.");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(2, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sum: ";
            this.label2.Visible = false;
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSum.ForeColor = System.Drawing.Color.Maroon;
            this.lblSum.Location = new System.Drawing.Point(62, 70);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(0, 16);
            this.lblSum.TabIndex = 8;
            this.lblSum.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(460, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Sum";
            // 
            // checkSum
            // 
            this.checkSum.AutoSize = true;
            this.checkSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSum.Location = new System.Drawing.Point(467, 39);
            this.checkSum.Name = "checkSum";
            this.checkSum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkSum.Size = new System.Drawing.Size(15, 14);
            this.checkSum.TabIndex = 5;
            this.checkSum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip1.SetToolTip(this.checkSum, "Selecting this checkbox will be possibile to sum the results\r\nobtained.");
            this.checkSum.UseVisualStyleBackColor = true;
            this.checkSum.CheckedChanged += new System.EventHandler(this.checkSum_CheckedChanged);
            // 
            // lblResult
            // 
            this.lblResult.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblResult.AutoSize = true;
            this.lblResult.BackColor = System.Drawing.SystemColors.Control;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResult.Location = new System.Drawing.Point(497, 39);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 16);
            this.lblResult.TabIndex = 4;
            // 
            // textQuantity
            // 
            this.textQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textQuantity.Location = new System.Drawing.Point(133, 34);
            this.textQuantity.Name = "textQuantity";
            this.textQuantity.Size = new System.Drawing.Size(100, 22);
            this.textQuantity.TabIndex = 3;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(239, 33);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(92, 25);
            this.button6.TabIndex = 2;
            this.button6.Text = "Exchange";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cmbFiat
            // 
            this.cmbFiat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFiat.FormattingEnabled = true;
            this.cmbFiat.Items.AddRange(new object[] {
            "EUR",
            "USD"});
            this.cmbFiat.Location = new System.Drawing.Point(337, 34);
            this.cmbFiat.Name = "cmbFiat";
            this.cmbFiat.Size = new System.Drawing.Size(121, 24);
            this.cmbFiat.TabIndex = 1;
            // 
            // cmbCrypto
            // 
            this.cmbCrypto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrypto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCrypto.FormattingEnabled = true;
            this.cmbCrypto.Items.AddRange(new object[] {
            "Bitcoin",
            "Verge",
            "Ripple",
            "Cardano",
            "Tron",
            "Litecoin",
            "Iota",
            "Monero",
            "Ethereum",
            "Stellar",
            "Dash",
            "Eos",
            "Zcash",
            "BitShares"});
            this.cmbCrypto.Location = new System.Drawing.Point(6, 34);
            this.cmbCrypto.Name = "cmbCrypto";
            this.cmbCrypto.Size = new System.Drawing.Size(121, 24);
            this.cmbCrypto.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(355, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Fiat currency";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(160, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Crypto";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.txtDebugOutput);
            this.groupBox5.Location = new System.Drawing.Point(705, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(469, 224);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Output Console";
            // 
            // txtDebugOutput
            // 
            this.txtDebugOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtDebugOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDebugOutput.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtDebugOutput.Location = new System.Drawing.Point(6, 19);
            this.txtDebugOutput.Multiline = true;
            this.txtDebugOutput.Name = "txtDebugOutput";
            this.txtDebugOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDebugOutput.Size = new System.Drawing.Size(457, 189);
            this.txtDebugOutput.TabIndex = 0;
            // 
            // cmdDeserialise2
            // 
            this.cmdDeserialise2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDeserialise2.Location = new System.Drawing.Point(545, 548);
            this.cmdDeserialise2.Name = "cmdDeserialise2";
            this.cmdDeserialise2.Size = new System.Drawing.Size(75, 23);
            this.cmdDeserialise2.TabIndex = 2;
            this.cmdDeserialise2.Text = "All Crypto";
            this.toolTip1.SetToolTip(this.cmdDeserialise2, "Press to get info of the first top 100 rank crypto currencies.\r\n");
            this.cmdDeserialise2.UseVisualStyleBackColor = true;
            this.cmdDeserialise2.Click += new System.EventHandler(this.cmdDeserialise2_Click);
            // 
            // cmdClear2
            // 
            this.cmdClear2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmdClear2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdClear2.Location = new System.Drawing.Point(1086, 242);
            this.cmdClear2.Name = "cmdClear2";
            this.cmdClear2.Size = new System.Drawing.Size(88, 25);
            this.cmdClear2.TabIndex = 3;
            this.cmdClear2.Text = "Clear output";
            this.cmdClear2.UseVisualStyleBackColor = true;
            this.cmdClear2.Click += new System.EventHandler(this.cmdClear2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.checkXVG);
            this.groupBox1.Controls.Add(this.checkBTS);
            this.groupBox1.Controls.Add(this.checkZEC);
            this.groupBox1.Controls.Add(this.checkBCC);
            this.groupBox1.Controls.Add(this.checkEOS);
            this.groupBox1.Controls.Add(this.checkXRM);
            this.groupBox1.Controls.Add(this.checkDASH);
            this.groupBox1.Controls.Add(this.checkMIOTA);
            this.groupBox1.Controls.Add(this.checkTRX);
            this.groupBox1.Controls.Add(this.checkETH);
            this.groupBox1.Controls.Add(this.checkXLM);
            this.groupBox1.Controls.Add(this.checkLTC);
            this.groupBox1.Controls.Add(this.checkADA);
            this.groupBox1.Controls.Add(this.checkXRP);
            this.groupBox1.Controls.Add(this.checkBTC);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(656, 101);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crypto selection tool";
            this.toolTip1.SetToolTip(this.groupBox1, "Select one or more crypto currencies and press Go for getting info.");
            // 
            // checkXVG
            // 
            this.checkXVG.AutoSize = true;
            this.checkXVG.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXVG.Location = new System.Drawing.Point(282, 26);
            this.checkXVG.Name = "checkXVG";
            this.checkXVG.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkXVG.Size = new System.Drawing.Size(101, 20);
            this.checkXVG.TabIndex = 1;
            this.checkXVG.Text = "XVG - Verge";
            this.checkXVG.UseVisualStyleBackColor = true;
            // 
            // checkBTS
            // 
            this.checkBTS.AutoSize = true;
            this.checkBTS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBTS.Location = new System.Drawing.Point(518, 72);
            this.checkBTS.Name = "checkBTS";
            this.checkBTS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBTS.Size = new System.Drawing.Size(122, 20);
            this.checkBTS.TabIndex = 0;
            this.checkBTS.Text = "BTS - BitShares";
            this.checkBTS.UseVisualStyleBackColor = true;
            // 
            // checkZEC
            // 
            this.checkZEC.AutoSize = true;
            this.checkZEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkZEC.Location = new System.Drawing.Point(520, 49);
            this.checkZEC.Name = "checkZEC";
            this.checkZEC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkZEC.Size = new System.Drawing.Size(100, 20);
            this.checkZEC.TabIndex = 0;
            this.checkZEC.Text = "ZEC - Zcash";
            this.checkZEC.UseVisualStyleBackColor = true;
            // 
            // checkBCC
            // 
            this.checkBCC.AutoSize = true;
            this.checkBCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBCC.Location = new System.Drawing.Point(511, 26);
            this.checkBCC.Name = "checkBCC";
            this.checkBCC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBCC.Size = new System.Drawing.Size(128, 20);
            this.checkBCC.TabIndex = 0;
            this.checkBCC.Text = "BCC - BitConnect";
            this.checkBCC.UseVisualStyleBackColor = true;
            // 
            // checkEOS
            // 
            this.checkEOS.AutoSize = true;
            this.checkEOS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkEOS.Location = new System.Drawing.Point(420, 49);
            this.checkEOS.Name = "checkEOS";
            this.checkEOS.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkEOS.Size = new System.Drawing.Size(55, 20);
            this.checkEOS.TabIndex = 0;
            this.checkEOS.Text = "EOS";
            this.checkEOS.UseVisualStyleBackColor = true;
            // 
            // checkXRM
            // 
            this.checkXRM.AutoSize = true;
            this.checkXRM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXRM.Location = new System.Drawing.Point(385, 72);
            this.checkXRM.Name = "checkXRM";
            this.checkXRM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkXRM.Size = new System.Drawing.Size(112, 20);
            this.checkXRM.TabIndex = 0;
            this.checkXRM.Text = "XRM - Monero";
            this.checkXRM.UseVisualStyleBackColor = true;
            // 
            // checkDASH
            // 
            this.checkDASH.AutoSize = true;
            this.checkDASH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDASH.Location = new System.Drawing.Point(423, 26);
            this.checkDASH.Name = "checkDASH";
            this.checkDASH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkDASH.Size = new System.Drawing.Size(65, 20);
            this.checkDASH.TabIndex = 0;
            this.checkDASH.Text = "DASH";
            this.checkDASH.UseVisualStyleBackColor = true;
            // 
            // checkMIOTA
            // 
            this.checkMIOTA.AutoSize = true;
            this.checkMIOTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMIOTA.Location = new System.Drawing.Point(268, 72);
            this.checkMIOTA.Name = "checkMIOTA";
            this.checkMIOTA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkMIOTA.Size = new System.Drawing.Size(101, 20);
            this.checkMIOTA.TabIndex = 0;
            this.checkMIOTA.Text = "MIOTA - Iota";
            this.checkMIOTA.UseVisualStyleBackColor = true;
            // 
            // checkTRX
            // 
            this.checkTRX.AutoSize = true;
            this.checkTRX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTRX.Location = new System.Drawing.Point(147, 49);
            this.checkTRX.Name = "checkTRX";
            this.checkTRX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkTRX.Size = new System.Drawing.Size(92, 20);
            this.checkTRX.TabIndex = 0;
            this.checkTRX.Text = "TRX - Tron";
            this.checkTRX.UseVisualStyleBackColor = true;
            // 
            // checkETH
            // 
            this.checkETH.AutoSize = true;
            this.checkETH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkETH.Location = new System.Drawing.Point(128, 26);
            this.checkETH.Name = "checkETH";
            this.checkETH.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkETH.Size = new System.Drawing.Size(122, 20);
            this.checkETH.TabIndex = 0;
            this.checkETH.Text = "ETH - Ethereum";
            this.checkETH.UseVisualStyleBackColor = true;
            // 
            // checkXLM
            // 
            this.checkXLM.AutoSize = true;
            this.checkXLM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXLM.Location = new System.Drawing.Point(147, 72);
            this.checkXLM.Name = "checkXLM";
            this.checkXLM.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkXLM.Size = new System.Drawing.Size(101, 20);
            this.checkXLM.TabIndex = 0;
            this.checkXLM.Text = "XLM - Stellar";
            this.checkXLM.UseVisualStyleBackColor = true;
            // 
            // checkLTC
            // 
            this.checkLTC.AutoSize = true;
            this.checkLTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkLTC.Location = new System.Drawing.Point(286, 50);
            this.checkLTC.Name = "checkLTC";
            this.checkLTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkLTC.Size = new System.Drawing.Size(108, 20);
            this.checkLTC.TabIndex = 0;
            this.checkLTC.Text = "LTC - Litecoin";
            this.checkLTC.UseVisualStyleBackColor = true;
            // 
            // checkADA
            // 
            this.checkADA.AutoSize = true;
            this.checkADA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkADA.Location = new System.Drawing.Point(6, 72);
            this.checkADA.Name = "checkADA";
            this.checkADA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkADA.Size = new System.Drawing.Size(117, 20);
            this.checkADA.TabIndex = 0;
            this.checkADA.Text = "ADA - Cardano";
            this.checkADA.UseVisualStyleBackColor = true;
            // 
            // checkXRP
            // 
            this.checkXRP.AutoSize = true;
            this.checkXRP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkXRP.Location = new System.Drawing.Point(15, 49);
            this.checkXRP.Name = "checkXRP";
            this.checkXRP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkXRP.Size = new System.Drawing.Size(104, 20);
            this.checkXRP.TabIndex = 0;
            this.checkXRP.Text = "XRP - Ripple";
            this.checkXRP.UseVisualStyleBackColor = true;
            // 
            // checkBTC
            // 
            this.checkBTC.AutoSize = true;
            this.checkBTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBTC.Location = new System.Drawing.Point(8, 25);
            this.checkBTC.Name = "checkBTC";
            this.checkBTC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBTC.Size = new System.Drawing.Size(104, 20);
            this.checkBTC.TabIndex = 0;
            this.checkBTC.Text = "BTC - Bitcoin";
            this.checkBTC.UseVisualStyleBackColor = true;
            this.checkBTC.CheckedChanged += new System.EventHandler(this.checkBTC_CheckedChanged);
            // 
            // btnTopTen
            // 
            this.btnTopTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTopTen.Location = new System.Drawing.Point(626, 548);
            this.btnTopTen.Name = "btnTopTen";
            this.btnTopTen.Size = new System.Drawing.Size(90, 23);
            this.btnTopTen.TabIndex = 5;
            this.btnTopTen.Text = "Top 10 Rank";
            this.toolTip1.SetToolTip(this.btnTopTen, "Press to get all info about the 10 top rank crypto currencies.");
            this.btnTopTen.UseVisualStyleBackColor = true;
            this.btnTopTen.Click += new System.EventHandler(this.btnTopTen_Click);
            // 
            // btnCheckBoxSelection
            // 
            this.btnCheckBoxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckBoxSelection.Location = new System.Drawing.Point(606, 244);
            this.btnCheckBoxSelection.Name = "btnCheckBoxSelection";
            this.btnCheckBoxSelection.Size = new System.Drawing.Size(75, 23);
            this.btnCheckBoxSelection.TabIndex = 7;
            this.btnCheckBoxSelection.Text = "Go";
            this.btnCheckBoxSelection.UseVisualStyleBackColor = true;
            this.btnCheckBoxSelection.Click += new System.EventHandler(this.btnCheckBoxSelection_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1162, 256);
            this.dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1205, 575);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCheckBoxSelection);
            this.Controls.Add(this.btnTopTen);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdClear2);
            this.Controls.Add(this.cmdDeserialise2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Crypto GUI Tool - Powered by Karlitos";
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox textQuantity;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.ComboBox cmbFiat;
        private System.Windows.Forms.ComboBox cmbCrypto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button cmdDeserialise2;
        private System.Windows.Forms.Button cmdClear2;
        private System.Windows.Forms.TextBox txtDebugOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTopTen;
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
        private System.Windows.Forms.CheckBox checkXRP;
        private System.Windows.Forms.CheckBox checkTRX;
        private System.Windows.Forms.CheckBox checkBTC;
        private System.Windows.Forms.Button btnCheckBoxSelection;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.CheckBox checkXVG;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox checkSum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

