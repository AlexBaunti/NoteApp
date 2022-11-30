
namespace NoteApp.View
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.NoteAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.CcLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.GitLabel = new System.Windows.Forms.Label();
            this.EmailLinkLabel = new System.Windows.Forms.LinkLabel();
            this.GitLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // NoteAppLabel
            // 
            this.NoteAppLabel.AutoSize = true;
            this.NoteAppLabel.Font = new System.Drawing.Font("Verdana", 24F);
            this.NoteAppLabel.Location = new System.Drawing.Point(15, 10);
            this.NoteAppLabel.Name = "NoteAppLabel";
            this.NoteAppLabel.Size = new System.Drawing.Size(165, 38);
            this.NoteAppLabel.TabIndex = 0;
            this.NoteAppLabel.Text = "Note App";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.VersionLabel.Location = new System.Drawing.Point(20, 60);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(70, 18);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Verdana", 12F);
            this.AuthorLabel.Location = new System.Drawing.Point(20, 85);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(189, 18);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Author: Alex Izbyshev";
            // 
            // CcLabel
            // 
            this.CcLabel.AutoSize = true;
            this.CcLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.CcLabel.Location = new System.Drawing.Point(20, 195);
            this.CcLabel.Name = "CcLabel";
            this.CcLabel.Size = new System.Drawing.Size(166, 17);
            this.CcLabel.TabIndex = 0;
            this.CcLabel.Text = "2022 Alex Izbyshev ©";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.EmailLabel.Location = new System.Drawing.Point(20, 125);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(152, 17);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E-mail for Feedback:";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.GitLabel.Location = new System.Drawing.Point(20, 150);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(62, 17);
            this.GitLabel.TabIndex = 0;
            this.GitLabel.Text = "GitHub:";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.EmailLinkLabel.Location = new System.Drawing.Point(172, 125);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(138, 17);
            this.EmailLinkLabel.TabIndex = 1;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "aizbyshev@mail.ru";
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Font = new System.Drawing.Font("Verdana", 10F);
            this.GitLinkLabel.Location = new System.Drawing.Point(88, 150);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(235, 17);
            this.GitLinkLabel.TabIndex = 1;
            this.GitLinkLabel.TabStop = true;
            this.GitLinkLabel.Text = "github.com/AlexBaunti/NoteApp";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 231);
            this.Controls.Add(this.GitLinkLabel);
            this.Controls.Add(this.EmailLinkLabel);
            this.Controls.Add(this.GitLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.CcLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.NoteAppLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(420, 270);
            this.MinimumSize = new System.Drawing.Size(420, 270);
            this.Name = "AboutForm";
            this.Text = "About";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoteAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label CcLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label GitLabel;
        private System.Windows.Forms.LinkLabel EmailLinkLabel;
        private System.Windows.Forms.LinkLabel GitLinkLabel;
    }
}