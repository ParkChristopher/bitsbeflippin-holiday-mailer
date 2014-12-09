namespace HolidayMailer
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
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enterUserCtrlAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedContactsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutF1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMainSender = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.editSelectedContactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindow = new System.Windows.Forms.SplitContainer();
            this.buttonPreview = new System.Windows.Forms.Button();
            this.labelPreview = new System.Windows.Forms.Label();
            this.labelCustomMessage = new System.Windows.Forms.Label();
            this.labelTemplate = new System.Windows.Forms.Label();
            this.textBoxCustomMessage = new System.Windows.Forms.TextBox();
            this.comboBoxTemplate = new System.Windows.Forms.ComboBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxSendTo = new System.Windows.Forms.GroupBox();
            this.radioButtonSendPrevious = new System.Windows.Forms.RadioButton();
            this.radioButtonSendSelected = new System.Windows.Forms.RadioButton();
            this.radioButtonSendAll = new System.Windows.Forms.RadioButton();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.labelEmailout2 = new System.Windows.Forms.Label();
            this.labelEmailout = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUsernameout = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.dataGridViewContactList = new System.Windows.Forms.DataGridView();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPreviousSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonEditSelected = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.labelSubject = new System.Windows.Forms.Label();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addContactToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindow)).BeginInit();
            this.mainWindow.Panel1.SuspendLayout();
            this.mainWindow.Panel2.SuspendLayout();
            this.mainWindow.SuspendLayout();
            this.groupBoxSendTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.BackColor = System.Drawing.SystemColors.Control;
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(980, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enterUserCtrlAToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // enterUserCtrlAToolStripMenuItem
            // 
            this.enterUserCtrlAToolStripMenuItem.Name = "enterUserCtrlAToolStripMenuItem";
            this.enterUserCtrlAToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.enterUserCtrlAToolStripMenuItem.Text = "Enter User Ctrl+A";
            this.enterUserCtrlAToolStripMenuItem.Click += new System.EventHandler(this.enterUserCtrlAToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedContactsToolStripMenuItem1,
            this.addContactToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // editSelectedContactsToolStripMenuItem1
            // 
            this.editSelectedContactsToolStripMenuItem1.Name = "editSelectedContactsToolStripMenuItem1";
            this.editSelectedContactsToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.editSelectedContactsToolStripMenuItem1.Text = "Edit Selected Contacts";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutF1ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutF1ToolStripMenuItem
            // 
            this.aboutF1ToolStripMenuItem.Name = "aboutF1ToolStripMenuItem";
            this.aboutF1ToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.aboutF1ToolStripMenuItem.Text = "About F1";
            this.aboutF1ToolStripMenuItem.Click += new System.EventHandler(this.aboutF1ToolStripMenuItem_Click);
            // 
            // menuBarFile
            // 
            this.menuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripMainSender});
            this.menuBarFile.Name = "menuBarFile";
            this.menuBarFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F)));
            this.menuBarFile.Size = new System.Drawing.Size(37, 20);
            this.menuBarFile.Text = "File";
            // 
            // toolstripMainSender
            // 
            this.toolstripMainSender.Name = "toolstripMainSender";
            this.toolstripMainSender.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.toolstripMainSender.Size = new System.Drawing.Size(169, 22);
            this.toolstripMainSender.Text = "Enter User";
            this.toolstripMainSender.Click += new System.EventHandler(this.toolstripMainSender_Click);
            // 
            // menuBarEdit
            // 
            this.menuBarEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSelectedContactsToolStripMenuItem});
            this.menuBarEdit.Name = "menuBarEdit";
            this.menuBarEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.menuBarEdit.Size = new System.Drawing.Size(39, 20);
            this.menuBarEdit.Text = "Edit";
            // 
            // editSelectedContactsToolStripMenuItem
            // 
            this.editSelectedContactsToolStripMenuItem.Name = "editSelectedContactsToolStripMenuItem";
            this.editSelectedContactsToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.editSelectedContactsToolStripMenuItem.Text = "Edit Selected Contacts";
            // 
            // menuBarHelp
            // 
            this.menuBarHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuBarHelp.Name = "menuBarHelp";
            this.menuBarHelp.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.menuBarHelp.Size = new System.Drawing.Size(44, 20);
            this.menuBarHelp.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // mainWindow
            // 
            this.mainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindow.Location = new System.Drawing.Point(0, 24);
            this.mainWindow.Name = "mainWindow";
            // 
            // mainWindow.Panel1
            // 
            this.mainWindow.Panel1.BackgroundImage = global::HolidayMailer.Properties.Resources.snowflakes;
            this.mainWindow.Panel1.Controls.Add(this.textBoxSubject);
            this.mainWindow.Panel1.Controls.Add(this.labelSubject);
            this.mainWindow.Panel1.Controls.Add(this.buttonPreview);
            this.mainWindow.Panel1.Controls.Add(this.labelPreview);
            this.mainWindow.Panel1.Controls.Add(this.labelCustomMessage);
            this.mainWindow.Panel1.Controls.Add(this.labelTemplate);
            this.mainWindow.Panel1.Controls.Add(this.textBoxCustomMessage);
            this.mainWindow.Panel1.Controls.Add(this.comboBoxTemplate);
            this.mainWindow.Panel1.Controls.Add(this.buttonSend);
            this.mainWindow.Panel1.Controls.Add(this.groupBoxSendTo);
            this.mainWindow.Panel1.Controls.Add(this.labelUser);
            this.mainWindow.Panel1.Controls.Add(this.pictureBoxPreview);
            this.mainWindow.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // mainWindow.Panel2
            // 
            this.mainWindow.Panel2.BackgroundImage = global::HolidayMailer.Properties.Resources.snowflakes;
            this.mainWindow.Panel2.Controls.Add(this.labelEmailout2);
            this.mainWindow.Panel2.Controls.Add(this.labelEmailout);
            this.mainWindow.Panel2.Controls.Add(this.labelEmail);
            this.mainWindow.Panel2.Controls.Add(this.labelUsernameout);
            this.mainWindow.Panel2.Controls.Add(this.labelUsername);
            this.mainWindow.Panel2.Controls.Add(this.dataGridViewContactList);
            this.mainWindow.Panel2.Controls.Add(this.buttonEditSelected);
            this.mainWindow.Panel2.Controls.Add(this.buttonDeleteSelected);
            this.mainWindow.Panel2.Controls.Add(this.buttonAddContact);
            this.mainWindow.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.mainWindow.Size = new System.Drawing.Size(980, 634);
            this.mainWindow.SplitterDistance = 229;
            this.mainWindow.TabIndex = 1;
            // 
            // buttonPreview
            // 
            this.buttonPreview.Location = new System.Drawing.Point(118, 599);
            this.buttonPreview.Name = "buttonPreview";
            this.buttonPreview.Size = new System.Drawing.Size(81, 23);
            this.buttonPreview.TabIndex = 11;
            this.buttonPreview.Text = "Preview";
            this.buttonPreview.UseVisualStyleBackColor = true;
            this.buttonPreview.Click += new System.EventHandler(this.buttonPreview_Click_1);
            // 
            // labelPreview
            // 
            this.labelPreview.AutoSize = true;
            this.labelPreview.Location = new System.Drawing.Point(15, 339);
            this.labelPreview.Name = "labelPreview";
            this.labelPreview.Size = new System.Drawing.Size(45, 13);
            this.labelPreview.TabIndex = 10;
            this.labelPreview.Text = "Preview";
            // 
            // labelCustomMessage
            // 
            this.labelCustomMessage.AutoSize = true;
            this.labelCustomMessage.Location = new System.Drawing.Point(15, 234);
            this.labelCustomMessage.Name = "labelCustomMessage";
            this.labelCustomMessage.Size = new System.Drawing.Size(88, 13);
            this.labelCustomMessage.TabIndex = 9;
            this.labelCustomMessage.Text = "Custom Message";
            // 
            // labelTemplate
            // 
            this.labelTemplate.AutoSize = true;
            this.labelTemplate.Location = new System.Drawing.Point(15, 129);
            this.labelTemplate.Name = "labelTemplate";
            this.labelTemplate.Size = new System.Drawing.Size(51, 13);
            this.labelTemplate.TabIndex = 8;
            this.labelTemplate.Text = "Template";
            // 
            // textBoxCustomMessage
            // 
            this.textBoxCustomMessage.Location = new System.Drawing.Point(16, 253);
            this.textBoxCustomMessage.MaxLength = 240;
            this.textBoxCustomMessage.Multiline = true;
            this.textBoxCustomMessage.Name = "textBoxCustomMessage";
            this.textBoxCustomMessage.Size = new System.Drawing.Size(197, 82);
            this.textBoxCustomMessage.TabIndex = 7;
            this.textBoxCustomMessage.Text = "Write a custom body for your email here!";
            // 
            // comboBoxTemplate
            // 
            this.comboBoxTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTemplate.FormattingEnabled = true;
            this.comboBoxTemplate.Items.AddRange(new object[] {
            "RedTemplate.jpg",
            "RedAndBlackTemplate.jpg"});
            this.comboBoxTemplate.Location = new System.Drawing.Point(16, 148);
            this.comboBoxTemplate.Name = "comboBoxTemplate";
            this.comboBoxTemplate.Size = new System.Drawing.Size(138, 21);
            this.comboBoxTemplate.TabIndex = 6;
            this.comboBoxTemplate.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplate_SelectedIndexChanged);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(18, 599);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(81, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "&Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxSendTo
            // 
            this.groupBoxSendTo.Controls.Add(this.radioButtonSendPrevious);
            this.groupBoxSendTo.Controls.Add(this.radioButtonSendSelected);
            this.groupBoxSendTo.Controls.Add(this.radioButtonSendAll);
            this.groupBoxSendTo.Location = new System.Drawing.Point(16, 23);
            this.groupBoxSendTo.Name = "groupBoxSendTo";
            this.groupBoxSendTo.Size = new System.Drawing.Size(125, 96);
            this.groupBoxSendTo.TabIndex = 4;
            this.groupBoxSendTo.TabStop = false;
            this.groupBoxSendTo.Text = "Send to:";
            // 
            // radioButtonSendPrevious
            // 
            this.radioButtonSendPrevious.AutoSize = true;
            this.radioButtonSendPrevious.Location = new System.Drawing.Point(14, 66);
            this.radioButtonSendPrevious.Name = "radioButtonSendPrevious";
            this.radioButtonSendPrevious.Size = new System.Drawing.Size(103, 17);
            this.radioButtonSendPrevious.TabIndex = 2;
            this.radioButtonSendPrevious.TabStop = true;
            this.radioButtonSendPrevious.Text = "Previous Sender";
            this.radioButtonSendPrevious.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendSelected
            // 
            this.radioButtonSendSelected.AutoSize = true;
            this.radioButtonSendSelected.Location = new System.Drawing.Point(14, 42);
            this.radioButtonSendSelected.Name = "radioButtonSendSelected";
            this.radioButtonSendSelected.Size = new System.Drawing.Size(67, 17);
            this.radioButtonSendSelected.TabIndex = 1;
            this.radioButtonSendSelected.TabStop = true;
            this.radioButtonSendSelected.Text = "Selected";
            this.radioButtonSendSelected.UseVisualStyleBackColor = true;
            // 
            // radioButtonSendAll
            // 
            this.radioButtonSendAll.AutoSize = true;
            this.radioButtonSendAll.Location = new System.Drawing.Point(14, 18);
            this.radioButtonSendAll.Name = "radioButtonSendAll";
            this.radioButtonSendAll.Size = new System.Drawing.Size(36, 17);
            this.radioButtonSendAll.TabIndex = 0;
            this.radioButtonSendAll.TabStop = true;
            this.radioButtonSendAll.Text = "All";
            this.radioButtonSendAll.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(13, 7);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(16, 355);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(200, 240);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // labelEmailout2
            // 
            this.labelEmailout2.AutoSize = true;
            this.labelEmailout2.Location = new System.Drawing.Point(514, 596);
            this.labelEmailout2.Name = "labelEmailout2";
            this.labelEmailout2.Size = new System.Drawing.Size(0, 13);
            this.labelEmailout2.TabIndex = 9;
            // 
            // labelEmailout
            // 
            this.labelEmailout.AutoSize = true;
            this.labelEmailout.Location = new System.Drawing.Point(373, 311);
            this.labelEmailout.Name = "labelEmailout";
            this.labelEmailout.Size = new System.Drawing.Size(0, 13);
            this.labelEmailout.TabIndex = 8;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(473, 596);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email:";
            // 
            // labelUsernameout
            // 
            this.labelUsernameout.AutoSize = true;
            this.labelUsernameout.Location = new System.Drawing.Point(320, 599);
            this.labelUsernameout.Name = "labelUsernameout";
            this.labelUsernameout.Size = new System.Drawing.Size(0, 13);
            this.labelUsernameout.TabIndex = 6;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(276, 599);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(38, 13);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Name:";
            // 
            // dataGridViewContactList
            // 
            this.dataGridViewContactList.AllowUserToAddRows = false;
            this.dataGridViewContactList.AllowUserToDeleteRows = false;
            this.dataGridViewContactList.AllowUserToResizeRows = false;
            this.dataGridViewContactList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewContactList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContactList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFirstName,
            this.columnLastName,
            this.columnEmail,
            this.columnPreviousSender});
            this.dataGridViewContactList.Location = new System.Drawing.Point(9, 12);
            this.dataGridViewContactList.Name = "dataGridViewContactList";
            this.dataGridViewContactList.ReadOnly = true;
            this.dataGridViewContactList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContactList.Size = new System.Drawing.Size(677, 581);
            this.dataGridViewContactList.TabIndex = 4;
            // 
            // ColumnFirstName
            // 
            this.ColumnFirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnFirstName.HeaderText = "First Name";
            this.ColumnFirstName.Name = "ColumnFirstName";
            this.ColumnFirstName.ReadOnly = true;
            // 
            // columnLastName
            // 
            this.columnLastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnLastName.HeaderText = "Last Name";
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.ReadOnly = true;
            // 
            // columnEmail
            // 
            this.columnEmail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            // 
            // columnPreviousSender
            // 
            this.columnPreviousSender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnPreviousSender.HeaderText = "Previous";
            this.columnPreviousSender.Name = "columnPreviousSender";
            this.columnPreviousSender.ReadOnly = true;
            // 
            // buttonEditSelected
            // 
            this.buttonEditSelected.Location = new System.Drawing.Point(106, 599);
            this.buttonEditSelected.Name = "buttonEditSelected";
            this.buttonEditSelected.Size = new System.Drawing.Size(82, 23);
            this.buttonEditSelected.TabIndex = 3;
            this.buttonEditSelected.Text = "&Edit Selected";
            this.buttonEditSelected.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(3, 599);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(97, 23);
            this.buttonDeleteSelected.TabIndex = 2;
            this.buttonDeleteSelected.Text = "&Delete Selected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            this.buttonDeleteSelected.Click += new System.EventHandler(this.buttonDeleteSelected_Click);
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(194, 599);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(75, 23);
            this.buttonAddContact.TabIndex = 1;
            this.buttonAddContact.Text = "&Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Location = new System.Drawing.Point(15, 178);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(43, 13);
            this.labelSubject.TabIndex = 12;
            this.labelSubject.Text = "Subject";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(12, 199);
            this.textBoxSubject.MaxLength = 50;
            this.textBoxSubject.Multiline = true;
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(197, 25);
            this.textBoxSubject.TabIndex = 13;
            this.textBoxSubject.Text = "Write a custom subject here!";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // addContactToolStripMenuItem
            // 
            this.addContactToolStripMenuItem.Name = "addContactToolStripMenuItem";
            this.addContactToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.addContactToolStripMenuItem.Text = "Add Contact";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(980, 658);
            this.Controls.Add(this.mainWindow);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.Text = "Holiday Mailer";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.mainWindow.Panel1.ResumeLayout(false);
            this.mainWindow.Panel1.PerformLayout();
            this.mainWindow.Panel2.ResumeLayout(false);
            this.mainWindow.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindow)).EndInit();
            this.mainWindow.ResumeLayout(false);
            this.groupBoxSendTo.ResumeLayout(false);
            this.groupBoxSendTo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContactList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem menuBarFile;
        private System.Windows.Forms.ToolStripMenuItem menuBarEdit;
        private System.Windows.Forms.ToolStripMenuItem menuBarHelp;
        private System.Windows.Forms.SplitContainer mainWindow;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.GroupBox groupBoxSendTo;
        private System.Windows.Forms.RadioButton radioButtonSendPrevious;
        private System.Windows.Forms.RadioButton radioButtonSendSelected;
        private System.Windows.Forms.RadioButton radioButtonSendAll;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Button buttonEditSelected;
        private System.Windows.Forms.Button buttonDeleteSelected;
        private System.Windows.Forms.Button buttonAddContact;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.ToolStripMenuItem toolstripMainSender;
        private System.Windows.Forms.DataGridView dataGridViewContactList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnPreviousSender;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxTemplate;
        private System.Windows.Forms.TextBox textBoxCustomMessage;
        private System.Windows.Forms.Label labelCustomMessage;
        private System.Windows.Forms.Label labelTemplate;
        private System.Windows.Forms.Label labelPreview;
        private System.Windows.Forms.ToolStripMenuItem editSelectedContactsToolStripMenuItem;
        private System.Windows.Forms.Button buttonPreview;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUsernameout;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelEmailout2;
        private System.Windows.Forms.Label labelEmailout;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enterUserCtrlAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSelectedContactsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutF1ToolStripMenuItem;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addContactToolStripMenuItem;

    }
}

