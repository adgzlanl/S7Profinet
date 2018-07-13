namespace S7Profinet
{
    partial class MainPage
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVerbindung = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtSlot = new System.Windows.Forms.TextBox();
            this.txtRack = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.cBoxCPUType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tmrStart = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtWordRead = new System.Windows.Forms.TextBox();
            this.txtDwordRead = new System.Windows.Forms.TextBox();
            this.txtDintRead = new System.Windows.Forms.TextBox();
            this.txtRealRead = new System.Windows.Forms.TextBox();
            this.txtIntRead = new System.Windows.Forms.TextBox();
            this.txtOutputRead = new System.Windows.Forms.TextBox();
            this.txtInputRead = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOutputFalse = new System.Windows.Forms.Button();
            this.btnOutputTrue = new System.Windows.Forms.Button();
            this.btnWord = new System.Windows.Forms.Button();
            this.btnDword = new System.Windows.Forms.Button();
            this.btnDint = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.btnInt = new System.Windows.Forms.Button();
            this.btnInputFalse = new System.Windows.Forms.Button();
            this.txtWordWrite = new System.Windows.Forms.TextBox();
            this.txtDwordWrite = new System.Windows.Forms.TextBox();
            this.txtDintWrite = new System.Windows.Forms.TextBox();
            this.txtRealWrite = new System.Windows.Forms.TextBox();
            this.txtIntWrite = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnInputTrue = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblVerbindung);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.txtSlot);
            this.groupBox1.Controls.Add(this.txtRack);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Controls.Add(this.cBoxCPUType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(305, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Verbindung";
            // 
            // lblVerbindung
            // 
            this.lblVerbindung.AutoSize = true;
            this.lblVerbindung.Location = new System.Drawing.Point(5, 163);
            this.lblVerbindung.Name = "lblVerbindung";
            this.lblVerbindung.Size = new System.Drawing.Size(97, 13);
            this.lblVerbindung.TabIndex = 7;
            this.lblVerbindung.Text = "Verbindung  Status";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(137, 126);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(70, 25);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Verbinden";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(216, 126);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(70, 25);
            this.btnDisconnect.TabIndex = 6;
            this.btnDisconnect.Text = "Trennen";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtSlot
            // 
            this.txtSlot.Location = new System.Drawing.Point(130, 97);
            this.txtSlot.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlot.Name = "txtSlot";
            this.txtSlot.Size = new System.Drawing.Size(159, 20);
            this.txtSlot.TabIndex = 4;
            this.txtSlot.Text = "1";
            // 
            // txtRack
            // 
            this.txtRack.Location = new System.Drawing.Point(130, 72);
            this.txtRack.Margin = new System.Windows.Forms.Padding(2);
            this.txtRack.Name = "txtRack";
            this.txtRack.Size = new System.Drawing.Size(159, 20);
            this.txtRack.TabIndex = 3;
            this.txtRack.Text = "0";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(130, 46);
            this.txtIP.Margin = new System.Windows.Forms.Padding(2);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(159, 20);
            this.txtIP.TabIndex = 2;
            this.txtIP.Text = "127.0.0.1";
            // 
            // cBoxCPUType
            // 
            this.cBoxCPUType.FormattingEnabled = true;
            this.cBoxCPUType.Location = new System.Drawing.Point(130, 20);
            this.cBoxCPUType.Margin = new System.Windows.Forms.Padding(2);
            this.cBoxCPUType.Name = "cBoxCPUType";
            this.cBoxCPUType.Size = new System.Drawing.Size(159, 21);
            this.cBoxCPUType.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Slot:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 76);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rack:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP Adresse:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SPS Type:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tmrStart
            // 
            this.tmrStart.Location = new System.Drawing.Point(197, 218);
            this.tmrStart.Name = "tmrStart";
            this.tmrStart.Size = new System.Drawing.Size(75, 23);
            this.tmrStart.TabIndex = 19;
            this.tmrStart.Text = "Timer";
            this.tmrStart.UseVisualStyleBackColor = true;
            this.tmrStart.Click += new System.EventHandler(this.tmrStart_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtWordRead);
            this.groupBox3.Controls.Add(this.txtDwordRead);
            this.groupBox3.Controls.Add(this.txtDintRead);
            this.groupBox3.Controls.Add(this.txtRealRead);
            this.groupBox3.Controls.Add(this.txtIntRead);
            this.groupBox3.Controls.Add(this.txtOutputRead);
            this.groupBox3.Controls.Add(this.txtInputRead);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tmrStart);
            this.groupBox3.Location = new System.Drawing.Point(363, 10);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(298, 326);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DB2 Array Auslesen";
            // 
            // txtWordRead
            // 
            this.txtWordRead.Location = new System.Drawing.Point(113, 192);
            this.txtWordRead.Name = "txtWordRead";
            this.txtWordRead.Size = new System.Drawing.Size(159, 20);
            this.txtWordRead.TabIndex = 18;
            // 
            // txtDwordRead
            // 
            this.txtDwordRead.Location = new System.Drawing.Point(113, 166);
            this.txtDwordRead.Name = "txtDwordRead";
            this.txtDwordRead.Size = new System.Drawing.Size(159, 20);
            this.txtDwordRead.TabIndex = 17;
            // 
            // txtDintRead
            // 
            this.txtDintRead.Location = new System.Drawing.Point(113, 140);
            this.txtDintRead.Name = "txtDintRead";
            this.txtDintRead.Size = new System.Drawing.Size(159, 20);
            this.txtDintRead.TabIndex = 16;
            // 
            // txtRealRead
            // 
            this.txtRealRead.Location = new System.Drawing.Point(113, 109);
            this.txtRealRead.Name = "txtRealRead";
            this.txtRealRead.Size = new System.Drawing.Size(159, 20);
            this.txtRealRead.TabIndex = 15;
            // 
            // txtIntRead
            // 
            this.txtIntRead.Location = new System.Drawing.Point(113, 82);
            this.txtIntRead.Name = "txtIntRead";
            this.txtIntRead.Size = new System.Drawing.Size(159, 20);
            this.txtIntRead.TabIndex = 14;
            // 
            // txtOutputRead
            // 
            this.txtOutputRead.Location = new System.Drawing.Point(113, 55);
            this.txtOutputRead.Name = "txtOutputRead";
            this.txtOutputRead.Size = new System.Drawing.Size(159, 20);
            this.txtOutputRead.TabIndex = 13;
            // 
            // txtInputRead
            // 
            this.txtInputRead.Location = new System.Drawing.Point(113, 25);
            this.txtInputRead.Name = "txtInputRead";
            this.txtInputRead.Size = new System.Drawing.Size(159, 20);
            this.txtInputRead.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(21, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(71, 13);
            this.label14.TabIndex = 9;
            this.label14.Text = "wordVariable:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "dwordVariable:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 7;
            this.label12.Text = "dintVariable:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 109);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 6;
            this.label11.Text = "real Variable:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "int Variable:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "bool Ausgang:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "bool Eingang:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnOutputFalse);
            this.groupBox4.Controls.Add(this.btnOutputTrue);
            this.groupBox4.Controls.Add(this.btnWord);
            this.groupBox4.Controls.Add(this.btnDword);
            this.groupBox4.Controls.Add(this.btnDint);
            this.groupBox4.Controls.Add(this.btnReal);
            this.groupBox4.Controls.Add(this.btnInt);
            this.groupBox4.Controls.Add(this.btnInputFalse);
            this.groupBox4.Controls.Add(this.txtWordWrite);
            this.groupBox4.Controls.Add(this.txtDwordWrite);
            this.groupBox4.Controls.Add(this.txtDintWrite);
            this.groupBox4.Controls.Add(this.txtRealWrite);
            this.groupBox4.Controls.Add(this.txtIntWrite);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label18);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.btnInputTrue);
            this.groupBox4.Location = new System.Drawing.Point(719, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(416, 326);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "DB2 Single Variable Schreiben";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(335, 219);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 36;
            this.btnReset.Text = "Rücksetzen";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOutputFalse
            // 
            this.btnOutputFalse.Location = new System.Drawing.Point(158, 52);
            this.btnOutputFalse.Name = "btnOutputFalse";
            this.btnOutputFalse.Size = new System.Drawing.Size(123, 23);
            this.btnOutputFalse.TabIndex = 35;
            this.btnOutputFalse.Text = "Ausgang False Schr.";
            this.btnOutputFalse.UseVisualStyleBackColor = true;
            this.btnOutputFalse.Click += new System.EventHandler(this.btnOutputFalse_Click);
            // 
            // btnOutputTrue
            // 
            this.btnOutputTrue.Location = new System.Drawing.Point(287, 51);
            this.btnOutputTrue.Name = "btnOutputTrue";
            this.btnOutputTrue.Size = new System.Drawing.Size(123, 23);
            this.btnOutputTrue.TabIndex = 34;
            this.btnOutputTrue.Text = "Ausgang True Schr.";
            this.btnOutputTrue.UseVisualStyleBackColor = true;
            this.btnOutputTrue.Click += new System.EventHandler(this.btnOutputTrue_Click);
            // 
            // btnWord
            // 
            this.btnWord.Location = new System.Drawing.Point(287, 189);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(123, 23);
            this.btnWord.TabIndex = 33;
            this.btnWord.Text = "Word Schr.";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // btnDword
            // 
            this.btnDword.Location = new System.Drawing.Point(287, 163);
            this.btnDword.Name = "btnDword";
            this.btnDword.Size = new System.Drawing.Size(123, 23);
            this.btnDword.TabIndex = 32;
            this.btnDword.Text = "Dword Schr.";
            this.btnDword.UseVisualStyleBackColor = true;
            this.btnDword.Click += new System.EventHandler(this.btnDword_Click);
            // 
            // btnDint
            // 
            this.btnDint.Location = new System.Drawing.Point(287, 137);
            this.btnDint.Name = "btnDint";
            this.btnDint.Size = new System.Drawing.Size(123, 23);
            this.btnDint.TabIndex = 31;
            this.btnDint.Text = "Dint Schr.";
            this.btnDint.UseVisualStyleBackColor = true;
            this.btnDint.Click += new System.EventHandler(this.btnDint_Click);
            // 
            // btnReal
            // 
            this.btnReal.Location = new System.Drawing.Point(287, 106);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(123, 23);
            this.btnReal.TabIndex = 30;
            this.btnReal.Text = "Real Schr.";
            this.btnReal.UseVisualStyleBackColor = true;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // btnInt
            // 
            this.btnInt.Location = new System.Drawing.Point(287, 79);
            this.btnInt.Name = "btnInt";
            this.btnInt.Size = new System.Drawing.Size(123, 23);
            this.btnInt.TabIndex = 29;
            this.btnInt.Text = "Int Schr.";
            this.btnInt.UseVisualStyleBackColor = true;
            this.btnInt.Click += new System.EventHandler(this.btnInt_Click);
            // 
            // btnInputFalse
            // 
            this.btnInputFalse.Location = new System.Drawing.Point(158, 23);
            this.btnInputFalse.Name = "btnInputFalse";
            this.btnInputFalse.Size = new System.Drawing.Size(123, 23);
            this.btnInputFalse.TabIndex = 28;
            this.btnInputFalse.Text = "Eingang False Schr.";
            this.btnInputFalse.UseVisualStyleBackColor = true;
            this.btnInputFalse.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // txtWordWrite
            // 
            this.txtWordWrite.Location = new System.Drawing.Point(113, 192);
            this.txtWordWrite.Name = "txtWordWrite";
            this.txtWordWrite.Size = new System.Drawing.Size(159, 20);
            this.txtWordWrite.TabIndex = 26;
            // 
            // txtDwordWrite
            // 
            this.txtDwordWrite.Location = new System.Drawing.Point(113, 166);
            this.txtDwordWrite.Name = "txtDwordWrite";
            this.txtDwordWrite.Size = new System.Drawing.Size(159, 20);
            this.txtDwordWrite.TabIndex = 25;
            // 
            // txtDintWrite
            // 
            this.txtDintWrite.Location = new System.Drawing.Point(113, 140);
            this.txtDintWrite.Name = "txtDintWrite";
            this.txtDintWrite.Size = new System.Drawing.Size(159, 20);
            this.txtDintWrite.TabIndex = 24;
            // 
            // txtRealWrite
            // 
            this.txtRealWrite.Location = new System.Drawing.Point(113, 109);
            this.txtRealWrite.Name = "txtRealWrite";
            this.txtRealWrite.Size = new System.Drawing.Size(159, 20);
            this.txtRealWrite.TabIndex = 23;
            // 
            // txtIntWrite
            // 
            this.txtIntWrite.Location = new System.Drawing.Point(113, 82);
            this.txtIntWrite.Name = "txtIntWrite";
            this.txtIntWrite.Size = new System.Drawing.Size(159, 20);
            this.txtIntWrite.TabIndex = 22;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(21, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 9;
            this.label15.Text = "wordVariable:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(21, 163);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "dwordVariable:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 13);
            this.label17.TabIndex = 7;
            this.label17.Text = "dintVariable:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(21, 109);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 13);
            this.label18.TabIndex = 6;
            this.label18.Text = "real Variable:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(21, 82);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(62, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "int Variable:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 55);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(75, 13);
            this.label20.TabIndex = 4;
            this.label20.Text = "bool Ausgang:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(21, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(72, 13);
            this.label21.TabIndex = 3;
            this.label21.Text = "bool Eingang:";
            // 
            // btnInputTrue
            // 
            this.btnInputTrue.Location = new System.Drawing.Point(287, 22);
            this.btnInputTrue.Name = "btnInputTrue";
            this.btnInputTrue.Size = new System.Drawing.Size(123, 23);
            this.btnInputTrue.TabIndex = 27;
            this.btnInputTrue.Text = "Eingang True Schr.";
            this.btnInputTrue.UseVisualStyleBackColor = true;
            this.btnInputTrue.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 830);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainPage";
            this.Text = "S7 Profinet Test Program";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainPage_FormClosed);
            this.Load += new System.EventHandler(this.MainPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtSlot;
        private System.Windows.Forms.TextBox txtRack;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.ComboBox cBoxCPUType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button tmrStart;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtWordRead;
        private System.Windows.Forms.TextBox txtDwordRead;
        private System.Windows.Forms.TextBox txtDintRead;
        private System.Windows.Forms.TextBox txtRealRead;
        private System.Windows.Forms.TextBox txtIntRead;
        private System.Windows.Forms.TextBox txtOutputRead;
        private System.Windows.Forms.TextBox txtInputRead;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnWord;
        private System.Windows.Forms.Button btnDword;
        private System.Windows.Forms.Button btnDint;
        private System.Windows.Forms.Button btnReal;
        private System.Windows.Forms.Button btnInt;
        private System.Windows.Forms.Button btnInputFalse;
        private System.Windows.Forms.TextBox txtWordWrite;
        private System.Windows.Forms.TextBox txtDwordWrite;
        private System.Windows.Forms.TextBox txtDintWrite;
        private System.Windows.Forms.TextBox txtRealWrite;
        private System.Windows.Forms.TextBox txtIntWrite;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnInputTrue;
        private System.Windows.Forms.Button btnOutputFalse;
        private System.Windows.Forms.Button btnOutputTrue;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblVerbindung;
    }
}

