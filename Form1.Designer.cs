namespace uBet
{
    partial class Form1
    {

        Bookie bookie;

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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.admininnertabControl = new System.Windows.Forms.TabControl();
            this.adminusertab = new System.Windows.Forms.TabPage();
            this.AccountGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.userbutton = new System.Windows.Forms.Button();
            this.userbal_admin = new System.Windows.Forms.Label();
            this.useremail_admin = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.adminContest = new System.Windows.Forms.TabPage();
            this.WinnerLabel = new System.Windows.Forms.Label();
            this.admCteamLabel = new System.Windows.Forms.Label();
            this.admCLabel = new System.Windows.Forms.Label();
            this.admWinnerTeamListBox = new System.Windows.Forms.ListBox();
            this.winnerBtn = new System.Windows.Forms.Button();
            this.admincontestlistBox = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.admincstteamlistbox = new System.Windows.Forms.ListBox();
            this.admincontestlabel = new System.Windows.Forms.Label();
            this.admincontesttextBox = new System.Windows.Forms.TextBox();
            this.admincontestbutton = new System.Windows.Forms.Button();
            this.tabPageTeam = new System.Windows.Forms.TabPage();
            this.adminteambtn = new System.Windows.Forms.Button();
            this.adminteamlbl = new System.Windows.Forms.Label();
            this.adminteamtextBox = new System.Windows.Forms.TextBox();
            this.reconcileTab = new System.Windows.Forms.TabPage();
            this.reconlabel2 = new System.Windows.Forms.Label();
            this.payOffcheckBox = new System.Windows.Forms.CheckBox();
            this.reconReconbtn = new System.Windows.Forms.Button();
            this.reconShowbtn = new System.Windows.Forms.Button();
            this.reccontestlistBox = new System.Windows.Forms.ListBox();
            this.reconcileGridView = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.betAmtUpDown = new System.Windows.Forms.NumericUpDown();
            this.userlabel = new System.Windows.Forms.Label();
            this.userlistBox = new System.Windows.Forms.ListBox();
            this.amtlabel = new System.Windows.Forms.Label();
            this.teamlabel = new System.Windows.Forms.Label();
            this.contestlabel = new System.Windows.Forms.Label();
            this.bettypelabel = new System.Windows.Forms.Label();
            this.contestlistBox = new System.Windows.Forms.ListBox();
            this.teamlistBox = new System.Windows.Forms.ListBox();
            this.bettypelistBox = new System.Windows.Forms.ListBox();
            this.betbutton = new System.Windows.Forms.Button();
            this.userDisplay = new System.Windows.Forms.TabControl();
            this.Users = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totegridbtn = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.toteGridView = new System.Windows.Forms.DataGridView();
            this.ToteBoard = new System.Windows.Forms.TabPage();
            this.userBetsbtn = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.gamblerGridView = new System.Windows.Forms.DataGridView();
            this.tabPage2.SuspendLayout();
            this.admininnertabControl.SuspendLayout();
            this.adminusertab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).BeginInit();
            this.adminContest.SuspendLayout();
            this.tabPageTeam.SuspendLayout();
            this.reconcileTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconcileGridView)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmtUpDown)).BeginInit();
            this.userDisplay.SuspendLayout();
            this.Users.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toteGridView)).BeginInit();
            this.ToteBoard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamblerGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.admininnertabControl);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(924, 645);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administration";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // admininnertabControl
            // 
            this.admininnertabControl.Controls.Add(this.adminusertab);
            this.admininnertabControl.Controls.Add(this.adminContest);
            this.admininnertabControl.Controls.Add(this.tabPageTeam);
            this.admininnertabControl.Controls.Add(this.reconcileTab);
            this.admininnertabControl.Location = new System.Drawing.Point(6, 15);
            this.admininnertabControl.Name = "admininnertabControl";
            this.admininnertabControl.SelectedIndex = 0;
            this.admininnertabControl.Size = new System.Drawing.Size(912, 627);
            this.admininnertabControl.TabIndex = 5;
            // 
            // adminusertab
            // 
            this.adminusertab.Controls.Add(this.AccountGridView);
            this.adminusertab.Controls.Add(this.panel2);
            this.adminusertab.Controls.Add(this.textBox2);
            this.adminusertab.Controls.Add(this.userbutton);
            this.adminusertab.Controls.Add(this.userbal_admin);
            this.adminusertab.Controls.Add(this.useremail_admin);
            this.adminusertab.Controls.Add(this.textBox3);
            this.adminusertab.Location = new System.Drawing.Point(4, 22);
            this.adminusertab.Name = "adminusertab";
            this.adminusertab.Padding = new System.Windows.Forms.Padding(3);
            this.adminusertab.Size = new System.Drawing.Size(904, 652);
            this.adminusertab.TabIndex = 0;
            this.adminusertab.Text = "User";
            this.adminusertab.UseVisualStyleBackColor = true;
            // 
            // AccountGridView
            // 
            this.AccountGridView.AllowUserToAddRows = false;
            this.AccountGridView.AllowUserToDeleteRows = false;
            this.AccountGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGridView.Location = new System.Drawing.Point(230, 30);
            this.AccountGridView.Name = "AccountGridView";
            this.AccountGridView.ReadOnly = true;
            this.AccountGridView.Size = new System.Drawing.Size(668, 310);
            this.AccountGridView.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(198, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 484);
            this.panel2.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 30);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // userbutton
            // 
            this.userbutton.Location = new System.Drawing.Point(6, 159);
            this.userbutton.Name = "userbutton";
            this.userbutton.Size = new System.Drawing.Size(75, 23);
            this.userbutton.TabIndex = 2;
            this.userbutton.Text = "submit";
            this.userbutton.UseVisualStyleBackColor = true;
            this.userbutton.Click += new System.EventHandler(this.userbutton_Click);
            // 
            // userbal_admin
            // 
            this.userbal_admin.AutoSize = true;
            this.userbal_admin.Location = new System.Drawing.Point(147, 90);
            this.userbal_admin.Name = "userbal_admin";
            this.userbal_admin.Size = new System.Drawing.Size(45, 13);
            this.userbal_admin.TabIndex = 4;
            this.userbal_admin.Text = "balance";
            // 
            // useremail_admin
            // 
            this.useremail_admin.AutoSize = true;
            this.useremail_admin.Location = new System.Drawing.Point(147, 37);
            this.useremail_admin.Name = "useremail_admin";
            this.useremail_admin.Size = new System.Drawing.Size(31, 13);
            this.useremail_admin.TabIndex = 3;
            this.useremail_admin.Text = "email";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 83);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // adminContest
            // 
            this.adminContest.Controls.Add(this.WinnerLabel);
            this.adminContest.Controls.Add(this.admCteamLabel);
            this.adminContest.Controls.Add(this.admCLabel);
            this.adminContest.Controls.Add(this.admWinnerTeamListBox);
            this.adminContest.Controls.Add(this.winnerBtn);
            this.adminContest.Controls.Add(this.admincontestlistBox);
            this.adminContest.Controls.Add(this.panel1);
            this.adminContest.Controls.Add(this.label1);
            this.adminContest.Controls.Add(this.admincstteamlistbox);
            this.adminContest.Controls.Add(this.admincontestlabel);
            this.adminContest.Controls.Add(this.admincontesttextBox);
            this.adminContest.Controls.Add(this.admincontestbutton);
            this.adminContest.Location = new System.Drawing.Point(4, 22);
            this.adminContest.Name = "adminContest";
            this.adminContest.Padding = new System.Windows.Forms.Padding(3);
            this.adminContest.Size = new System.Drawing.Size(904, 652);
            this.adminContest.TabIndex = 1;
            this.adminContest.Text = "Contest";
            this.adminContest.UseVisualStyleBackColor = true;
            // 
            // WinnerLabel
            // 
            this.WinnerLabel.AutoSize = true;
            this.WinnerLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WinnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WinnerLabel.Location = new System.Drawing.Point(283, 183);
            this.WinnerLabel.Name = "WinnerLabel";
            this.WinnerLabel.Size = new System.Drawing.Size(112, 20);
            this.WinnerLabel.TabIndex = 15;
            this.WinnerLabel.Text = "No Winner Set";
            // 
            // admCteamLabel
            // 
            this.admCteamLabel.AutoSize = true;
            this.admCteamLabel.Location = new System.Drawing.Point(430, 88);
            this.admCteamLabel.Name = "admCteamLabel";
            this.admCteamLabel.Size = new System.Drawing.Size(39, 13);
            this.admCteamLabel.TabIndex = 14;
            this.admCteamLabel.Text = "Teams";
            // 
            // admCLabel
            // 
            this.admCLabel.AutoSize = true;
            this.admCLabel.Location = new System.Drawing.Point(430, 50);
            this.admCLabel.Name = "admCLabel";
            this.admCLabel.Size = new System.Drawing.Size(43, 13);
            this.admCLabel.TabIndex = 13;
            this.admCLabel.Text = "Contest";
            // 
            // admWinnerTeamListBox
            // 
            this.admWinnerTeamListBox.AllowDrop = true;
            this.admWinnerTeamListBox.FormattingEnabled = true;
            this.admWinnerTeamListBox.Location = new System.Drawing.Point(283, 84);
            this.admWinnerTeamListBox.Name = "admWinnerTeamListBox";
            this.admWinnerTeamListBox.Size = new System.Drawing.Size(120, 17);
            this.admWinnerTeamListBox.TabIndex = 12;
            // 
            // winnerBtn
            // 
            this.winnerBtn.Location = new System.Drawing.Point(283, 118);
            this.winnerBtn.Name = "winnerBtn";
            this.winnerBtn.Size = new System.Drawing.Size(75, 23);
            this.winnerBtn.TabIndex = 11;
            this.winnerBtn.Text = "Set Winner";
            this.winnerBtn.UseVisualStyleBackColor = true;
            this.winnerBtn.Click += new System.EventHandler(this.winnerBtn_Click);
            // 
            // admincontestlistBox
            // 
            this.admincontestlistBox.FormattingEnabled = true;
            this.admincontestlistBox.Location = new System.Drawing.Point(283, 46);
            this.admincontestlistBox.Name = "admincontestlistBox";
            this.admincontestlistBox.Size = new System.Drawing.Size(120, 17);
            this.admincontestlistBox.TabIndex = 10;
            this.admincontestlistBox.SelectedIndexChanged += new System.EventHandler(this.admincontestlistBox_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(246, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 310);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Teams";
            // 
            // admincstteamlistbox
            // 
            this.admincstteamlistbox.AllowDrop = true;
            this.admincstteamlistbox.FormattingEnabled = true;
            this.admincstteamlistbox.Location = new System.Drawing.Point(6, 94);
            this.admincstteamlistbox.Name = "admincstteamlistbox";
            this.admincstteamlistbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.admincstteamlistbox.Size = new System.Drawing.Size(120, 212);
            this.admincstteamlistbox.TabIndex = 7;
            // 
            // admincontestlabel
            // 
            this.admincontestlabel.AutoSize = true;
            this.admincontestlabel.Location = new System.Drawing.Point(156, 53);
            this.admincontestlabel.Name = "admincontestlabel";
            this.admincontestlabel.Size = new System.Drawing.Size(60, 13);
            this.admincontestlabel.TabIndex = 2;
            this.admincontestlabel.Text = "Description";
            // 
            // admincontesttextBox
            // 
            this.admincontesttextBox.Location = new System.Drawing.Point(6, 46);
            this.admincontesttextBox.Name = "admincontesttextBox";
            this.admincontesttextBox.Size = new System.Drawing.Size(120, 20);
            this.admincontesttextBox.TabIndex = 1;
            // 
            // admincontestbutton
            // 
            this.admincontestbutton.Location = new System.Drawing.Point(6, 333);
            this.admincontestbutton.Name = "admincontestbutton";
            this.admincontestbutton.Size = new System.Drawing.Size(75, 23);
            this.admincontestbutton.TabIndex = 0;
            this.admincontestbutton.Text = "Add Contest";
            this.admincontestbutton.UseVisualStyleBackColor = true;
            this.admincontestbutton.Click += new System.EventHandler(this.admincontestbutton_Click);
            // 
            // tabPageTeam
            // 
            this.tabPageTeam.Controls.Add(this.adminteambtn);
            this.tabPageTeam.Controls.Add(this.adminteamlbl);
            this.tabPageTeam.Controls.Add(this.adminteamtextBox);
            this.tabPageTeam.Location = new System.Drawing.Point(4, 22);
            this.tabPageTeam.Name = "tabPageTeam";
            this.tabPageTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTeam.Size = new System.Drawing.Size(904, 652);
            this.tabPageTeam.TabIndex = 2;
            this.tabPageTeam.Text = "Team";
            this.tabPageTeam.UseVisualStyleBackColor = true;
            // 
            // adminteambtn
            // 
            this.adminteambtn.Location = new System.Drawing.Point(7, 77);
            this.adminteambtn.Name = "adminteambtn";
            this.adminteambtn.Size = new System.Drawing.Size(75, 23);
            this.adminteambtn.TabIndex = 2;
            this.adminteambtn.Text = "Add team";
            this.adminteambtn.UseVisualStyleBackColor = true;
            this.adminteambtn.Click += new System.EventHandler(this.adminteambtn_Click);
            // 
            // adminteamlbl
            // 
            this.adminteamlbl.AutoSize = true;
            this.adminteamlbl.Location = new System.Drawing.Point(127, 31);
            this.adminteamlbl.Name = "adminteamlbl";
            this.adminteamlbl.Size = new System.Drawing.Size(65, 13);
            this.adminteamlbl.TabIndex = 1;
            this.adminteamlbl.Text = "Team Name";
            // 
            // adminteamtextBox
            // 
            this.adminteamtextBox.Location = new System.Drawing.Point(7, 24);
            this.adminteamtextBox.Name = "adminteamtextBox";
            this.adminteamtextBox.Size = new System.Drawing.Size(100, 20);
            this.adminteamtextBox.TabIndex = 0;
            // 
            // reconcileTab
            // 
            this.reconcileTab.Controls.Add(this.reconlabel2);
            this.reconcileTab.Controls.Add(this.payOffcheckBox);
            this.reconcileTab.Controls.Add(this.reconReconbtn);
            this.reconcileTab.Controls.Add(this.reconShowbtn);
            this.reconcileTab.Controls.Add(this.reccontestlistBox);
            this.reconcileTab.Controls.Add(this.reconcileGridView);
            this.reconcileTab.Location = new System.Drawing.Point(4, 22);
            this.reconcileTab.Name = "reconcileTab";
            this.reconcileTab.Padding = new System.Windows.Forms.Padding(3);
            this.reconcileTab.Size = new System.Drawing.Size(904, 601);
            this.reconcileTab.TabIndex = 3;
            this.reconcileTab.Text = "Reconcile";
            this.reconcileTab.UseVisualStyleBackColor = true;
            // 
            // reconlabel2
            // 
            this.reconlabel2.AutoSize = true;
            this.reconlabel2.Location = new System.Drawing.Point(149, 484);
            this.reconlabel2.Name = "reconlabel2";
            this.reconlabel2.Size = new System.Drawing.Size(81, 13);
            this.reconlabel2.TabIndex = 15;
            this.reconlabel2.Text = "Active Contests";
            // 
            // payOffcheckBox
            // 
            this.payOffcheckBox.AutoSize = true;
            this.payOffcheckBox.Location = new System.Drawing.Point(121, 537);
            this.payOffcheckBox.Name = "payOffcheckBox";
            this.payOffcheckBox.Size = new System.Drawing.Size(85, 17);
            this.payOffcheckBox.TabIndex = 14;
            this.payOffcheckBox.Text = "pay offs only";
            this.payOffcheckBox.UseVisualStyleBackColor = true;
            // 
            // reconReconbtn
            // 
            this.reconReconbtn.BackColor = System.Drawing.Color.DarkRed;
            this.reconReconbtn.Enabled = false;
            this.reconReconbtn.ForeColor = System.Drawing.Color.Yellow;
            this.reconReconbtn.Location = new System.Drawing.Point(823, 484);
            this.reconReconbtn.Name = "reconReconbtn";
            this.reconReconbtn.Size = new System.Drawing.Size(75, 23);
            this.reconReconbtn.TabIndex = 13;
            this.reconReconbtn.Text = "Reconcile Bets";
            this.reconReconbtn.UseVisualStyleBackColor = false;
            this.reconReconbtn.Click += new System.EventHandler(this.reconReconbtn_Click);
            // 
            // reconShowbtn
            // 
            this.reconShowbtn.Location = new System.Drawing.Point(7, 533);
            this.reconShowbtn.Name = "reconShowbtn";
            this.reconShowbtn.Size = new System.Drawing.Size(75, 23);
            this.reconShowbtn.TabIndex = 12;
            this.reconShowbtn.Text = "Show Bets";
            this.reconShowbtn.UseVisualStyleBackColor = true;
            this.reconShowbtn.Click += new System.EventHandler(this.reconShowbtn_Click);
            // 
            // reccontestlistBox
            // 
            this.reccontestlistBox.FormattingEnabled = true;
            this.reccontestlistBox.Location = new System.Drawing.Point(6, 484);
            this.reccontestlistBox.Name = "reccontestlistBox";
            this.reccontestlistBox.Size = new System.Drawing.Size(120, 17);
            this.reccontestlistBox.TabIndex = 11;
            // 
            // reconcileGridView
            // 
            this.reconcileGridView.AllowUserToAddRows = false;
            this.reconcileGridView.AllowUserToDeleteRows = false;
            this.reconcileGridView.AllowUserToOrderColumns = true;
            this.reconcileGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reconcileGridView.Location = new System.Drawing.Point(6, 6);
            this.reconcileGridView.Name = "reconcileGridView";
            this.reconcileGridView.ReadOnly = true;
            this.reconcileGridView.Size = new System.Drawing.Size(892, 459);
            this.reconcileGridView.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.betAmtUpDown);
            this.tabPage1.Controls.Add(this.userlabel);
            this.tabPage1.Controls.Add(this.userlistBox);
            this.tabPage1.Controls.Add(this.amtlabel);
            this.tabPage1.Controls.Add(this.teamlabel);
            this.tabPage1.Controls.Add(this.contestlabel);
            this.tabPage1.Controls.Add(this.bettypelabel);
            this.tabPage1.Controls.Add(this.contestlistBox);
            this.tabPage1.Controls.Add(this.teamlistBox);
            this.tabPage1.Controls.Add(this.bettypelistBox);
            this.tabPage1.Controls.Add(this.betbutton);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(924, 649);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bet Window";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // betAmtUpDown
            // 
            this.betAmtUpDown.Location = new System.Drawing.Point(7, 178);
            this.betAmtUpDown.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.betAmtUpDown.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.betAmtUpDown.Name = "betAmtUpDown";
            this.betAmtUpDown.Size = new System.Drawing.Size(120, 20);
            this.betAmtUpDown.TabIndex = 15;
            this.betAmtUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // userlabel
            // 
            this.userlabel.AutoSize = true;
            this.userlabel.Location = new System.Drawing.Point(156, 140);
            this.userlabel.Name = "userlabel";
            this.userlabel.Size = new System.Drawing.Size(27, 13);
            this.userlabel.TabIndex = 13;
            this.userlabel.Text = "user";
            // 
            // userlistBox
            // 
            this.userlistBox.FormattingEnabled = true;
            this.userlistBox.Items.AddRange(new object[] {
            "1",
            "2"});
            this.userlistBox.Location = new System.Drawing.Point(7, 136);
            this.userlistBox.Name = "userlistBox";
            this.userlistBox.Size = new System.Drawing.Size(120, 17);
            this.userlistBox.TabIndex = 12;
            // 
            // amtlabel
            // 
            this.amtlabel.AutoSize = true;
            this.amtlabel.Location = new System.Drawing.Point(153, 180);
            this.amtlabel.Name = "amtlabel";
            this.amtlabel.Size = new System.Drawing.Size(42, 13);
            this.amtlabel.TabIndex = 11;
            this.amtlabel.Text = "amount";
            // 
            // teamlabel
            // 
            this.teamlabel.AutoSize = true;
            this.teamlabel.Location = new System.Drawing.Point(153, 59);
            this.teamlabel.Name = "teamlabel";
            this.teamlabel.Size = new System.Drawing.Size(35, 13);
            this.teamlabel.TabIndex = 10;
            this.teamlabel.Text = "teams";
            // 
            // contestlabel
            // 
            this.contestlabel.AutoSize = true;
            this.contestlabel.Location = new System.Drawing.Point(153, 95);
            this.contestlabel.Name = "contestlabel";
            this.contestlabel.Size = new System.Drawing.Size(42, 13);
            this.contestlabel.TabIndex = 9;
            this.contestlabel.Text = "contest";
            // 
            // bettypelabel
            // 
            this.bettypelabel.AutoSize = true;
            this.bettypelabel.Location = new System.Drawing.Point(153, 21);
            this.bettypelabel.Name = "bettypelabel";
            this.bettypelabel.Size = new System.Drawing.Size(45, 13);
            this.bettypelabel.TabIndex = 8;
            this.bettypelabel.Text = "bet type";
            // 
            // contestlistBox
            // 
            this.contestlistBox.FormattingEnabled = true;
            this.contestlistBox.Location = new System.Drawing.Point(7, 95);
            this.contestlistBox.Name = "contestlistBox";
            this.contestlistBox.Size = new System.Drawing.Size(120, 17);
            this.contestlistBox.TabIndex = 7;
            this.contestlistBox.SelectedValueChanged += new System.EventHandler(this.contestlistBox_SelectedValueChanged);
            // 
            // teamlistBox
            // 
            this.teamlistBox.AllowDrop = true;
            this.teamlistBox.FormattingEnabled = true;
            this.teamlistBox.Location = new System.Drawing.Point(7, 59);
            this.teamlistBox.Name = "teamlistBox";
            this.teamlistBox.Size = new System.Drawing.Size(120, 17);
            this.teamlistBox.TabIndex = 6;
            // 
            // bettypelistBox
            // 
            this.bettypelistBox.FormattingEnabled = true;
            this.bettypelistBox.Items.AddRange(new object[] {
            1,
            2,
            3});
            this.bettypelistBox.Location = new System.Drawing.Point(7, 21);
            this.bettypelistBox.Name = "bettypelistBox";
            this.bettypelistBox.Size = new System.Drawing.Size(120, 17);
            this.bettypelistBox.TabIndex = 5;
            // 
            // betbutton
            // 
            this.betbutton.Location = new System.Drawing.Point(7, 229);
            this.betbutton.Name = "betbutton";
            this.betbutton.Size = new System.Drawing.Size(75, 23);
            this.betbutton.TabIndex = 0;
            this.betbutton.Text = "place bet";
            this.betbutton.UseVisualStyleBackColor = true;
            // 
            // userDisplay
            // 
            this.userDisplay.Controls.Add(this.tabPage1);
            this.userDisplay.Controls.Add(this.tabPage2);
            this.userDisplay.Controls.Add(this.Users);
            this.userDisplay.Controls.Add(this.ToteBoard);
            this.userDisplay.Location = new System.Drawing.Point(12, 12);
            this.userDisplay.Name = "userDisplay";
            this.userDisplay.SelectedIndex = 0;
            this.userDisplay.Size = new System.Drawing.Size(932, 671);
            this.userDisplay.TabIndex = 0;
            // 
            // Users
            // 
            this.Users.Controls.Add(this.label3);
            this.Users.Controls.Add(this.label2);
            this.Users.Controls.Add(this.totegridbtn);
            this.Users.Controls.Add(this.listBox2);
            this.Users.Controls.Add(this.listBox1);
            this.Users.Controls.Add(this.toteGridView);
            this.Users.Location = new System.Drawing.Point(4, 22);
            this.Users.Name = "Users";
            this.Users.Padding = new System.Windows.Forms.Padding(3);
            this.Users.Size = new System.Drawing.Size(924, 649);
            this.Users.TabIndex = 4;
            this.Users.Text = "ToteBoard";
            this.Users.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 563);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Bet Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 516);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Contest";
            // 
            // totegridbtn
            // 
            this.totegridbtn.Location = new System.Drawing.Point(9, 599);
            this.totegridbtn.Name = "totegridbtn";
            this.totegridbtn.Size = new System.Drawing.Size(60, 23);
            this.totegridbtn.TabIndex = 11;
            this.totegridbtn.Text = "Submit";
            this.totegridbtn.UseVisualStyleBackColor = true;
            this.totegridbtn.Click += new System.EventHandler(this.totegridbtn_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Items.AddRange(new object[] {
            "1",
            "2"});
            this.listBox2.Location = new System.Drawing.Point(84, 563);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 17);
            this.listBox2.TabIndex = 10;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "1",
            "2"});
            this.listBox1.Location = new System.Drawing.Point(84, 516);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 17);
            this.listBox1.TabIndex = 9;
            // 
            // toteGridView
            // 
            this.toteGridView.AllowUserToAddRows = false;
            this.toteGridView.AllowUserToDeleteRows = false;
            this.toteGridView.AllowUserToOrderColumns = true;
            this.toteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.toteGridView.Location = new System.Drawing.Point(6, 6);
            this.toteGridView.Name = "toteGridView";
            this.toteGridView.ReadOnly = true;
            this.toteGridView.Size = new System.Drawing.Size(912, 494);
            this.toteGridView.TabIndex = 0;
            // 
            // ToteBoard
            // 
            this.ToteBoard.BackColor = System.Drawing.Color.Transparent;
            this.ToteBoard.Controls.Add(this.userBetsbtn);
            this.ToteBoard.Controls.Add(this.listBox3);
            this.ToteBoard.Controls.Add(this.gamblerGridView);
            this.ToteBoard.Location = new System.Drawing.Point(4, 22);
            this.ToteBoard.Name = "ToteBoard";
            this.ToteBoard.Padding = new System.Windows.Forms.Padding(3);
            this.ToteBoard.Size = new System.Drawing.Size(924, 649);
            this.ToteBoard.TabIndex = 5;
            this.ToteBoard.Text = "User Active Bets";
            // 
            // userBetsbtn
            // 
            this.userBetsbtn.Location = new System.Drawing.Point(6, 540);
            this.userBetsbtn.Name = "userBetsbtn";
            this.userBetsbtn.Size = new System.Drawing.Size(75, 23);
            this.userBetsbtn.TabIndex = 15;
            this.userBetsbtn.Text = "submit";
            this.userBetsbtn.UseVisualStyleBackColor = true;
            this.userBetsbtn.Click += new System.EventHandler(this.userBetsbtn_Click);
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(6, 505);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(120, 17);
            this.listBox3.TabIndex = 14;
            // 
            // gamblerGridView
            // 
            this.gamblerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gamblerGridView.Location = new System.Drawing.Point(6, 6);
            this.gamblerGridView.Name = "gamblerGridView";
            this.gamblerGridView.Size = new System.Drawing.Size(912, 472);
            this.gamblerGridView.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(948, 695);
            this.Controls.Add(this.userDisplay);
            this.Name = "Form1";
            this.Text = "uBet Professional";
            this.tabPage2.ResumeLayout(false);
            this.admininnertabControl.ResumeLayout(false);
            this.adminusertab.ResumeLayout(false);
            this.adminusertab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGridView)).EndInit();
            this.adminContest.ResumeLayout(false);
            this.adminContest.PerformLayout();
            this.tabPageTeam.ResumeLayout(false);
            this.tabPageTeam.PerformLayout();
            this.reconcileTab.ResumeLayout(false);
            this.reconcileTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reconcileGridView)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betAmtUpDown)).EndInit();
            this.userDisplay.ResumeLayout(false);
            this.Users.ResumeLayout(false);
            this.Users.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toteGridView)).EndInit();
            this.ToteBoard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gamblerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl admininnertabControl;
        private System.Windows.Forms.TabPage adminusertab;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button userbutton;
        private System.Windows.Forms.Label userbal_admin;
        private System.Windows.Forms.Label useremail_admin;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage adminContest;
        private System.Windows.Forms.Label admincontestlabel;
        private System.Windows.Forms.TextBox admincontesttextBox;
        private System.Windows.Forms.Button admincontestbutton;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label userlabel;
        private System.Windows.Forms.ListBox userlistBox;
        private System.Windows.Forms.Label amtlabel;
        private System.Windows.Forms.Label teamlabel;
        private System.Windows.Forms.Label contestlabel;
        private System.Windows.Forms.Label bettypelabel;
        private System.Windows.Forms.ListBox contestlistBox;
        private System.Windows.Forms.ListBox teamlistBox;
        private System.Windows.Forms.ListBox bettypelistBox;
        private System.Windows.Forms.Button betbutton;
        private System.Windows.Forms.TabControl userDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox admincstteamlistbox;
        private System.Windows.Forms.TabPage Users;
        private System.Windows.Forms.DataGridView toteGridView;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button totegridbtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage ToteBoard;
        private System.Windows.Forms.DataGridView gamblerGridView;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Button userBetsbtn;
        private System.Windows.Forms.TabPage tabPageTeam;
        private System.Windows.Forms.Button adminteambtn;
        private System.Windows.Forms.Label adminteamlbl;
        private System.Windows.Forms.TextBox adminteamtextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox admincontestlistBox;
        private System.Windows.Forms.Button winnerBtn;
        private System.Windows.Forms.TabPage reconcileTab;
        private System.Windows.Forms.ListBox reccontestlistBox;
        private System.Windows.Forms.DataGridView reconcileGridView;
        private System.Windows.Forms.Button reconReconbtn;
        private System.Windows.Forms.Button reconShowbtn;
        private System.Windows.Forms.CheckBox payOffcheckBox;
        private System.Windows.Forms.ListBox admWinnerTeamListBox;
        private System.Windows.Forms.Label WinnerLabel;
        private System.Windows.Forms.Label admCteamLabel;
        private System.Windows.Forms.Label admCLabel;
        private System.Windows.Forms.NumericUpDown betAmtUpDown;
        private System.Windows.Forms.Label reconlabel2;
        private System.Windows.Forms.DataGridView AccountGridView;
        private System.Windows.Forms.Panel panel2;



    }
}

