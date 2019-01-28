namespace ContactAppUI
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
            this.ContactsAppLabel = new System.Windows.Forms.Label();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.AuthorLabel = new System.Windows.Forms.Label();
            this.emailFeedbackLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.githubLabel = new System.Windows.Forms.Label();
            this.githubAdressLabel = new System.Windows.Forms.Label();
            this.tmLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ContactsAppLabel
            // 
            this.ContactsAppLabel.AutoSize = true;
            this.ContactsAppLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ContactsAppLabel.ForeColor = System.Drawing.Color.Black;
            this.ContactsAppLabel.Location = new System.Drawing.Point(12, 23);
            this.ContactsAppLabel.Name = "ContactsAppLabel";
            this.ContactsAppLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ContactsAppLabel.Size = new System.Drawing.Size(135, 25);
            this.ContactsAppLabel.TabIndex = 0;
            this.ContactsAppLabel.Text = "ContactsApp";
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(18, 48);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(43, 13);
            this.VersionLabel.TabIndex = 1;
            this.VersionLabel.Text = "v. 1.0.0";
            // 
            // AuthorLabel
            // 
            this.AuthorLabel.AutoSize = true;
            this.AuthorLabel.Location = new System.Drawing.Point(18, 86);
            this.AuthorLabel.Name = "AuthorLabel";
            this.AuthorLabel.Size = new System.Drawing.Size(117, 13);
            this.AuthorLabel.TabIndex = 2;
            this.AuthorLabel.Text = "Author:Rodichev Artem";
            // 
            // emailFeedbackLabel
            // 
            this.emailFeedbackLabel.AutoSize = true;
            this.emailFeedbackLabel.Location = new System.Drawing.Point(18, 127);
            this.emailFeedbackLabel.Name = "emailFeedbackLabel";
            this.emailFeedbackLabel.Size = new System.Drawing.Size(100, 13);
            this.emailFeedbackLabel.TabIndex = 3;
            this.emailFeedbackLabel.Text = "e-mail for feedback:";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.ForeColor = System.Drawing.Color.Blue;
            this.emailLabel.Location = new System.Drawing.Point(124, 127);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(131, 13);
            this.emailLabel.TabIndex = 4;
            this.emailLabel.Text = "rodichevartem@yandex.ru";
            // 
            // githubLabel
            // 
            this.githubLabel.AutoSize = true;
            this.githubLabel.Location = new System.Drawing.Point(18, 149);
            this.githubLabel.Name = "githubLabel";
            this.githubLabel.Size = new System.Drawing.Size(43, 13);
            this.githubLabel.TabIndex = 5;
            this.githubLabel.Text = "GitHub:";
            // 
            // githubAdressLabel
            // 
            this.githubAdressLabel.AutoSize = true;
            this.githubAdressLabel.ForeColor = System.Drawing.Color.Blue;
            this.githubAdressLabel.Location = new System.Drawing.Point(67, 149);
            this.githubAdressLabel.Name = "githubAdressLabel";
            this.githubAdressLabel.Size = new System.Drawing.Size(214, 13);
            this.githubAdressLabel.TabIndex = 6;
            this.githubAdressLabel.Text = "https://github.com/kekc1915/ContactsApp";
            // 
            // tmLabel
            // 
            this.tmLabel.AutoSize = true;
            this.tmLabel.Location = new System.Drawing.Point(18, 247);
            this.tmLabel.Name = "tmLabel";
            this.tmLabel.Size = new System.Drawing.Size(119, 13);
            this.tmLabel.TabIndex = 7;
            this.tmLabel.Text = "2018 Artem Rodichev©";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 269);
            this.Controls.Add(this.tmLabel);
            this.Controls.Add(this.githubAdressLabel);
            this.Controls.Add(this.githubLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.emailFeedbackLabel);
            this.Controls.Add(this.AuthorLabel);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.ContactsAppLabel);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(388, 308);
            this.MinimumSize = new System.Drawing.Size(388, 308);
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "About";
            this.Load += new System.EventHandler(this.AboutForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ContactsAppLabel;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label AuthorLabel;
        private System.Windows.Forms.Label emailFeedbackLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label githubLabel;
        private System.Windows.Forms.Label githubAdressLabel;
        private System.Windows.Forms.Label tmLabel;
    }
}