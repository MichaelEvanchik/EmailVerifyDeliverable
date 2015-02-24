namespace WinEmailVerifier
{
    partial class frmMain
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
            this.txtBoxInputConnectionString = new System.Windows.Forms.GroupBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtKeyField2 = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.lblEmailFieldTo = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.lblSupressionIDdesc = new System.Windows.Forms.Label();
            this.lblSupressionID = new System.Windows.Forms.Label();
            this.txtSupressionID = new System.Windows.Forms.TextBox();
            this.lblReasonID = new System.Windows.Forms.Label();
            this.txtReasonID = new System.Windows.Forms.TextBox();
            this.lblReasonIDdesc = new System.Windows.Forms.Label();
            this.txtEmailFieldTo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmailFieldFrom = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.txtKeyField = new System.Windows.Forms.ComboBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sTestEmail = new System.Windows.Forms.TextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbltoDo = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.chkFixTyposMajorISP = new System.Windows.Forms.CheckBox();
            this.chkDeleteRoleUsernames = new System.Windows.Forms.CheckBox();
            this.chkDeleteSpamTrapDomains = new System.Windows.Forms.CheckBox();
            this.chkDeleteSpamTrapAddresses = new System.Windows.Forms.CheckBox();
            this.chkDeleteFictitiousDomains = new System.Windows.Forms.CheckBox();
            this.chkDeleteWirelessDomains = new System.Windows.Forms.CheckBox();
            this.chkDeleteEmailsWithNoMXgeneral = new System.Windows.Forms.CheckBox();
            this.chkDeleteBadFormatedMajorISP = new System.Windows.Forms.CheckBox();
            this.chkDeleteBadFormatedEmails = new System.Windows.Forms.CheckBox();
            this.chkDeleteEmailifMXcantVerifyGeneral = new System.Windows.Forms.CheckBox();
            this.chkDeleteEmailifMXcantVerifyMajorISP = new System.Windows.Forms.CheckBox();
            this.chkFixKnownTyposGeneral = new System.Windows.Forms.CheckBox();
            this.chkFixTypoSuffix = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDns = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPerMin = new System.Windows.Forms.TextBox();
            this.chkBoxRestart = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkMXCheck = new System.Windows.Forms.CheckBox();
            this.chkMajorIsp = new System.Windows.Forms.CheckBox();
            this.chkReRun = new System.Windows.Forms.CheckBox();
            this.chkContinue = new System.Windows.Forms.CheckBox();
            this.txtBoxInputConnectionString.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBoxInputConnectionString
            // 
            this.txtBoxInputConnectionString.Controls.Add(this.label38);
            this.txtBoxInputConnectionString.Controls.Add(this.txtKeyField2);
            this.txtBoxInputConnectionString.Controls.Add(this.label37);
            this.txtBoxInputConnectionString.Controls.Add(this.label36);
            this.txtBoxInputConnectionString.Controls.Add(this.lblEmailFieldTo);
            this.txtBoxInputConnectionString.Controls.Add(this.label35);
            this.txtBoxInputConnectionString.Controls.Add(this.label34);
            this.txtBoxInputConnectionString.Controls.Add(this.lblTest);
            this.txtBoxInputConnectionString.Controls.Add(this.lblSupressionIDdesc);
            this.txtBoxInputConnectionString.Controls.Add(this.lblSupressionID);
            this.txtBoxInputConnectionString.Controls.Add(this.txtSupressionID);
            this.txtBoxInputConnectionString.Controls.Add(this.lblReasonID);
            this.txtBoxInputConnectionString.Controls.Add(this.txtReasonID);
            this.txtBoxInputConnectionString.Controls.Add(this.lblReasonIDdesc);
            this.txtBoxInputConnectionString.Controls.Add(this.txtEmailFieldTo);
            this.txtBoxInputConnectionString.Controls.Add(this.label3);
            this.txtBoxInputConnectionString.Controls.Add(this.label2);
            this.txtBoxInputConnectionString.Controls.Add(this.txtEmailFieldFrom);
            this.txtBoxInputConnectionString.Controls.Add(this.txtTableName);
            this.txtBoxInputConnectionString.Controls.Add(this.txtKeyField);
            this.txtBoxInputConnectionString.Controls.Add(this.txtConnectionString);
            this.txtBoxInputConnectionString.Location = new System.Drawing.Point(13, 13);
            this.txtBoxInputConnectionString.Name = "txtBoxInputConnectionString";
            this.txtBoxInputConnectionString.Size = new System.Drawing.Size(796, 180);
            this.txtBoxInputConnectionString.TabIndex = 0;
            this.txtBoxInputConnectionString.TabStop = false;
            this.txtBoxInputConnectionString.Text = "Connection String";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(25, 136);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(159, 13);
            this.label38.TabIndex = 24;
            this.label38.Text = "^ Unique index strongly prefered";
            // 
            // txtKeyField2
            // 
            this.txtKeyField2.Location = new System.Drawing.Point(17, 109);
            this.txtKeyField2.Name = "txtKeyField2";
            this.txtKeyField2.Size = new System.Drawing.Size(54, 20);
            this.txtKeyField2.TabIndex = 23;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(14, 88);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(40, 13);
            this.label37.TabIndex = 22;
            this.label37.Text = "ID field";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(272, -1);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(38, 13);
            this.label36.TabIndex = 21;
            this.label36.Text = "User - ";
            // 
            // lblEmailFieldTo
            // 
            this.lblEmailFieldTo.AutoSize = true;
            this.lblEmailFieldTo.Location = new System.Drawing.Point(315, -1);
            this.lblEmailFieldTo.Name = "lblEmailFieldTo";
            this.lblEmailFieldTo.Size = new System.Drawing.Size(0, 13);
            this.lblEmailFieldTo.TabIndex = 20;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.ForeColor = System.Drawing.Color.Red;
            this.label35.Location = new System.Drawing.Point(281, 89);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(139, 13);
            this.label35.TabIndex = 19;
            this.label35.Text = "Field changed email goes to";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(297, -1);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(0, 13);
            this.label34.TabIndex = 18;
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblTest.Location = new System.Drawing.Point(86, 161);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(214, 13);
            this.lblTest.TabIndex = 17;
            this.lblTest.Text = "fields needs to be created if doesnt exist --->";
            // 
            // lblSupressionIDdesc
            // 
            this.lblSupressionIDdesc.Location = new System.Drawing.Point(543, 134);
            this.lblSupressionIDdesc.Name = "lblSupressionIDdesc";
            this.lblSupressionIDdesc.Size = new System.Drawing.Size(209, 41);
            this.lblSupressionIDdesc.TabIndex = 16;
            this.lblSupressionIDdesc.Text = "Field should be smallint or int or number and corresponds with the supression tab" +
    "le id column to track exact rule it fell under";
            // 
            // lblSupressionID
            // 
            this.lblSupressionID.AutoSize = true;
            this.lblSupressionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSupressionID.Location = new System.Drawing.Point(584, 89);
            this.lblSupressionID.Name = "lblSupressionID";
            this.lblSupressionID.Size = new System.Drawing.Size(100, 13);
            this.lblSupressionID.TabIndex = 15;
            this.lblSupressionID.Text = "actual supression id";
            // 
            // txtSupressionID
            // 
            this.txtSupressionID.Location = new System.Drawing.Point(587, 111);
            this.txtSupressionID.Name = "txtSupressionID";
            this.txtSupressionID.Size = new System.Drawing.Size(100, 20);
            this.txtSupressionID.TabIndex = 14;
            this.txtSupressionID.Text = "supressionid";
            // 
            // lblReasonID
            // 
            this.lblReasonID.AutoSize = true;
            this.lblReasonID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblReasonID.Location = new System.Drawing.Point(445, 89);
            this.lblReasonID.Name = "lblReasonID";
            this.lblReasonID.Size = new System.Drawing.Size(50, 13);
            this.lblReasonID.TabIndex = 13;
            this.lblReasonID.Text = "reason id";
            // 
            // txtReasonID
            // 
            this.txtReasonID.Location = new System.Drawing.Point(429, 111);
            this.txtReasonID.Name = "txtReasonID";
            this.txtReasonID.Size = new System.Drawing.Size(100, 20);
            this.txtReasonID.TabIndex = 12;
            this.txtReasonID.Text = "reasoncode";
            // 
            // lblReasonIDdesc
            // 
            this.lblReasonIDdesc.Location = new System.Drawing.Point(384, 134);
            this.lblReasonIDdesc.Name = "lblReasonIDdesc";
            this.lblReasonIDdesc.Size = new System.Drawing.Size(168, 40);
            this.lblReasonIDdesc.TabIndex = 11;
            this.lblReasonIDdesc.Text = "Field should be tinyint or int and will correspond with the violations table or n" +
    "umber in () below";
            this.lblReasonIDdesc.Visible = false;
            // 
            // txtEmailFieldTo
            // 
            this.txtEmailFieldTo.Location = new System.Drawing.Point(300, 109);
            this.txtEmailFieldTo.Name = "txtEmailFieldTo";
            this.txtEmailFieldTo.Size = new System.Drawing.Size(100, 20);
            this.txtEmailFieldTo.TabIndex = 9;
            this.txtEmailFieldTo.Text = "new_email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(165, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Field Name with Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Table Name";
            // 
            // txtEmailFieldFrom
            // 
            this.txtEmailFieldFrom.Location = new System.Drawing.Point(170, 109);
            this.txtEmailFieldFrom.Name = "txtEmailFieldFrom";
            this.txtEmailFieldFrom.Size = new System.Drawing.Size(106, 20);
            this.txtEmailFieldFrom.TabIndex = 3;
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(89, 109);
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(75, 20);
            this.txtTableName.TabIndex = 2;
            // 
            // txtKeyField
            // 
            this.txtKeyField.FormattingEnabled = true;
            this.txtKeyField.Items.AddRange(new object[] {
            "2 ODBC/DSN - DSN=myDsn;Uid=myUsername;Pwd=;",
            "1 SQL Server - Server=sql2012a;Database=EmailVerifier;User Id=sa;Password=Yankees" +
                "mets1;",
            "2 MySql - Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPasswor" +
                "d;",
            "2 Access 2003 or earlier - Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\mydata" +
                "base.mdb;User Id=admin;Password=;",
            "2 Access 2007 - Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\myFolder\\myAcces" +
                "s2007file.accdb;Persist Security Info=False;",
            "2 Excel 2003 or ealier(not yet supported) - Provider=Microsoft.Jet.OLEDB.4.0;Data" +
                " Source=C:\\MyExcel.xls;Extended Properties=\"Excel 8.0;HDR=Yes;IMEX=1\";",
            "2 Excel 2007(not yet supported) - Provider=Microsoft.ACE.OLEDB.12.0;Data Source=c" +
                ":\\myFolder\\myExcel2007file.xlsx;Extended Properties=\"Excel 12.0 Xml;HDR=YES\";",
            "2 Text file(not yet supported) - Provider=Microsoft.Jet.OLEDB.4.0;Data Source=c:\\" +
                "txtFilesFolder\\;Extended Properties=\"text;HDR=Yes;FMT=Delimited\";"});
            this.txtKeyField.Location = new System.Drawing.Point(14, 30);
            this.txtKeyField.Name = "txtKeyField";
            this.txtKeyField.Size = new System.Drawing.Size(738, 21);
            this.txtKeyField.TabIndex = 1;
            this.txtKeyField.Text = "Please choose one and edit the string below\'s paramaters";
            this.txtKeyField.SelectedIndexChanged += new System.EventHandler(this.cmbConnectionStrings_SelectedIndexChanged);
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(14, 66);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(738, 20);
            this.txtConnectionString.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sTestEmail);
            this.groupBox1.Controls.Add(this.btnTest);
            this.groupBox1.Location = new System.Drawing.Point(13, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 99);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // sTestEmail
            // 
            this.sTestEmail.Location = new System.Drawing.Point(18, 23);
            this.sTestEmail.Name = "sTestEmail";
            this.sTestEmail.Size = new System.Drawing.Size(210, 20);
            this.sTestEmail.TabIndex = 9;
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(18, 49);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(210, 36);
            this.btnTest.TabIndex = 10;
            this.btnTest.Text = "test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(310, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Typical local logic";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Green;
            this.label5.Location = new System.Drawing.Point(310, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Pretty typical - local logic";
            // 
            // label6
            // 
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(310, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 35);
            this.label6.TabIndex = 5;
            this.label6.Text = "Uses DNS server quick UDP lookup";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(447, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 61);
            this.label7.TabIndex = 6;
            this.label7.Text = "Connects to mx record and tries the VERIFY and/or RCPT TO (intrusive)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(303, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Order logic attempts options";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(563, 199);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(136, 40);
            this.btnExecute.TabIndex = 8;
            this.btnExecute.Text = "Execute/Verify/Clean";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // lbltoDo
            // 
            this.lbltoDo.Location = new System.Drawing.Point(66, 519);
            this.lbltoDo.Name = "lbltoDo";
            this.lbltoDo.Size = new System.Drawing.Size(139, 20);
            this.lbltoDo.TabIndex = 40;
            // 
            // lblTotal
            // 
            this.lblTotal.Location = new System.Drawing.Point(313, 519);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(168, 20);
            this.lblTotal.TabIndex = 41;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(23, 522);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(33, 13);
            this.label39.TabIndex = 42;
            this.label39.Text = "Done";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(250, 522);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 13);
            this.label40.TabIndex = 43;
            this.label40.Text = "Total in list ";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 554);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(722, 23);
            this.progressBar1.TabIndex = 44;
            // 
            // chkFixTyposMajorISP
            // 
            this.chkFixTyposMajorISP.AutoSize = true;
            this.chkFixTyposMajorISP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkFixTyposMajorISP.Location = new System.Drawing.Point(18, 19);
            this.chkFixTyposMajorISP.Name = "chkFixTyposMajorISP";
            this.chkFixTyposMajorISP.Size = new System.Drawing.Size(168, 17);
            this.chkFixTyposMajorISP.TabIndex = 0;
            this.chkFixTyposMajorISP.Text = "(1) Fix known typos major isp\'s";
            this.chkFixTyposMajorISP.UseVisualStyleBackColor = true;
            // 
            // chkDeleteRoleUsernames
            // 
            this.chkDeleteRoleUsernames.AutoSize = true;
            this.chkDeleteRoleUsernames.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkDeleteRoleUsernames.Location = new System.Drawing.Point(18, 65);
            this.chkDeleteRoleUsernames.Name = "chkDeleteRoleUsernames";
            this.chkDeleteRoleUsernames.Size = new System.Drawing.Size(151, 17);
            this.chkDeleteRoleUsernames.TabIndex = 1;
            this.chkDeleteRoleUsernames.Text = "(7) Delete Role usernames";
            this.chkDeleteRoleUsernames.UseVisualStyleBackColor = true;
            // 
            // chkDeleteSpamTrapDomains
            // 
            this.chkDeleteSpamTrapDomains.AutoSize = true;
            this.chkDeleteSpamTrapDomains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkDeleteSpamTrapDomains.Location = new System.Drawing.Point(18, 90);
            this.chkDeleteSpamTrapDomains.Name = "chkDeleteSpamTrapDomains";
            this.chkDeleteSpamTrapDomains.Size = new System.Drawing.Size(162, 17);
            this.chkDeleteSpamTrapDomains.TabIndex = 2;
            this.chkDeleteSpamTrapDomains.Text = "(4) Delete Spamtrap domains";
            this.chkDeleteSpamTrapDomains.UseVisualStyleBackColor = true;
            // 
            // chkDeleteSpamTrapAddresses
            // 
            this.chkDeleteSpamTrapAddresses.AutoSize = true;
            this.chkDeleteSpamTrapAddresses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkDeleteSpamTrapAddresses.Location = new System.Drawing.Point(18, 112);
            this.chkDeleteSpamTrapAddresses.Name = "chkDeleteSpamTrapAddresses";
            this.chkDeleteSpamTrapAddresses.Size = new System.Drawing.Size(169, 17);
            this.chkDeleteSpamTrapAddresses.TabIndex = 3;
            this.chkDeleteSpamTrapAddresses.Text = "(5) Delete spamtrap addresses";
            this.chkDeleteSpamTrapAddresses.UseVisualStyleBackColor = true;
            // 
            // chkDeleteFictitiousDomains
            // 
            this.chkDeleteFictitiousDomains.AutoSize = true;
            this.chkDeleteFictitiousDomains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkDeleteFictitiousDomains.Location = new System.Drawing.Point(18, 158);
            this.chkDeleteFictitiousDomains.Name = "chkDeleteFictitiousDomains";
            this.chkDeleteFictitiousDomains.Size = new System.Drawing.Size(190, 17);
            this.chkDeleteFictitiousDomains.TabIndex = 4;
            this.chkDeleteFictitiousDomains.Text = "(3) Delete known fictitious domains";
            this.chkDeleteFictitiousDomains.UseVisualStyleBackColor = true;
            // 
            // chkDeleteWirelessDomains
            // 
            this.chkDeleteWirelessDomains.AutoSize = true;
            this.chkDeleteWirelessDomains.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkDeleteWirelessDomains.Location = new System.Drawing.Point(18, 135);
            this.chkDeleteWirelessDomains.Name = "chkDeleteWirelessDomains";
            this.chkDeleteWirelessDomains.Size = new System.Drawing.Size(157, 17);
            this.chkDeleteWirelessDomains.TabIndex = 5;
            this.chkDeleteWirelessDomains.Text = "(6) Delete Wireless domains";
            this.chkDeleteWirelessDomains.UseVisualStyleBackColor = true;
            // 
            // chkDeleteEmailsWithNoMXgeneral
            // 
            this.chkDeleteEmailsWithNoMXgeneral.AutoSize = true;
            this.chkDeleteEmailsWithNoMXgeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkDeleteEmailsWithNoMXgeneral.Location = new System.Drawing.Point(239, 87);
            this.chkDeleteEmailsWithNoMXgeneral.Name = "chkDeleteEmailsWithNoMXgeneral";
            this.chkDeleteEmailsWithNoMXgeneral.Size = new System.Drawing.Size(329, 17);
            this.chkDeleteEmailsWithNoMXgeneral.TabIndex = 6;
            this.chkDeleteEmailsWithNoMXgeneral.Text = "(11) Delete emails with no MX record for general domains SLOW";
            this.chkDeleteEmailsWithNoMXgeneral.UseVisualStyleBackColor = true;
            // 
            // chkDeleteBadFormatedMajorISP
            // 
            this.chkDeleteBadFormatedMajorISP.AutoSize = true;
            this.chkDeleteBadFormatedMajorISP.ForeColor = System.Drawing.Color.Green;
            this.chkDeleteBadFormatedMajorISP.Location = new System.Drawing.Point(239, 64);
            this.chkDeleteBadFormatedMajorISP.Name = "chkDeleteBadFormatedMajorISP";
            this.chkDeleteBadFormatedMajorISP.Size = new System.Drawing.Size(268, 17);
            this.chkDeleteBadFormatedMajorISP.TabIndex = 7;
            this.chkDeleteBadFormatedMajorISP.Text = "(10) Delete bad formated email of major isp domains";
            this.chkDeleteBadFormatedMajorISP.UseVisualStyleBackColor = true;
            // 
            // chkDeleteBadFormatedEmails
            // 
            this.chkDeleteBadFormatedEmails.AutoSize = true;
            this.chkDeleteBadFormatedEmails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkDeleteBadFormatedEmails.Location = new System.Drawing.Point(18, 42);
            this.chkDeleteBadFormatedEmails.Name = "chkDeleteBadFormatedEmails";
            this.chkDeleteBadFormatedEmails.Size = new System.Drawing.Size(215, 17);
            this.chkDeleteBadFormatedEmails.TabIndex = 8;
            this.chkDeleteBadFormatedEmails.Text = "(9) Delete bad formated email addresses";
            this.chkDeleteBadFormatedEmails.UseVisualStyleBackColor = true;
            // 
            // chkDeleteEmailifMXcantVerifyGeneral
            // 
            this.chkDeleteEmailifMXcantVerifyGeneral.AutoSize = true;
            this.chkDeleteEmailifMXcantVerifyGeneral.Enabled = false;
            this.chkDeleteEmailifMXcantVerifyGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkDeleteEmailifMXcantVerifyGeneral.Location = new System.Drawing.Point(239, 135);
            this.chkDeleteEmailifMXcantVerifyGeneral.Name = "chkDeleteEmailifMXcantVerifyGeneral";
            this.chkDeleteEmailifMXcantVerifyGeneral.Size = new System.Drawing.Size(351, 17);
            this.chkDeleteEmailifMXcantVerifyGeneral.TabIndex = 9;
            this.chkDeleteEmailifMXcantVerifyGeneral.Text = "(13) Delete email if user doesnt exist (general domains) VERY SLOW ";
            this.chkDeleteEmailifMXcantVerifyGeneral.UseVisualStyleBackColor = true;
            // 
            // chkDeleteEmailifMXcantVerifyMajorISP
            // 
            this.chkDeleteEmailifMXcantVerifyMajorISP.AutoSize = true;
            this.chkDeleteEmailifMXcantVerifyMajorISP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkDeleteEmailifMXcantVerifyMajorISP.Location = new System.Drawing.Point(239, 112);
            this.chkDeleteEmailifMXcantVerifyMajorISP.Name = "chkDeleteEmailifMXcantVerifyMajorISP";
            this.chkDeleteEmailifMXcantVerifyMajorISP.Size = new System.Drawing.Size(430, 17);
            this.chkDeleteEmailifMXcantVerifyMajorISP.TabIndex = 10;
            this.chkDeleteEmailifMXcantVerifyMajorISP.Text = "(12) Delete email if user doesnt exist command (Major isps,gmail only right now) " +
    "SLOW";
            this.chkDeleteEmailifMXcantVerifyMajorISP.UseVisualStyleBackColor = true;
            // 
            // chkFixKnownTyposGeneral
            // 
            this.chkFixKnownTyposGeneral.AutoSize = true;
            this.chkFixKnownTyposGeneral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkFixKnownTyposGeneral.Location = new System.Drawing.Point(239, 19);
            this.chkFixKnownTyposGeneral.Name = "chkFixKnownTyposGeneral";
            this.chkFixKnownTyposGeneral.Size = new System.Drawing.Size(182, 17);
            this.chkFixKnownTyposGeneral.TabIndex = 15;
            this.chkFixKnownTyposGeneral.Text = "(2) Fix known typo general emails";
            this.chkFixKnownTyposGeneral.UseVisualStyleBackColor = true;
            // 
            // chkFixTypoSuffix
            // 
            this.chkFixTypoSuffix.AutoSize = true;
            this.chkFixTypoSuffix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.chkFixTypoSuffix.Location = new System.Drawing.Point(239, 42);
            this.chkFixTypoSuffix.Name = "chkFixTypoSuffix";
            this.chkFixTypoSuffix.Size = new System.Drawing.Size(192, 17);
            this.chkFixTypoSuffix.TabIndex = 16;
            this.chkFixTypoSuffix.Text = "(8) Fix known typos suffix in domain";
            this.chkFixTypoSuffix.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.chkFixTypoSuffix);
            this.groupBox2.Controls.Add(this.chkFixKnownTyposGeneral);
            this.groupBox2.Controls.Add(this.chkDeleteEmailifMXcantVerifyMajorISP);
            this.groupBox2.Controls.Add(this.chkDeleteEmailifMXcantVerifyGeneral);
            this.groupBox2.Controls.Add(this.chkDeleteBadFormatedEmails);
            this.groupBox2.Controls.Add(this.chkDeleteBadFormatedMajorISP);
            this.groupBox2.Controls.Add(this.chkDeleteEmailsWithNoMXgeneral);
            this.groupBox2.Controls.Add(this.chkDeleteWirelessDomains);
            this.groupBox2.Controls.Add(this.chkDeleteFictitiousDomains);
            this.groupBox2.Controls.Add(this.chkDeleteSpamTrapAddresses);
            this.groupBox2.Controls.Add(this.chkDeleteSpamTrapDomains);
            this.groupBox2.Controls.Add(this.chkDeleteRoleUsernames);
            this.groupBox2.Controls.Add(this.chkFixTyposMajorISP);
            this.groupBox2.Location = new System.Drawing.Point(9, 324);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 189);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Delete or Fix reasons";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDns);
            this.groupBox3.Location = new System.Drawing.Point(666, 90);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(137, 65);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dns server to use";
            // 
            // txtDns
            // 
            this.txtDns.Location = new System.Drawing.Point(7, 25);
            this.txtDns.Name = "txtDns";
            this.txtDns.Size = new System.Drawing.Size(124, 20);
            this.txtDns.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(500, 522);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 45;
            this.label9.Text = "Per min";
            // 
            // txtPerMin
            // 
            this.txtPerMin.Location = new System.Drawing.Point(548, 519);
            this.txtPerMin.Name = "txtPerMin";
            this.txtPerMin.Size = new System.Drawing.Size(100, 20);
            this.txtPerMin.TabIndex = 46;
            // 
            // chkBoxRestart
            // 
            this.chkBoxRestart.AutoSize = true;
            this.chkBoxRestart.Location = new System.Drawing.Point(706, 212);
            this.chkBoxRestart.Name = "chkBoxRestart";
            this.chkBoxRestart.Size = new System.Drawing.Size(75, 17);
            this.chkBoxRestart.TabIndex = 47;
            this.chkBoxRestart.Text = "Restart list";
            this.chkBoxRestart.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(740, 554);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 20);
            this.label10.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(694, 519);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 50;
            this.label11.Text = "ETA(min)";
            // 
            // txtMin
            // 
            this.txtMin.Location = new System.Drawing.Point(750, 518);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(59, 20);
            this.txtMin.TabIndex = 51;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkMXCheck);
            this.groupBox4.Controls.Add(this.chkMajorIsp);
            this.groupBox4.Controls.Add(this.chkReRun);
            this.groupBox4.Controls.Add(this.chkContinue);
            this.groupBox4.Location = new System.Drawing.Point(487, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(322, 80);
            this.groupBox4.TabIndex = 53;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Speed improvements";
            // 
            // chkMXCheck
            // 
            this.chkMXCheck.AutoSize = true;
            this.chkMXCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chkMXCheck.Location = new System.Drawing.Point(6, 59);
            this.chkMXCheck.Name = "chkMXCheck";
            this.chkMXCheck.Size = new System.Drawing.Size(319, 17);
            this.chkMXCheck.TabIndex = 56;
            this.chkMXCheck.Text = "Run MX Check on only validated records (major ISPs skipped)";
            this.chkMXCheck.UseVisualStyleBackColor = true;
            this.chkMXCheck.CheckedChanged += new System.EventHandler(this.chkMXCheck_CheckedChanged);
            // 
            // chkMajorIsp
            // 
            this.chkMajorIsp.AutoSize = true;
            this.chkMajorIsp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.chkMajorIsp.Location = new System.Drawing.Point(6, 42);
            this.chkMajorIsp.Name = "chkMajorIsp";
            this.chkMajorIsp.Size = new System.Drawing.Size(269, 17);
            this.chkMajorIsp.TabIndex = 55;
            this.chkMajorIsp.Text = "Run MajorISP email exists(gmail.com only right now)";
            this.chkMajorIsp.UseVisualStyleBackColor = true;
            this.chkMajorIsp.CheckedChanged += new System.EventHandler(this.chkMajorIsp_CheckedChanged);
            // 
            // chkReRun
            // 
            this.chkReRun.AutoSize = true;
            this.chkReRun.Location = new System.Drawing.Point(6, 28);
            this.chkReRun.Name = "chkReRun";
            this.chkReRun.Size = new System.Drawing.Size(99, 17);
            this.chkReRun.TabIndex = 54;
            this.chkReRun.Text = "ReRun Invalids";
            this.chkReRun.UseVisualStyleBackColor = true;
            // 
            // chkContinue
            // 
            this.chkContinue.AutoSize = true;
            this.chkContinue.Location = new System.Drawing.Point(6, 14);
            this.chkContinue.Name = "chkContinue";
            this.chkContinue.Size = new System.Drawing.Size(74, 17);
            this.chkContinue.TabIndex = 53;
            this.chkContinue.Text = "Continue?";
            this.chkContinue.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 589);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkBoxRestart);
            this.Controls.Add(this.txtPerMin);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label40);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lbltoDo);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtBoxInputConnectionString);
            this.Name = "frmMain";
            this.Text = "WinEmailVerifier";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.txtBoxInputConnectionString.ResumeLayout(false);
            this.txtBoxInputConnectionString.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox txtBoxInputConnectionString;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.ComboBox txtKeyField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmailFieldFrom;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblReasonIDdesc;
        private System.Windows.Forms.TextBox txtEmailFieldTo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSupressionID;
        private System.Windows.Forms.TextBox txtSupressionID;
        private System.Windows.Forms.Label lblReasonID;
        private System.Windows.Forms.TextBox txtReasonID;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label lblSupressionIDdesc;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox sTestEmail;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label lblEmailFieldTo;
        private System.Windows.Forms.TextBox txtKeyField2;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox lbltoDo;
        private System.Windows.Forms.TextBox lblTotal;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.CheckBox chkFixTyposMajorISP;
        private System.Windows.Forms.CheckBox chkDeleteRoleUsernames;
        private System.Windows.Forms.CheckBox chkDeleteSpamTrapDomains;
        private System.Windows.Forms.CheckBox chkDeleteSpamTrapAddresses;
        private System.Windows.Forms.CheckBox chkDeleteFictitiousDomains;
        private System.Windows.Forms.CheckBox chkDeleteWirelessDomains;
        private System.Windows.Forms.CheckBox chkDeleteEmailsWithNoMXgeneral;
        private System.Windows.Forms.CheckBox chkDeleteBadFormatedMajorISP;
        private System.Windows.Forms.CheckBox chkDeleteBadFormatedEmails;
        private System.Windows.Forms.CheckBox chkDeleteEmailifMXcantVerifyGeneral;
        private System.Windows.Forms.CheckBox chkDeleteEmailifMXcantVerifyMajorISP;
        private System.Windows.Forms.CheckBox chkFixKnownTyposGeneral;
        private System.Windows.Forms.CheckBox chkFixTypoSuffix;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPerMin;
        private System.Windows.Forms.CheckBox chkBoxRestart;
        private System.Windows.Forms.TextBox label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDns;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkMXCheck;
        private System.Windows.Forms.CheckBox chkMajorIsp;
        private System.Windows.Forms.CheckBox chkReRun;
        private System.Windows.Forms.CheckBox chkContinue;
    }
}

