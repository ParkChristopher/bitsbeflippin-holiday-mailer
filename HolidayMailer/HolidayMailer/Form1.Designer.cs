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
            this.listViewContacts = new System.Windows.Forms.ListView();
            this.columnFirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnLastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnPrevious = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindow)).BeginInit();
            this.mainWindow.Panel1.SuspendLayout();
            this.mainWindow.Panel2.SuspendLayout();
            this.mainWindow.SuspendLayout();
            this.groupBoxSendTo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
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
            this.menuBarFile.Name = "menuBarFile";
            this.menuBarFile.Size = new System.Drawing.Size(37, 20);
            this.menuBarFile.Text = "File";
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
            this.mainWindow.Panel2.Controls.Add(this.buttonEditSelected);
            this.mainWindow.Panel2.Controls.Add(this.buttonDeleteSelected);
            this.mainWindow.Panel2.Controls.Add(this.buttonAddContact);
            this.mainWindow.Panel2.Controls.Add(this.listViewContacts);
            this.mainWindow.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.mainWindow.Size = new System.Drawing.Size(921, 548);
            this.mainWindow.SplitterDistance = 444;
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
            this.buttonRemoveAttachment.Location = new System.Drawing.Point(228, 439);
            this.buttonRemoveAttachment.Name = "buttonRemoveAttachment";
            this.buttonRemoveAttachment.Size = new System.Drawing.Size(116, 23);
            this.buttonRemoveAttachment.TabIndex = 3;
            this.buttonRemoveAttachment.Text = "Remove Attachment";
            this.buttonRemoveAttachment.UseVisualStyleBackColor = true;
            // 
            // buttonAttachFile
            // 
            this.buttonAttachFile.Location = new System.Drawing.Point(147, 439);
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
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPreview.Location = new System.Drawing.Point(147, 24);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(287, 409);
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
            this.buttonAddContact.Location = new System.Drawing.Point(386, 472);
            this.buttonAddContact.Name = "buttonAddContact";
            this.buttonAddContact.Size = new System.Drawing.Size(75, 23);
            this.buttonAddContact.TabIndex = 1;
            this.buttonAddContact.Text = "Add Contact";
            this.buttonAddContact.UseVisualStyleBackColor = true;
            this.buttonAddContact.Click += new System.EventHandler(this.buttonAddContact_Click);
            // 
            // listViewContacts
            // 
            this.listViewContacts.BackColor = System.Drawing.SystemColors.ControlLight;
            this.listViewContacts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnFirstName,
            this.columnLastName,
            this.columnEmail,
            this.columnPrevious});
            this.listViewContacts.FullRowSelect = true;
            this.listViewContacts.Location = new System.Drawing.Point(9, 24);
            this.listViewContacts.Name = "listViewContacts";
            this.listViewContacts.Size = new System.Drawing.Size(450, 440);
            this.listViewContacts.TabIndex = 0;
            this.listViewContacts.UseCompatibleStateImageBehavior = false;
            this.listViewContacts.View = System.Windows.Forms.View.Details;
            // 
            // columnFirstName
            // 
            this.columnFirstName.Text = "First Name";
            this.columnFirstName.Width = 78;
            // 
            // columnLastName
            // 
            this.columnLastName.Text = "Last Name";
            this.columnLastName.Width = 87;
            // 
            // columnEmail
            // 
            this.columnEmail.Text = "Email";
            this.columnEmail.Width = 181;
            // 
            // columnPrevious
            // 
            this.columnPrevious.Text = "Previous Email Recieved";
            this.columnPrevious.Width = 99;
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
        private System.Windows.Forms.ListView listViewContacts;
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
        private System.Windows.Forms.ColumnHeader columnFirstName;
        private System.Windows.Forms.ColumnHeader columnLastName;
        private System.Windows.Forms.ColumnHeader columnEmail;
        private System.Windows.Forms.ColumnHeader columnPrevious;

    }
}

