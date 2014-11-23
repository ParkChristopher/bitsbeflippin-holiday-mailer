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
            this.menuBarFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripMainSender = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBarHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.mainWindow = new System.Windows.Forms.SplitContainer();
            this.buttonSend = new System.Windows.Forms.Button();
            this.groupBoxSendTo = new System.Windows.Forms.GroupBox();
            this.radioButtonSendPrevious = new System.Windows.Forms.RadioButton();
            this.radioButtonSendSelected = new System.Windows.Forms.RadioButton();
            this.radioButtonSendAll = new System.Windows.Forms.RadioButton();
            this.buttonRemoveAttachment = new System.Windows.Forms.Button();
            this.buttonAttachFile = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonEditSelected = new System.Windows.Forms.Button();
            this.buttonDeleteSelected = new System.Windows.Forms.Button();
            this.buttonAddContact = new System.Windows.Forms.Button();
            this.dataGridViewContactList = new System.Windows.Forms.DataGridView();
            this.ColumnFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnPreviousSender = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBarFile,
            this.menuBarEdit,
            this.menuBarHelp});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(921, 24);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // menuBarFile
            // 
            this.menuBarFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripMainSender});
            this.menuBarFile.Name = "menuBarFile";
            this.menuBarFile.Size = new System.Drawing.Size(37, 20);
            this.menuBarFile.Text = "File";
            // 
            // toolstripMainSender
            // 
            this.toolstripMainSender.Name = "toolstripMainSender";
            this.toolstripMainSender.Size = new System.Drawing.Size(127, 22);
            this.toolstripMainSender.Text = "Enter User";
            this.toolstripMainSender.Click += new System.EventHandler(this.toolstripMainSender_Click);
            // 
            // menuBarEdit
            // 
            this.menuBarEdit.Name = "menuBarEdit";
            this.menuBarEdit.Size = new System.Drawing.Size(39, 20);
            this.menuBarEdit.Text = "Edit";
            // 
            // menuBarHelp
            // 
            this.menuBarHelp.Name = "menuBarHelp";
            this.menuBarHelp.Size = new System.Drawing.Size(44, 20);
            this.menuBarHelp.Text = "Help";
            // 
            // mainWindow
            // 
            this.mainWindow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindow.Location = new System.Drawing.Point(0, 24);
            this.mainWindow.Name = "mainWindow";
            // 
            // mainWindow.Panel1
            // 
            this.mainWindow.Panel1.Controls.Add(this.buttonSend);
            this.mainWindow.Panel1.Controls.Add(this.groupBoxSendTo);
            this.mainWindow.Panel1.Controls.Add(this.buttonRemoveAttachment);
            this.mainWindow.Panel1.Controls.Add(this.buttonAttachFile);
            this.mainWindow.Panel1.Controls.Add(this.labelUser);
            this.mainWindow.Panel1.Controls.Add(this.pictureBoxPreview);
            this.mainWindow.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // mainWindow.Panel2
            // 
            this.mainWindow.Panel2.Controls.Add(this.dataGridViewContactList);
            this.mainWindow.Panel2.Controls.Add(this.buttonEditSelected);
            this.mainWindow.Panel2.Controls.Add(this.buttonDeleteSelected);
            this.mainWindow.Panel2.Controls.Add(this.buttonAddContact);
            this.mainWindow.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.mainWindow.Size = new System.Drawing.Size(921, 548);
            this.mainWindow.SplitterDistance = 219;
            this.mainWindow.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(16, 144);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(81, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // groupBoxSendTo
            // 
            this.groupBoxSendTo.Controls.Add(this.radioButtonSendPrevious);
            this.groupBoxSendTo.Controls.Add(this.radioButtonSendSelected);
            this.groupBoxSendTo.Controls.Add(this.radioButtonSendAll);
            this.groupBoxSendTo.Location = new System.Drawing.Point(16, 42);
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
            // buttonRemoveAttachment
            // 
            this.buttonRemoveAttachment.Location = new System.Drawing.Point(97, 472);
            this.buttonRemoveAttachment.Name = "buttonRemoveAttachment";
            this.buttonRemoveAttachment.Size = new System.Drawing.Size(116, 23);
            this.buttonRemoveAttachment.TabIndex = 3;
            this.buttonRemoveAttachment.Text = "Remove Attachment";
            this.buttonRemoveAttachment.UseVisualStyleBackColor = true;
            // 
            // buttonAttachFile
            // 
            this.buttonAttachFile.Location = new System.Drawing.Point(16, 472);
            this.buttonAttachFile.Name = "buttonAttachFile";
            this.buttonAttachFile.Size = new System.Drawing.Size(75, 23);
            this.buttonAttachFile.TabIndex = 2;
            this.buttonAttachFile.Text = "Attach File";
            this.buttonAttachFile.UseVisualStyleBackColor = true;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(13, 12);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(29, 13);
            this.labelUser.TabIndex = 1;
            this.labelUser.Text = "User";
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(16, 203);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(197, 263);
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonEditSelected
            // 
            this.buttonEditSelected.Location = new System.Drawing.Point(112, 472);
            this.buttonEditSelected.Name = "buttonEditSelected";
            this.buttonEditSelected.Size = new System.Drawing.Size(82, 23);
            this.buttonEditSelected.TabIndex = 3;
            this.buttonEditSelected.Text = "Edit Selected";
            this.buttonEditSelected.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelected
            // 
            this.buttonDeleteSelected.Location = new System.Drawing.Point(9, 472);
            this.buttonDeleteSelected.Name = "buttonDeleteSelected";
            this.buttonDeleteSelected.Size = new System.Drawing.Size(97, 23);
            this.buttonDeleteSelected.TabIndex = 2;
            this.buttonDeleteSelected.Text = "Delete Selected";
            this.buttonDeleteSelected.UseVisualStyleBackColor = true;
            // 
            // buttonAddContact
            // 
            this.buttonAddContact.Location = new System.Drawing.Point(200, 472);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(75, 23);
            this.buttonAddContact.TabIndex = 1;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
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
            this.dataGridViewContactList.Size = new System.Drawing.Size(677, 454);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(921, 572);
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
        private System.Windows.Forms.Button buttonRemoveAttachment;
        private System.Windows.Forms.Button buttonAttachFile;
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

    }
}

