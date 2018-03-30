namespace SendEmails
{
    partial class frmSendEmail
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
            this.gbSendEmail = new System.Windows.Forms.GroupBox();
            this.txtPortNo = new System.Windows.Forms.TextBox();
            this.lblPortNo = new System.Windows.Forms.Label();
            this.txtSMTPServer = new System.Windows.Forms.TextBox();
            this.lblSMTPServer = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnAttachResume = new System.Windows.Forms.Button();
            this.txtAttachResume = new System.Windows.Forms.TextBox();
            this.lblAttachedResume = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtAttachExcel = new System.Windows.Forms.TextBox();
            this.lblAttachExcel = new System.Windows.Forms.Label();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.gbSendEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSendEmail
            // 
            this.gbSendEmail.Controls.Add(this.txtPortNo);
            this.gbSendEmail.Controls.Add(this.lblPortNo);
            this.gbSendEmail.Controls.Add(this.txtSMTPServer);
            this.gbSendEmail.Controls.Add(this.lblSMTPServer);
            this.gbSendEmail.Controls.Add(this.btnSend);
            this.gbSendEmail.Controls.Add(this.btnAttachResume);
            this.gbSendEmail.Controls.Add(this.txtAttachResume);
            this.gbSendEmail.Controls.Add(this.lblAttachedResume);
            this.gbSendEmail.Controls.Add(this.btnBrowse);
            this.gbSendEmail.Controls.Add(this.txtAttachExcel);
            this.gbSendEmail.Controls.Add(this.lblAttachExcel);
            this.gbSendEmail.Controls.Add(this.txtPwd);
            this.gbSendEmail.Controls.Add(this.lblPwd);
            this.gbSendEmail.Controls.Add(this.txtEmail);
            this.gbSendEmail.Controls.Add(this.lblEmail);
            this.gbSendEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSendEmail.Location = new System.Drawing.Point(0, 0);
            this.gbSendEmail.Name = "gbSendEmail";
            this.gbSendEmail.Size = new System.Drawing.Size(750, 497);
            this.gbSendEmail.TabIndex = 0;
            this.gbSendEmail.TabStop = false;
            this.gbSendEmail.Text = "Send Emails (Gmail)";
            // 
            // txtPortNo
            // 
            this.txtPortNo.Location = new System.Drawing.Point(233, 178);
            this.txtPortNo.Name = "txtPortNo";
            this.txtPortNo.Size = new System.Drawing.Size(275, 27);
            this.txtPortNo.TabIndex = 18;
            this.txtPortNo.Text = "587";
            // 
            // lblPortNo
            // 
            this.lblPortNo.AutoSize = true;
            this.lblPortNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPortNo.Location = new System.Drawing.Point(40, 178);
            this.lblPortNo.Name = "lblPortNo";
            this.lblPortNo.Size = new System.Drawing.Size(60, 18);
            this.lblPortNo.TabIndex = 17;
            this.lblPortNo.Text = "Port No";
            // 
            // txtSMTPServer
            // 
            this.txtSMTPServer.Location = new System.Drawing.Point(233, 130);
            this.txtSMTPServer.Name = "txtSMTPServer";
            this.txtSMTPServer.Size = new System.Drawing.Size(275, 27);
            this.txtSMTPServer.TabIndex = 16;
            this.txtSMTPServer.Text = "smtp.gmail.com";
            // 
            // lblSMTPServer
            // 
            this.lblSMTPServer.AutoSize = true;
            this.lblSMTPServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSMTPServer.Location = new System.Drawing.Point(42, 130);
            this.lblSMTPServer.Name = "lblSMTPServer";
            this.lblSMTPServer.Size = new System.Drawing.Size(97, 18);
            this.lblSMTPServer.TabIndex = 15;
            this.lblSMTPServer.Text = "SMTP Server";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(233, 340);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(77, 27);
            this.btnSend.TabIndex = 14;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnAttachResume
            // 
            this.btnAttachResume.Location = new System.Drawing.Point(533, 286);
            this.btnAttachResume.Name = "btnAttachResume";
            this.btnAttachResume.Size = new System.Drawing.Size(92, 27);
            this.btnAttachResume.TabIndex = 13;
            this.btnAttachResume.Text = "Browse";
            this.btnAttachResume.UseVisualStyleBackColor = true;
            this.btnAttachResume.Click += new System.EventHandler(this.btnAttachResume_Click);
            // 
            // txtAttachResume
            // 
            this.txtAttachResume.Location = new System.Drawing.Point(233, 286);
            this.txtAttachResume.Name = "txtAttachResume";
            this.txtAttachResume.Size = new System.Drawing.Size(275, 27);
            this.txtAttachResume.TabIndex = 12;
            // 
            // lblAttachedResume
            // 
            this.lblAttachedResume.AutoSize = true;
            this.lblAttachedResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachedResume.Location = new System.Drawing.Point(43, 286);
            this.lblAttachedResume.Name = "lblAttachedResume";
            this.lblAttachedResume.Size = new System.Drawing.Size(109, 18);
            this.lblAttachedResume.TabIndex = 11;
            this.lblAttachedResume.Text = "Attach Resume";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(533, 226);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(92, 27);
            this.btnBrowse.TabIndex = 10;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtAttachExcel
            // 
            this.txtAttachExcel.Location = new System.Drawing.Point(233, 226);
            this.txtAttachExcel.Name = "txtAttachExcel";
            this.txtAttachExcel.Size = new System.Drawing.Size(275, 27);
            this.txtAttachExcel.TabIndex = 9;
            // 
            // lblAttachExcel
            // 
            this.lblAttachExcel.AutoSize = true;
            this.lblAttachExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttachExcel.Location = new System.Drawing.Point(43, 226);
            this.lblAttachExcel.Name = "lblAttachExcel";
            this.lblAttachExcel.Size = new System.Drawing.Size(162, 18);
            this.lblAttachExcel.TabIndex = 8;
            this.lblAttachExcel.Text = "Emails ID(Attach Excel)";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(233, 82);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(275, 27);
            this.txtPwd.TabIndex = 7;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.Location = new System.Drawing.Point(43, 82);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(75, 18);
            this.lblPwd.TabIndex = 6;
            this.lblPwd.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(233, 42);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(275, 27);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Text = "programmer.mohan89@gmail.com";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(43, 42);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(63, 18);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email ID";
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "openFileDialog1";
            // 
            // frmSendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 492);
            this.Controls.Add(this.gbSendEmail);
            this.Name = "frmSendEmail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Emails";
            this.gbSendEmail.ResumeLayout(false);
            this.gbSendEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSendEmail;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAttachExcel;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtAttachExcel;
        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAttachResume;
        private System.Windows.Forms.TextBox txtAttachResume;
        private System.Windows.Forms.Label lblAttachedResume;
        private System.Windows.Forms.TextBox txtSMTPServer;
        private System.Windows.Forms.Label lblSMTPServer;
        private System.Windows.Forms.TextBox txtPortNo;
        private System.Windows.Forms.Label lblPortNo;
    }
}

