namespace Pharmacy
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.createAccountLabel = new System.Windows.Forms.Label();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.loginButtonPB = new System.Windows.Forms.PictureBox();
            this.exitPictureBox = new System.Windows.Forms.PictureBox();
            this.errorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameTextBox.Location = new System.Drawing.Point(83, 214);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(247, 23);
            this.usernameTextBox.TabIndex = 0;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.Text = "Username";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordTextBox.Location = new System.Drawing.Point(83, 253);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(247, 23);
            this.passwordTextBox.TabIndex = 1;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextChanged += new System.EventHandler(this.passwordTextBox_TextChanged);
            // 
            // createAccountLabel
            // 
            this.createAccountLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createAccountLabel.AutoSize = true;
            this.createAccountLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccountLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.createAccountLabel.Location = new System.Drawing.Point(83, 290);
            this.createAccountLabel.Name = "createAccountLabel";
            this.createAccountLabel.Size = new System.Drawing.Size(86, 15);
            this.createAccountLabel.TabIndex = 3;
            this.createAccountLabel.Text = "Create account";
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.forgotPasswordLabel.Location = new System.Drawing.Point(232, 290);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(98, 15);
            this.forgotPasswordLabel.TabIndex = 4;
            this.forgotPasswordLabel.Text = "Forgot password?";
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = global::Pharmacy.Properties.Resources.login;
            this.loginPictureBox.Location = new System.Drawing.Point(126, 66);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(162, 107);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPictureBox.TabIndex = 5;
            this.loginPictureBox.TabStop = false;
            // 
            // loginButtonPB
            // 
            this.loginButtonPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtonPB.Image = global::Pharmacy.Properties.Resources.LOGINBUTTON;
            this.loginButtonPB.Location = new System.Drawing.Point(152, 329);
            this.loginButtonPB.Name = "loginButtonPB";
            this.loginButtonPB.Size = new System.Drawing.Size(109, 34);
            this.loginButtonPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginButtonPB.TabIndex = 6;
            this.loginButtonPB.TabStop = false;
            this.loginButtonPB.Click += new System.EventHandler(this.LoginButtonPictureBox_Click);
            // 
            // exitPictureBox
            // 
            this.exitPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitPictureBox.Image = global::Pharmacy.Properties.Resources.X;
            this.exitPictureBox.Location = new System.Drawing.Point(385, 7);
            this.exitPictureBox.Name = "exitPictureBox";
            this.exitPictureBox.Size = new System.Drawing.Size(20, 20);
            this.exitPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.exitPictureBox.TabIndex = 7;
            this.exitPictureBox.TabStop = false;
            this.exitPictureBox.Click += new System.EventHandler(this.exitPictureBox_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorLabel.AutoSize = true;
            this.errorLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.errorLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.errorLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.errorLabel.Location = new System.Drawing.Point(83, 385);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 17);
            this.errorLabel.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 454);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.exitPictureBox);
            this.Controls.Add(this.loginButtonPB);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.forgotPasswordLabel);
            this.Controls.Add(this.createAccountLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.usernameTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginButtonPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label createAccountLabel;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.PictureBox loginButtonPB;
        private System.Windows.Forms.PictureBox exitPictureBox;
        private System.Windows.Forms.Label errorLabel;
    }
}
