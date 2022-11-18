
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
            this.NoteAppLabel.Font = new System.Drawing.Font("Cuprum", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NoteAppLabel.Location = new System.Drawing.Point(15, 10);
            this.NoteAppLabel.Name = "NoteAppLabel";
            this.NoteAppLabel.Size = new System.Drawing.Size(149, 45);
            this.NoteAppLabel.TabIndex = 0;
            this.NoteAppLabel.Text = "Note App";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Font = new System.Drawing.Font("Cuprum", 14F);
            this.VersionLabel.Location = new System.Drawing.Point(19, 55);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(57, 22);
            this.VersionLabel.TabIndex = 0;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Font = new System.Drawing.Font("Cuprum", 14F);
            this.AuthorLabel.Location = new System.Drawing.Point(19, 80);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(163, 22);
            this.AuthorLabel.TabIndex = 0;
            this.AuthorLabel.Text = "Author: Alex Izbyshev";
            // 
            // CcLabel
            // 
            this.CcLabel.AutoSize = true;
            this.CcLabel.Font = new System.Drawing.Font("Cuprum", 12F);
            this.CcLabel.Location = new System.Drawing.Point(20, 200);
            this.CcLabel.Name = "CcLabel";
            this.CcLabel.Size = new System.Drawing.Size(134, 17);
            this.CcLabel.TabIndex = 0;
            this.CcLabel.Text = "2022 Alex Izbyshev ©";
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Cuprum", 12F);
            this.EmailLabel.Location = new System.Drawing.Point(20, 125);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(129, 17);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "E-mail for Feedback:";
            // 
            // GitLabel
            // 
            this.GitLabel.AutoSize = true;
            this.GitLabel.Font = new System.Drawing.Font("Cuprum", 12F);
            this.GitLabel.Location = new System.Drawing.Point(20, 150);
            this.GitLabel.Name = "GitLabel";
            this.GitLabel.Size = new System.Drawing.Size(49, 17);
            this.GitLabel.TabIndex = 0;
            this.GitLabel.Text = "GitHub:";
            // 
            // EmailLinkLabel
            // 
            this.EmailLinkLabel.AutoSize = true;
            this.EmailLinkLabel.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailLinkLabel.Location = new System.Drawing.Point(155, 125);
            this.EmailLinkLabel.Name = "EmailLinkLabel";
            this.EmailLinkLabel.Size = new System.Drawing.Size(115, 17);
            this.EmailLinkLabel.TabIndex = 1;
            this.EmailLinkLabel.TabStop = true;
            this.EmailLinkLabel.Text = "aizbyshev@mail.ru";
            // 
            // GitLinkLabel
            // 
            this.GitLinkLabel.AutoSize = true;
            this.GitLinkLabel.Font = new System.Drawing.Font("Cuprum", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GitLinkLabel.Location = new System.Drawing.Point(75, 150);
            this.GitLinkLabel.Name = "GitLinkLabel";
            this.GitLinkLabel.Size = new System.Drawing.Size(193, 17);
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