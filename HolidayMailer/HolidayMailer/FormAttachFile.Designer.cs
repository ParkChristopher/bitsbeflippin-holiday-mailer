namespace HolidayMailer
{
    partial class FormAttachFile
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
            this.buttonAttach = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBrowseForFile = new System.Windows.Forms.Button();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAttach
            // 
            this.buttonAttach.Location = new System.Drawing.Point(269, 77);
            this.buttonAttach.Name = "buttonAttach";
            this.buttonAttach.Size = new System.Drawing.Size(50, 23);
            this.buttonAttach.TabIndex = 0;
            this.buttonAttach.Text = "Attach";
            this.buttonAttach.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(325, 77);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(50, 23);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseForFile
            // 
            this.buttonBrowseForFile.Location = new System.Drawing.Point(300, 35);
            this.buttonBrowseForFile.Name = "buttonBrowseForFile";
            this.buttonBrowseForFile.Size = new System.Drawing.Size(75, 23);
            this.buttonBrowseForFile.TabIndex = 2;
            this.buttonBrowseForFile.Text = "Browse...";
            this.buttonBrowseForFile.UseVisualStyleBackColor = true;
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 37);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(282, 20);
            this.textBoxFilePath.TabIndex = 3;
            this.textBoxFilePath.Text = "Path";
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(13, 13);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(57, 13);
            this.labelFileName.TabIndex = 4;
            this.labelFileName.Text = "File Name:";
            // 
            // FormAttachFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 108);
            this.Controls.Add(this.labelFileName);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.buttonBrowseForFile);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAttach);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "FormAttachFile";
            this.Text = "FormAttachFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAttach;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBrowseForFile;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label labelFileName;
    }
}