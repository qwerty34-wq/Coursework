namespace TestServer
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.groupsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignesTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTestsOfGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DGV_ShowAllGroups = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_AddGroup = new System.Windows.Forms.Button();
            this.textBox_AddGroup_Name = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.DGV_AddGroup = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button_UpdateGroup = new System.Windows.Forms.Button();
            this.textBox_UpdateGroup_NewName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.DGV_UpdateGroup = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button_AddUserToGroup = new System.Windows.Forms.Button();
            this.DGV_AddUserToGroup_AllStudents = new System.Windows.Forms.DataGridView();
            this.DGV_AddUserToGroup_NewGroup = new System.Windows.Forms.DataGridView();
            this.comboBox_AddUserToGroup = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button_ShowUsersInGroup_RemoveStudent = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox_ShowUsersInGroup = new System.Windows.Forms.ComboBox();
            this.DGV_ShowUsersInGroup = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.DGV_ShowUsers = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_AddUser = new System.Windows.Forms.Button();
            this.checkBox_IsAdmin = new System.Windows.Forms.CheckBox();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.textBox_Login = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.DGV_AddUsers = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Update_User = new System.Windows.Forms.Button();
            this.checkBox_IsAdmin_Upd = new System.Windows.Forms.CheckBox();
            this.textBox_ConfirmPassword_Upd = new System.Windows.Forms.TextBox();
            this.textBox_Password_Upd = new System.Windows.Forms.TextBox();
            this.textBox_Login_Upd = new System.Windows.Forms.TextBox();
            this.textBox_LastName_Upd = new System.Windows.Forms.TextBox();
            this.textBox_FirstName_Upd = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.DGV_UpdateUsers = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage9 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button_LoadTest_CancelTest = new System.Windows.Forms.Button();
            this.button_LoadTest_SaveTest = new System.Windows.Forms.Button();
            this.numericUpDown_LoadTest_Minute = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_LoadTest_Hour = new System.Windows.Forms.NumericUpDown();
            this.textBox_LoadTest_NumOfQuestions = new System.Windows.Forms.TextBox();
            this.textBox_LoadTest_NameOfTest = new System.Windows.Forms.TextBox();
            this.textBox_LoadTest_Author = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.button_LoadTest_File = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage10 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.DGV_ShowAllTests = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage11 = new System.Windows.Forms.TabPage();
            this.button_AsignesTest_AddTest = new System.Windows.Forms.Button();
            this.DGV_AsignesTest_AllTests = new System.Windows.Forms.DataGridView();
            this.DGV_AsignesTest_TestsForGroup = new System.Windows.Forms.DataGridView();
            this.comboBox_AsignesTest_Groups = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage12 = new System.Windows.Forms.TabPage();
            this.button_ShowTestsOfGroup_RemoveTest = new System.Windows.Forms.Button();
            this.DGV_ShowTestsOfGroup = new System.Windows.Forms.DataGridView();
            this.comboBox_ShowTestsOfGroup = new System.Windows.Forms.ComboBox();
            this.label33 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabPage13 = new System.Windows.Forms.TabPage();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.DGV_Results = new System.Windows.Forms.DataGridView();
            this.label34 = new System.Windows.Forms.Label();
            this.button_Results = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowAllGroups)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddGroup)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UpdateGroup)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddUserToGroup_AllStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddUserToGroup_NewGroup)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowUsersInGroup)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowUsers)).BeginInit();
            this.tabPage7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddUsers)).BeginInit();
            this.tabPage8.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UpdateUsers)).BeginInit();
            this.tabPage9.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LoadTest_Minute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LoadTest_Hour)).BeginInit();
            this.tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowAllTests)).BeginInit();
            this.tabPage11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AsignesTest_AllTests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AsignesTest_TestsForGroup)).BeginInit();
            this.tabPage12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowTestsOfGroup)).BeginInit();
            this.tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.groupsToolStripMenuItem,
            this.usersToolStripMenuItem,
            this.testsToolStripMenuItem,
            this.serverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(63, 467);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // groupsToolStripMenuItem
            // 
            this.groupsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem1,
            this.addToolStripMenuItem1,
            this.updateToolStripMenuItem1,
            this.addUserToolStripMenuItem,
            this.showUsersToolStripMenuItem});
            this.groupsToolStripMenuItem.Name = "groupsToolStripMenuItem";
            this.groupsToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.groupsToolStripMenuItem.Text = "Groups";
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.showToolStripMenuItem1.Text = "Show";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.ShowToolStripMenuItem1_Click);
            // 
            // addToolStripMenuItem1
            // 
            this.addToolStripMenuItem1.Name = "addToolStripMenuItem1";
            this.addToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.addToolStripMenuItem1.Text = "Add";
            this.addToolStripMenuItem1.Click += new System.EventHandler(this.AddToolStripMenuItem1_Click);
            // 
            // updateToolStripMenuItem1
            // 
            this.updateToolStripMenuItem1.Name = "updateToolStripMenuItem1";
            this.updateToolStripMenuItem1.Size = new System.Drawing.Size(134, 22);
            this.updateToolStripMenuItem1.Text = "Update";
            this.updateToolStripMenuItem1.Click += new System.EventHandler(this.UpdateToolStripMenuItem1_Click);
            // 
            // addUserToolStripMenuItem
            // 
            this.addUserToolStripMenuItem.Name = "addUserToolStripMenuItem";
            this.addUserToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.addUserToolStripMenuItem.Text = "Add user";
            this.addUserToolStripMenuItem.Click += new System.EventHandler(this.AddUserToolStripMenuItem_Click);
            // 
            // showUsersToolStripMenuItem
            // 
            this.showUsersToolStripMenuItem.Name = "showUsersToolStripMenuItem";
            this.showUsersToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.showUsersToolStripMenuItem.Text = "Show Users";
            this.showUsersToolStripMenuItem.Click += new System.EventHandler(this.ShowUsersToolStripMenuItem_Click);
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.usersToolStripMenuItem.Text = "Users";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.AddToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // testsToolStripMenuItem
            // 
            this.testsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTestToolStripMenuItem,
            this.showAllToolStripMenuItem,
            this.asignesTestToolStripMenuItem,
            this.showTestsOfGroupToolStripMenuItem});
            this.testsToolStripMenuItem.Name = "testsToolStripMenuItem";
            this.testsToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.testsToolStripMenuItem.Text = "Tests";
            // 
            // loadTestToolStripMenuItem
            // 
            this.loadTestToolStripMenuItem.Name = "loadTestToolStripMenuItem";
            this.loadTestToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.loadTestToolStripMenuItem.Text = "Load Test";
            this.loadTestToolStripMenuItem.Click += new System.EventHandler(this.LoadTestToolStripMenuItem_Click);
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showAllToolStripMenuItem.Text = "Show all";
            this.showAllToolStripMenuItem.Click += new System.EventHandler(this.ShowAllToolStripMenuItem_Click);
            // 
            // asignesTestToolStripMenuItem
            // 
            this.asignesTestToolStripMenuItem.Name = "asignesTestToolStripMenuItem";
            this.asignesTestToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.asignesTestToolStripMenuItem.Text = "Asignes Test";
            this.asignesTestToolStripMenuItem.Click += new System.EventHandler(this.AsignesTestToolStripMenuItem_Click);
            // 
            // showTestsOfGroupToolStripMenuItem
            // 
            this.showTestsOfGroupToolStripMenuItem.Name = "showTestsOfGroupToolStripMenuItem";
            this.showTestsOfGroupToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.showTestsOfGroupToolStripMenuItem.Text = "Show tests of group";
            this.showTestsOfGroupToolStripMenuItem.Click += new System.EventHandler(this.ShowTestsOfGroupToolStripMenuItem_Click);
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(50, 19);
            this.serverToolStripMenuItem.Text = "Results";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.ServerToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage9);
            this.tabControl1.Controls.Add(this.tabPage10);
            this.tabControl1.Controls.Add(this.tabPage11);
            this.tabControl1.Controls.Add(this.tabPage12);
            this.tabControl1.Controls.Add(this.tabPage13);
            this.tabControl1.Location = new System.Drawing.Point(20, 0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(768, 469);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGV_ShowAllGroups);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(42, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(721, 461);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Show";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DGV_ShowAllGroups
            // 
            this.DGV_ShowAllGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowAllGroups.Location = new System.Drawing.Point(10, 28);
            this.DGV_ShowAllGroups.Name = "DGV_ShowAllGroups";
            this.DGV_ShowAllGroups.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowAllGroups.Size = new System.Drawing.Size(703, 425);
            this.DGV_ShowAllGroups.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Show all Groups";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.DGV_AddGroup);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(42, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(721, 461);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Add";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_AddGroup);
            this.groupBox3.Controls.Add(this.textBox_AddGroup_Name);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Location = new System.Drawing.Point(432, 38);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(281, 203);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Group";
            // 
            // button_AddGroup
            // 
            this.button_AddGroup.Enabled = false;
            this.button_AddGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddGroup.Location = new System.Drawing.Point(10, 117);
            this.button_AddGroup.Name = "button_AddGroup";
            this.button_AddGroup.Size = new System.Drawing.Size(256, 62);
            this.button_AddGroup.TabIndex = 2;
            this.button_AddGroup.Text = "Add Group";
            this.button_AddGroup.UseVisualStyleBackColor = true;
            this.button_AddGroup.Click += new System.EventHandler(this.Button_AddGroup_Click);
            // 
            // textBox_AddGroup_Name
            // 
            this.textBox_AddGroup_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_AddGroup_Name.Location = new System.Drawing.Point(10, 60);
            this.textBox_AddGroup_Name.Name = "textBox_AddGroup_Name";
            this.textBox_AddGroup_Name.Size = new System.Drawing.Size(256, 22);
            this.textBox_AddGroup_Name.TabIndex = 1;
            this.textBox_AddGroup_Name.TextChanged += new System.EventHandler(this.TextBox_AddGroup_Name_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label23.Location = new System.Drawing.Point(7, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(91, 16);
            this.label23.TabIndex = 0;
            this.label23.Text = "Group Name: ";
            // 
            // DGV_AddGroup
            // 
            this.DGV_AddGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddGroup.Location = new System.Drawing.Point(7, 38);
            this.DGV_AddGroup.Name = "DGV_AddGroup";
            this.DGV_AddGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AddGroup.Size = new System.Drawing.Size(419, 417);
            this.DGV_AddGroup.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(6, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add Group";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.DGV_UpdateGroup);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(42, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(721, 461);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button_UpdateGroup);
            this.groupBox4.Controls.Add(this.textBox_UpdateGroup_NewName);
            this.groupBox4.Controls.Add(this.label24);
            this.groupBox4.Location = new System.Drawing.Point(445, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(268, 203);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Update Group";
            // 
            // button_UpdateGroup
            // 
            this.button_UpdateGroup.Enabled = false;
            this.button_UpdateGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_UpdateGroup.Location = new System.Drawing.Point(10, 117);
            this.button_UpdateGroup.Name = "button_UpdateGroup";
            this.button_UpdateGroup.Size = new System.Drawing.Size(246, 62);
            this.button_UpdateGroup.TabIndex = 2;
            this.button_UpdateGroup.Text = "Update Group";
            this.button_UpdateGroup.UseVisualStyleBackColor = true;
            this.button_UpdateGroup.Click += new System.EventHandler(this.Button_UpdateGroup_Click);
            // 
            // textBox_UpdateGroup_NewName
            // 
            this.textBox_UpdateGroup_NewName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_UpdateGroup_NewName.Location = new System.Drawing.Point(10, 60);
            this.textBox_UpdateGroup_NewName.Name = "textBox_UpdateGroup_NewName";
            this.textBox_UpdateGroup_NewName.Size = new System.Drawing.Size(246, 22);
            this.textBox_UpdateGroup_NewName.TabIndex = 1;
            this.textBox_UpdateGroup_NewName.TextChanged += new System.EventHandler(this.TextBox_UpdateGroup_NewName_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label24.Location = new System.Drawing.Point(7, 41);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 16);
            this.label24.TabIndex = 0;
            this.label24.Text = "Group New Name: ";
            // 
            // DGV_UpdateGroup
            // 
            this.DGV_UpdateGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_UpdateGroup.Location = new System.Drawing.Point(7, 28);
            this.DGV_UpdateGroup.Name = "DGV_UpdateGroup";
            this.DGV_UpdateGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_UpdateGroup.Size = new System.Drawing.Size(432, 425);
            this.DGV_UpdateGroup.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Update Group";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button_AddUserToGroup);
            this.tabPage4.Controls.Add(this.DGV_AddUserToGroup_AllStudents);
            this.tabPage4.Controls.Add(this.DGV_AddUserToGroup_NewGroup);
            this.tabPage4.Controls.Add(this.comboBox_AddUserToGroup);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Location = new System.Drawing.Point(42, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(722, 461);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Add user to Group";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // button_AddUserToGroup
            // 
            this.button_AddUserToGroup.Location = new System.Drawing.Point(7, 420);
            this.button_AddUserToGroup.Name = "button_AddUserToGroup";
            this.button_AddUserToGroup.Size = new System.Drawing.Size(706, 37);
            this.button_AddUserToGroup.TabIndex = 8;
            this.button_AddUserToGroup.Text = "Add User to Group";
            this.button_AddUserToGroup.UseVisualStyleBackColor = true;
            this.button_AddUserToGroup.Click += new System.EventHandler(this.Button_AddUserToGroup_Click);
            // 
            // DGV_AddUserToGroup_AllStudents
            // 
            this.DGV_AddUserToGroup_AllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddUserToGroup_AllStudents.Location = new System.Drawing.Point(7, 244);
            this.DGV_AddUserToGroup_AllStudents.Name = "DGV_AddUserToGroup_AllStudents";
            this.DGV_AddUserToGroup_AllStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AddUserToGroup_AllStudents.Size = new System.Drawing.Size(706, 170);
            this.DGV_AddUserToGroup_AllStudents.TabIndex = 7;
            // 
            // DGV_AddUserToGroup_NewGroup
            // 
            this.DGV_AddUserToGroup_NewGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddUserToGroup_NewGroup.Location = new System.Drawing.Point(7, 68);
            this.DGV_AddUserToGroup_NewGroup.Name = "DGV_AddUserToGroup_NewGroup";
            this.DGV_AddUserToGroup_NewGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AddUserToGroup_NewGroup.Size = new System.Drawing.Size(706, 170);
            this.DGV_AddUserToGroup_NewGroup.TabIndex = 6;
            // 
            // comboBox_AddUserToGroup
            // 
            this.comboBox_AddUserToGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AddUserToGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_AddUserToGroup.FormattingEnabled = true;
            this.comboBox_AddUserToGroup.Location = new System.Drawing.Point(7, 38);
            this.comboBox_AddUserToGroup.Name = "comboBox_AddUserToGroup";
            this.comboBox_AddUserToGroup.Size = new System.Drawing.Size(279, 24);
            this.comboBox_AddUserToGroup.TabIndex = 5;
            this.comboBox_AddUserToGroup.SelectedIndexChanged += new System.EventHandler(this.ComboBox_AddUserToGroup_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Add User to Group";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button_ShowUsersInGroup_RemoveStudent);
            this.tabPage5.Controls.Add(this.label25);
            this.tabPage5.Controls.Add(this.comboBox_ShowUsersInGroup);
            this.tabPage5.Controls.Add(this.DGV_ShowUsersInGroup);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Location = new System.Drawing.Point(42, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(721, 461);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Show Users";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button_ShowUsersInGroup_RemoveStudent
            // 
            this.button_ShowUsersInGroup_RemoveStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ShowUsersInGroup_RemoveStudent.Location = new System.Drawing.Point(7, 415);
            this.button_ShowUsersInGroup_RemoveStudent.Name = "button_ShowUsersInGroup_RemoveStudent";
            this.button_ShowUsersInGroup_RemoveStudent.Size = new System.Drawing.Size(706, 38);
            this.button_ShowUsersInGroup_RemoveStudent.TabIndex = 8;
            this.button_ShowUsersInGroup_RemoveStudent.Text = "Remove Student";
            this.button_ShowUsersInGroup_RemoveStudent.UseVisualStyleBackColor = true;
            this.button_ShowUsersInGroup_RemoveStudent.Click += new System.EventHandler(this.Button_ShowUsersInGroup_RemoveStudent_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label25.Location = new System.Drawing.Point(320, 38);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(58, 16);
            this.label25.TabIndex = 7;
            this.label25.Text = "Groups: ";
            // 
            // comboBox_ShowUsersInGroup
            // 
            this.comboBox_ShowUsersInGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ShowUsersInGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ShowUsersInGroup.FormattingEnabled = true;
            this.comboBox_ShowUsersInGroup.Location = new System.Drawing.Point(384, 35);
            this.comboBox_ShowUsersInGroup.Name = "comboBox_ShowUsersInGroup";
            this.comboBox_ShowUsersInGroup.Size = new System.Drawing.Size(329, 24);
            this.comboBox_ShowUsersInGroup.TabIndex = 6;
            this.comboBox_ShowUsersInGroup.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ShowUsersInGroup_SelectedIndexChanged);
            // 
            // DGV_ShowUsersInGroup
            // 
            this.DGV_ShowUsersInGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowUsersInGroup.Location = new System.Drawing.Point(7, 65);
            this.DGV_ShowUsersInGroup.Name = "DGV_ShowUsersInGroup";
            this.DGV_ShowUsersInGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowUsersInGroup.Size = new System.Drawing.Size(706, 344);
            this.DGV_ShowUsersInGroup.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Show Users in Group";
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.DGV_ShowUsers);
            this.tabPage6.Controls.Add(this.label6);
            this.tabPage6.Location = new System.Drawing.Point(42, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(721, 461);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Show";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // DGV_ShowUsers
            // 
            this.DGV_ShowUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowUsers.Location = new System.Drawing.Point(7, 28);
            this.DGV_ShowUsers.Name = "DGV_ShowUsers";
            this.DGV_ShowUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowUsers.Size = new System.Drawing.Size(706, 425);
            this.DGV_ShowUsers.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Show Users";
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox1);
            this.tabPage7.Controls.Add(this.DGV_AddUsers);
            this.tabPage7.Controls.Add(this.label7);
            this.tabPage7.Location = new System.Drawing.Point(42, 4);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(721, 461);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Add";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_AddUser);
            this.groupBox1.Controls.Add(this.checkBox_IsAdmin);
            this.groupBox1.Controls.Add(this.textBox_ConfirmPassword);
            this.groupBox1.Controls.Add(this.textBox_Password);
            this.groupBox1.Controls.Add(this.textBox_Login);
            this.groupBox1.Controls.Add(this.textBox_LastName);
            this.groupBox1.Controls.Add(this.textBox_FirstName);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(451, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(262, 416);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sign Up";
            // 
            // button_AddUser
            // 
            this.button_AddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AddUser.Location = new System.Drawing.Point(9, 358);
            this.button_AddUser.Name = "button_AddUser";
            this.button_AddUser.Size = new System.Drawing.Size(246, 52);
            this.button_AddUser.TabIndex = 11;
            this.button_AddUser.Text = "Add";
            this.button_AddUser.UseVisualStyleBackColor = true;
            this.button_AddUser.Click += new System.EventHandler(this.Button_AddUser_Click);
            // 
            // checkBox_IsAdmin
            // 
            this.checkBox_IsAdmin.AutoSize = true;
            this.checkBox_IsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_IsAdmin.Location = new System.Drawing.Point(12, 315);
            this.checkBox_IsAdmin.Name = "checkBox_IsAdmin";
            this.checkBox_IsAdmin.Size = new System.Drawing.Size(65, 20);
            this.checkBox_IsAdmin.TabIndex = 10;
            this.checkBox_IsAdmin.Text = "Admin";
            this.checkBox_IsAdmin.UseVisualStyleBackColor = true;
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(10, 268);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.PasswordChar = '*';
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(246, 22);
            this.textBox_ConfirmPassword.TabIndex = 9;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password.Location = new System.Drawing.Point(9, 214);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.PasswordChar = '*';
            this.textBox_Password.Size = new System.Drawing.Size(246, 22);
            this.textBox_Password.TabIndex = 8;
            // 
            // textBox_Login
            // 
            this.textBox_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login.Location = new System.Drawing.Point(9, 160);
            this.textBox_Login.Name = "textBox_Login";
            this.textBox_Login.Size = new System.Drawing.Size(246, 22);
            this.textBox_Login.TabIndex = 7;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LastName.Location = new System.Drawing.Point(10, 104);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(246, 22);
            this.textBox_LastName.TabIndex = 6;
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FirstName.Location = new System.Drawing.Point(10, 49);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(246, 22);
            this.textBox_FirstName.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(7, 252);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 16);
            this.label17.TabIndex = 4;
            this.label17.Text = "Confirm password: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(9, 198);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 16);
            this.label16.TabIndex = 3;
            this.label16.Text = "Password: ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(6, 144);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(47, 16);
            this.label15.TabIndex = 2;
            this.label15.Text = "Login: ";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label14.Location = new System.Drawing.Point(6, 88);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "Last Name: ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.Location = new System.Drawing.Point(7, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 16);
            this.label13.TabIndex = 0;
            this.label13.Text = "First Name: ";
            // 
            // DGV_AddUsers
            // 
            this.DGV_AddUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AddUsers.Location = new System.Drawing.Point(7, 37);
            this.DGV_AddUsers.Name = "DGV_AddUsers";
            this.DGV_AddUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AddUsers.Size = new System.Drawing.Size(437, 416);
            this.DGV_AddUsers.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(3, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Add Users";
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox2);
            this.tabPage8.Controls.Add(this.DGV_UpdateUsers);
            this.tabPage8.Controls.Add(this.label8);
            this.tabPage8.Location = new System.Drawing.Point(42, 4);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(721, 461);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "Update";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_Update_User);
            this.groupBox2.Controls.Add(this.checkBox_IsAdmin_Upd);
            this.groupBox2.Controls.Add(this.textBox_ConfirmPassword_Upd);
            this.groupBox2.Controls.Add(this.textBox_Password_Upd);
            this.groupBox2.Controls.Add(this.textBox_Login_Upd);
            this.groupBox2.Controls.Add(this.textBox_LastName_Upd);
            this.groupBox2.Controls.Add(this.textBox_FirstName_Upd);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label22);
            this.groupBox2.Location = new System.Drawing.Point(455, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(262, 425);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update";
            // 
            // button_Update_User
            // 
            this.button_Update_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Update_User.Location = new System.Drawing.Point(9, 358);
            this.button_Update_User.Name = "button_Update_User";
            this.button_Update_User.Size = new System.Drawing.Size(246, 52);
            this.button_Update_User.TabIndex = 11;
            this.button_Update_User.Text = "Update";
            this.button_Update_User.UseVisualStyleBackColor = true;
            this.button_Update_User.Click += new System.EventHandler(this.Button_Update_User_Click);
            // 
            // checkBox_IsAdmin_Upd
            // 
            this.checkBox_IsAdmin_Upd.AutoSize = true;
            this.checkBox_IsAdmin_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox_IsAdmin_Upd.Location = new System.Drawing.Point(12, 315);
            this.checkBox_IsAdmin_Upd.Name = "checkBox_IsAdmin_Upd";
            this.checkBox_IsAdmin_Upd.Size = new System.Drawing.Size(65, 20);
            this.checkBox_IsAdmin_Upd.TabIndex = 10;
            this.checkBox_IsAdmin_Upd.Text = "Admin";
            this.checkBox_IsAdmin_Upd.UseVisualStyleBackColor = true;
            // 
            // textBox_ConfirmPassword_Upd
            // 
            this.textBox_ConfirmPassword_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_ConfirmPassword_Upd.Location = new System.Drawing.Point(10, 268);
            this.textBox_ConfirmPassword_Upd.Name = "textBox_ConfirmPassword_Upd";
            this.textBox_ConfirmPassword_Upd.PasswordChar = '*';
            this.textBox_ConfirmPassword_Upd.Size = new System.Drawing.Size(246, 22);
            this.textBox_ConfirmPassword_Upd.TabIndex = 9;
            // 
            // textBox_Password_Upd
            // 
            this.textBox_Password_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Password_Upd.Location = new System.Drawing.Point(9, 214);
            this.textBox_Password_Upd.Name = "textBox_Password_Upd";
            this.textBox_Password_Upd.PasswordChar = '*';
            this.textBox_Password_Upd.Size = new System.Drawing.Size(246, 22);
            this.textBox_Password_Upd.TabIndex = 8;
            // 
            // textBox_Login_Upd
            // 
            this.textBox_Login_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_Login_Upd.Location = new System.Drawing.Point(9, 160);
            this.textBox_Login_Upd.Name = "textBox_Login_Upd";
            this.textBox_Login_Upd.Size = new System.Drawing.Size(246, 22);
            this.textBox_Login_Upd.TabIndex = 7;
            // 
            // textBox_LastName_Upd
            // 
            this.textBox_LastName_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LastName_Upd.Location = new System.Drawing.Point(10, 104);
            this.textBox_LastName_Upd.Name = "textBox_LastName_Upd";
            this.textBox_LastName_Upd.Size = new System.Drawing.Size(246, 22);
            this.textBox_LastName_Upd.TabIndex = 6;
            // 
            // textBox_FirstName_Upd
            // 
            this.textBox_FirstName_Upd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_FirstName_Upd.Location = new System.Drawing.Point(10, 49);
            this.textBox_FirstName_Upd.Name = "textBox_FirstName_Upd";
            this.textBox_FirstName_Upd.Size = new System.Drawing.Size(246, 22);
            this.textBox_FirstName_Upd.TabIndex = 5;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(7, 252);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(121, 16);
            this.label18.TabIndex = 4;
            this.label18.Text = "Confirm password: ";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(9, 198);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 16);
            this.label19.TabIndex = 3;
            this.label19.Text = "Password: ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label20.Location = new System.Drawing.Point(6, 144);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 16);
            this.label20.TabIndex = 2;
            this.label20.Text = "Login: ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label21.Location = new System.Drawing.Point(6, 88);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(79, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "Last Name: ";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label22.Location = new System.Drawing.Point(7, 33);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 16);
            this.label22.TabIndex = 0;
            this.label22.Text = "First Name: ";
            // 
            // DGV_UpdateUsers
            // 
            this.DGV_UpdateUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_UpdateUsers.Location = new System.Drawing.Point(7, 28);
            this.DGV_UpdateUsers.Name = "DGV_UpdateUsers";
            this.DGV_UpdateUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_UpdateUsers.Size = new System.Drawing.Size(442, 430);
            this.DGV_UpdateUsers.TabIndex = 6;
            this.DGV_UpdateUsers.SelectionChanged += new System.EventHandler(this.DGV_UpdateUsers_SelectionChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(3, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Update Users";
            // 
            // tabPage9
            // 
            this.tabPage9.Controls.Add(this.groupBox5);
            this.tabPage9.Controls.Add(this.button_LoadTest_File);
            this.tabPage9.Controls.Add(this.label9);
            this.tabPage9.Location = new System.Drawing.Point(42, 4);
            this.tabPage9.Name = "tabPage9";
            this.tabPage9.Size = new System.Drawing.Size(721, 461);
            this.tabPage9.TabIndex = 8;
            this.tabPage9.Text = "Load Test";
            this.tabPage9.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_LoadTest_CancelTest);
            this.groupBox5.Controls.Add(this.button_LoadTest_SaveTest);
            this.groupBox5.Controls.Add(this.numericUpDown_LoadTest_Minute);
            this.groupBox5.Controls.Add(this.numericUpDown_LoadTest_Hour);
            this.groupBox5.Controls.Add(this.textBox_LoadTest_NumOfQuestions);
            this.groupBox5.Controls.Add(this.textBox_LoadTest_NameOfTest);
            this.groupBox5.Controls.Add(this.textBox_LoadTest_Author);
            this.groupBox5.Controls.Add(this.label31);
            this.groupBox5.Controls.Add(this.label30);
            this.groupBox5.Controls.Add(this.label29);
            this.groupBox5.Controls.Add(this.label28);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Location = new System.Drawing.Point(256, 41);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(434, 374);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Info";
            // 
            // button_LoadTest_CancelTest
            // 
            this.button_LoadTest_CancelTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LoadTest_CancelTest.Location = new System.Drawing.Point(258, 320);
            this.button_LoadTest_CancelTest.Name = "button_LoadTest_CancelTest";
            this.button_LoadTest_CancelTest.Size = new System.Drawing.Size(159, 38);
            this.button_LoadTest_CancelTest.TabIndex = 13;
            this.button_LoadTest_CancelTest.Text = "Cancel";
            this.button_LoadTest_CancelTest.UseVisualStyleBackColor = true;
            this.button_LoadTest_CancelTest.Click += new System.EventHandler(this.Button_LoadTest_CancelTest_Click);
            // 
            // button_LoadTest_SaveTest
            // 
            this.button_LoadTest_SaveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LoadTest_SaveTest.Location = new System.Drawing.Point(19, 320);
            this.button_LoadTest_SaveTest.Name = "button_LoadTest_SaveTest";
            this.button_LoadTest_SaveTest.Size = new System.Drawing.Size(159, 38);
            this.button_LoadTest_SaveTest.TabIndex = 12;
            this.button_LoadTest_SaveTest.Text = "Save";
            this.button_LoadTest_SaveTest.UseVisualStyleBackColor = true;
            this.button_LoadTest_SaveTest.Click += new System.EventHandler(this.Button_LoadTest_SaveTest_Click);
            // 
            // numericUpDown_LoadTest_Minute
            // 
            this.numericUpDown_LoadTest_Minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_LoadTest_Minute.Location = new System.Drawing.Point(281, 262);
            this.numericUpDown_LoadTest_Minute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.numericUpDown_LoadTest_Minute.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_LoadTest_Minute.Name = "numericUpDown_LoadTest_Minute";
            this.numericUpDown_LoadTest_Minute.Size = new System.Drawing.Size(136, 22);
            this.numericUpDown_LoadTest_Minute.TabIndex = 11;
            this.numericUpDown_LoadTest_Minute.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numericUpDown_LoadTest_Hour
            // 
            this.numericUpDown_LoadTest_Hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown_LoadTest_Hour.Location = new System.Drawing.Point(58, 262);
            this.numericUpDown_LoadTest_Hour.Maximum = new decimal(new int[] {
            48,
            0,
            0,
            0});
            this.numericUpDown_LoadTest_Hour.Name = "numericUpDown_LoadTest_Hour";
            this.numericUpDown_LoadTest_Hour.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown_LoadTest_Hour.TabIndex = 10;
            // 
            // textBox_LoadTest_NumOfQuestions
            // 
            this.textBox_LoadTest_NumOfQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LoadTest_NumOfQuestions.Location = new System.Drawing.Point(152, 145);
            this.textBox_LoadTest_NumOfQuestions.Name = "textBox_LoadTest_NumOfQuestions";
            this.textBox_LoadTest_NumOfQuestions.ReadOnly = true;
            this.textBox_LoadTest_NumOfQuestions.Size = new System.Drawing.Size(265, 22);
            this.textBox_LoadTest_NumOfQuestions.TabIndex = 8;
            // 
            // textBox_LoadTest_NameOfTest
            // 
            this.textBox_LoadTest_NameOfTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LoadTest_NameOfTest.Location = new System.Drawing.Point(152, 100);
            this.textBox_LoadTest_NameOfTest.Name = "textBox_LoadTest_NameOfTest";
            this.textBox_LoadTest_NameOfTest.ReadOnly = true;
            this.textBox_LoadTest_NameOfTest.Size = new System.Drawing.Size(265, 22);
            this.textBox_LoadTest_NameOfTest.TabIndex = 7;
            // 
            // textBox_LoadTest_Author
            // 
            this.textBox_LoadTest_Author.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_LoadTest_Author.Location = new System.Drawing.Point(152, 57);
            this.textBox_LoadTest_Author.Name = "textBox_LoadTest_Author";
            this.textBox_LoadTest_Author.ReadOnly = true;
            this.textBox_LoadTest_Author.Size = new System.Drawing.Size(265, 22);
            this.textBox_LoadTest_Author.TabIndex = 6;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label31.Location = new System.Drawing.Point(230, 264);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(53, 16);
            this.label31.TabIndex = 5;
            this.label31.Text = "Minute: ";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label30.Location = new System.Drawing.Point(16, 264);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(43, 16);
            this.label30.TabIndex = 4;
            this.label30.Text = "Hour: ";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label29.Location = new System.Drawing.Point(15, 221);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(47, 20);
            this.label29.TabIndex = 3;
            this.label29.Text = "Time";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label28.Location = new System.Drawing.Point(16, 145);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(117, 16);
            this.label28.TabIndex = 2;
            this.label28.Text = "Num of questions: ";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label27.Location = new System.Drawing.Point(16, 100);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(95, 16);
            this.label27.TabIndex = 1;
            this.label27.Text = "Name of Test: ";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label26.Location = new System.Drawing.Point(16, 57);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 16);
            this.label26.TabIndex = 0;
            this.label26.Text = "Author: ";
            // 
            // button_LoadTest_File
            // 
            this.button_LoadTest_File.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_LoadTest_File.Location = new System.Drawing.Point(7, 41);
            this.button_LoadTest_File.Name = "button_LoadTest_File";
            this.button_LoadTest_File.Size = new System.Drawing.Size(162, 38);
            this.button_LoadTest_File.TabIndex = 6;
            this.button_LoadTest_File.Text = "File";
            this.button_LoadTest_File.UseVisualStyleBackColor = true;
            this.button_LoadTest_File.Click += new System.EventHandler(this.Button_LoadTest_File_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(3, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Load Test";
            // 
            // tabPage10
            // 
            this.tabPage10.Controls.Add(this.button1);
            this.tabPage10.Controls.Add(this.DGV_ShowAllTests);
            this.tabPage10.Controls.Add(this.label10);
            this.tabPage10.Location = new System.Drawing.Point(42, 4);
            this.tabPage10.Name = "tabPage10";
            this.tabPage10.Size = new System.Drawing.Size(721, 461);
            this.tabPage10.TabIndex = 9;
            this.tabPage10.Text = "Show all";
            this.tabPage10.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(7, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(708, 55);
            this.button1.TabIndex = 7;
            this.button1.Text = "Remove Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // DGV_ShowAllTests
            // 
            this.DGV_ShowAllTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowAllTests.Location = new System.Drawing.Point(7, 40);
            this.DGV_ShowAllTests.Name = "DGV_ShowAllTests";
            this.DGV_ShowAllTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowAllTests.Size = new System.Drawing.Size(708, 357);
            this.DGV_ShowAllTests.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Show all Tests";
            // 
            // tabPage11
            // 
            this.tabPage11.Controls.Add(this.button_AsignesTest_AddTest);
            this.tabPage11.Controls.Add(this.DGV_AsignesTest_AllTests);
            this.tabPage11.Controls.Add(this.DGV_AsignesTest_TestsForGroup);
            this.tabPage11.Controls.Add(this.comboBox_AsignesTest_Groups);
            this.tabPage11.Controls.Add(this.label32);
            this.tabPage11.Controls.Add(this.label11);
            this.tabPage11.Location = new System.Drawing.Point(42, 4);
            this.tabPage11.Name = "tabPage11";
            this.tabPage11.Size = new System.Drawing.Size(721, 461);
            this.tabPage11.TabIndex = 10;
            this.tabPage11.Text = "Assign Test";
            this.tabPage11.UseVisualStyleBackColor = true;
            // 
            // button_AsignesTest_AddTest
            // 
            this.button_AsignesTest_AddTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_AsignesTest_AddTest.Location = new System.Drawing.Point(7, 408);
            this.button_AsignesTest_AddTest.Name = "button_AsignesTest_AddTest";
            this.button_AsignesTest_AddTest.Size = new System.Drawing.Size(706, 48);
            this.button_AsignesTest_AddTest.TabIndex = 10;
            this.button_AsignesTest_AddTest.Text = "Add Test";
            this.button_AsignesTest_AddTest.UseVisualStyleBackColor = true;
            this.button_AsignesTest_AddTest.Click += new System.EventHandler(this.Button_AsignesTest_AddTest_Click);
            // 
            // DGV_AsignesTest_AllTests
            // 
            this.DGV_AsignesTest_AllTests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AsignesTest_AllTests.Location = new System.Drawing.Point(7, 241);
            this.DGV_AsignesTest_AllTests.Name = "DGV_AsignesTest_AllTests";
            this.DGV_AsignesTest_AllTests.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AsignesTest_AllTests.Size = new System.Drawing.Size(706, 163);
            this.DGV_AsignesTest_AllTests.TabIndex = 9;
            // 
            // DGV_AsignesTest_TestsForGroup
            // 
            this.DGV_AsignesTest_TestsForGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AsignesTest_TestsForGroup.Location = new System.Drawing.Point(7, 71);
            this.DGV_AsignesTest_TestsForGroup.Name = "DGV_AsignesTest_TestsForGroup";
            this.DGV_AsignesTest_TestsForGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_AsignesTest_TestsForGroup.Size = new System.Drawing.Size(706, 164);
            this.DGV_AsignesTest_TestsForGroup.TabIndex = 8;
            // 
            // comboBox_AsignesTest_Groups
            // 
            this.comboBox_AsignesTest_Groups.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_AsignesTest_Groups.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_AsignesTest_Groups.FormattingEnabled = true;
            this.comboBox_AsignesTest_Groups.Location = new System.Drawing.Point(467, 40);
            this.comboBox_AsignesTest_Groups.Name = "comboBox_AsignesTest_Groups";
            this.comboBox_AsignesTest_Groups.Size = new System.Drawing.Size(246, 24);
            this.comboBox_AsignesTest_Groups.TabIndex = 7;
            this.comboBox_AsignesTest_Groups.SelectedIndexChanged += new System.EventHandler(this.ComboBox_AsignesTest_Groups_SelectedIndexChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label32.Location = new System.Drawing.Point(396, 43);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(51, 16);
            this.label32.TabIndex = 6;
            this.label32.Text = "Group: ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(3, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 20);
            this.label11.TabIndex = 5;
            this.label11.Text = "Assign Test";
            // 
            // tabPage12
            // 
            this.tabPage12.Controls.Add(this.button_ShowTestsOfGroup_RemoveTest);
            this.tabPage12.Controls.Add(this.DGV_ShowTestsOfGroup);
            this.tabPage12.Controls.Add(this.comboBox_ShowTestsOfGroup);
            this.tabPage12.Controls.Add(this.label33);
            this.tabPage12.Controls.Add(this.label12);
            this.tabPage12.Location = new System.Drawing.Point(42, 4);
            this.tabPage12.Name = "tabPage12";
            this.tabPage12.Size = new System.Drawing.Size(721, 461);
            this.tabPage12.TabIndex = 11;
            this.tabPage12.Text = "Show tests of group";
            this.tabPage12.UseVisualStyleBackColor = true;
            // 
            // button_ShowTestsOfGroup_RemoveTest
            // 
            this.button_ShowTestsOfGroup_RemoveTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_ShowTestsOfGroup_RemoveTest.Location = new System.Drawing.Point(7, 405);
            this.button_ShowTestsOfGroup_RemoveTest.Name = "button_ShowTestsOfGroup_RemoveTest";
            this.button_ShowTestsOfGroup_RemoveTest.Size = new System.Drawing.Size(706, 48);
            this.button_ShowTestsOfGroup_RemoveTest.TabIndex = 12;
            this.button_ShowTestsOfGroup_RemoveTest.Text = "Remove Test";
            this.button_ShowTestsOfGroup_RemoveTest.UseVisualStyleBackColor = true;
            this.button_ShowTestsOfGroup_RemoveTest.Click += new System.EventHandler(this.Button_ShowTestsOfGroup_RemoveTest_Click);
            // 
            // DGV_ShowTestsOfGroup
            // 
            this.DGV_ShowTestsOfGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ShowTestsOfGroup.Location = new System.Drawing.Point(7, 73);
            this.DGV_ShowTestsOfGroup.Name = "DGV_ShowTestsOfGroup";
            this.DGV_ShowTestsOfGroup.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_ShowTestsOfGroup.Size = new System.Drawing.Size(706, 326);
            this.DGV_ShowTestsOfGroup.TabIndex = 11;
            // 
            // comboBox_ShowTestsOfGroup
            // 
            this.comboBox_ShowTestsOfGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_ShowTestsOfGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox_ShowTestsOfGroup.FormattingEnabled = true;
            this.comboBox_ShowTestsOfGroup.Location = new System.Drawing.Point(467, 42);
            this.comboBox_ShowTestsOfGroup.Name = "comboBox_ShowTestsOfGroup";
            this.comboBox_ShowTestsOfGroup.Size = new System.Drawing.Size(246, 24);
            this.comboBox_ShowTestsOfGroup.TabIndex = 10;
            this.comboBox_ShowTestsOfGroup.SelectedIndexChanged += new System.EventHandler(this.ComboBox_ShowTestsOfGroup_SelectedIndexChanged);
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label33.Location = new System.Drawing.Point(396, 45);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(51, 16);
            this.label33.TabIndex = 9;
            this.label33.Text = "Group: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(3, 5);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(178, 20);
            this.label12.TabIndex = 5;
            this.label12.Text = "Show Tests of Group";
            // 
            // tabPage13
            // 
            this.tabPage13.Controls.Add(this.button_Results);
            this.tabPage13.Controls.Add(this.label34);
            this.tabPage13.Controls.Add(this.DGV_Results);
            this.tabPage13.Location = new System.Drawing.Point(42, 4);
            this.tabPage13.Name = "tabPage13";
            this.tabPage13.Size = new System.Drawing.Size(721, 461);
            this.tabPage13.TabIndex = 12;
            this.tabPage13.Text = "Results";
            this.tabPage13.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // DGV_Results
            // 
            this.DGV_Results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Results.Location = new System.Drawing.Point(3, 39);
            this.DGV_Results.Name = "DGV_Results";
            this.DGV_Results.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Results.Size = new System.Drawing.Size(715, 366);
            this.DGV_Results.TabIndex = 0;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label34.Location = new System.Drawing.Point(5, 9);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(63, 20);
            this.label34.TabIndex = 1;
            this.label34.Text = "Results";
            // 
            // button_Results
            // 
            this.button_Results.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Results.Location = new System.Drawing.Point(0, 411);
            this.button_Results.Name = "button_Results";
            this.button_Results.Size = new System.Drawing.Size(718, 46);
            this.button_Results.TabIndex = 2;
            this.button_Results.Text = "Refresh";
            this.button_Results.UseVisualStyleBackColor = true;
            this.button_Results.Click += new System.EventHandler(this.Button_Results_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 467);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowAllGroups)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddGroup)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UpdateGroup)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddUserToGroup_AllStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddUserToGroup_NewGroup)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowUsersInGroup)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowUsers)).EndInit();
            this.tabPage7.ResumeLayout(false);
            this.tabPage7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AddUsers)).EndInit();
            this.tabPage8.ResumeLayout(false);
            this.tabPage8.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UpdateUsers)).EndInit();
            this.tabPage9.ResumeLayout(false);
            this.tabPage9.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LoadTest_Minute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_LoadTest_Hour)).EndInit();
            this.tabPage10.ResumeLayout(false);
            this.tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowAllTests)).EndInit();
            this.tabPage11.ResumeLayout(false);
            this.tabPage11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AsignesTest_AllTests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AsignesTest_TestsForGroup)).EndInit();
            this.tabPage12.ResumeLayout(false);
            this.tabPage12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ShowTestsOfGroup)).EndInit();
            this.tabPage13.ResumeLayout(false);
            this.tabPage13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Results)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem groupsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem addUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showUsersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignesTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTestsOfGroupToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView DGV_ShowUsers;
        private System.Windows.Forms.DataGridView DGV_AddUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.TextBox textBox_Login;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox_IsAdmin;
        private System.Windows.Forms.Button button_AddUser;
        private System.Windows.Forms.DataGridView DGV_UpdateUsers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Update_User;
        private System.Windows.Forms.CheckBox checkBox_IsAdmin_Upd;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword_Upd;
        private System.Windows.Forms.TextBox textBox_Password_Upd;
        private System.Windows.Forms.TextBox textBox_Login_Upd;
        private System.Windows.Forms.TextBox textBox_LastName_Upd;
        private System.Windows.Forms.TextBox textBox_FirstName_Upd;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.DataGridView DGV_ShowAllGroups;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button_AddGroup;
        private System.Windows.Forms.TextBox textBox_AddGroup_Name;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridView DGV_AddGroup;
        private System.Windows.Forms.DataGridView DGV_UpdateGroup;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button_UpdateGroup;
        private System.Windows.Forms.TextBox textBox_UpdateGroup_NewName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button button_AddUserToGroup;
        private System.Windows.Forms.DataGridView DGV_AddUserToGroup_AllStudents;
        private System.Windows.Forms.DataGridView DGV_AddUserToGroup_NewGroup;
        private System.Windows.Forms.ComboBox comboBox_AddUserToGroup;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox comboBox_ShowUsersInGroup;
        private System.Windows.Forms.DataGridView DGV_ShowUsersInGroup;
        private System.Windows.Forms.Button button_ShowUsersInGroup_RemoveStudent;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numericUpDown_LoadTest_Minute;
        private System.Windows.Forms.NumericUpDown numericUpDown_LoadTest_Hour;
        private System.Windows.Forms.TextBox textBox_LoadTest_NumOfQuestions;
        private System.Windows.Forms.TextBox textBox_LoadTest_NameOfTest;
        private System.Windows.Forms.TextBox textBox_LoadTest_Author;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button button_LoadTest_File;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_LoadTest_CancelTest;
        private System.Windows.Forms.Button button_LoadTest_SaveTest;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGV_ShowAllTests;
        private System.Windows.Forms.DataGridView DGV_AsignesTest_AllTests;
        private System.Windows.Forms.DataGridView DGV_AsignesTest_TestsForGroup;
        private System.Windows.Forms.ComboBox comboBox_AsignesTest_Groups;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button_AsignesTest_AddTest;
        private System.Windows.Forms.Button button_ShowTestsOfGroup_RemoveTest;
        private System.Windows.Forms.DataGridView DGV_ShowTestsOfGroup;
        private System.Windows.Forms.ComboBox comboBox_ShowTestsOfGroup;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TabPage tabPage13;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.DataGridView DGV_Results;
        private System.Windows.Forms.Button button_Results;
    }
}

