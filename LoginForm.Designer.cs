namespace PointOfSaleSystem
{
    partial class LoginForm
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
        /// 

       

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.LoginCard = new Guna.UI2.WinForms.Guna2Panel();
            this.passwordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.showPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.usernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.titleLogin = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.LoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginCard
            // 
            this.LoginCard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.LoginCard.BorderColor = System.Drawing.Color.White;
            this.LoginCard.BorderRadius = 7;
            this.LoginCard.BorderThickness = 1;
            this.LoginCard.Controls.Add(this.passwordTB);
            this.LoginCard.Controls.Add(this.showPassword);
            this.LoginCard.Controls.Add(this.loginButton);
            this.LoginCard.Controls.Add(this.usernameTB);
            this.LoginCard.Controls.Add(this.guna2HtmlLabel2);
            this.LoginCard.Controls.Add(this.guna2HtmlLabel1);
            this.LoginCard.Controls.Add(this.titleLogin);
            this.LoginCard.Location = new System.Drawing.Point(75, 50);
            this.LoginCard.Name = "LoginCard";
            this.LoginCard.Size = new System.Drawing.Size(400, 500);
            this.LoginCard.TabIndex = 0;
            // 
            // passwordTB
            // 
            this.passwordTB.Animated = true;
            this.passwordTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.passwordTB.BorderRadius = 17;
            this.passwordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordTB.DefaultText = "";
            this.passwordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordTB.ForeColor = System.Drawing.Color.Black;
            this.passwordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.passwordTB.Location = new System.Drawing.Point(30, 248);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.PasswordChar = '●';
            this.passwordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.passwordTB.PlaceholderText = "Enter Password";
            this.passwordTB.SelectedText = "";
            this.passwordTB.Size = new System.Drawing.Size(343, 36);
            this.passwordTB.TabIndex = 7;
            // 
            // showPassword
            // 
            this.showPassword.Animated = true;
            this.showPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.showPassword.CheckedState.BorderRadius = 0;
            this.showPassword.CheckedState.BorderThickness = 0;
            this.showPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.showPassword.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.Color.White;
            this.showPassword.Location = new System.Drawing.Point(30, 290);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(155, 37);
            this.showPassword.TabIndex = 6;
            this.showPassword.Text = "Show Password";
            this.showPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPassword.UncheckedState.BorderRadius = 0;
            this.showPassword.UncheckedState.BorderThickness = 0;
            this.showPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPassword.CheckedChanged += new System.EventHandler(this.showPassword_CheckedChanged);
            // 
            // loginButton
            // 
            this.loginButton.Animated = true;
            this.loginButton.BorderColor = System.Drawing.Color.White;
            this.loginButton.BorderRadius = 17;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.loginButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.loginButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.loginButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.loginButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.loginButton.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.White;
            this.loginButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(202)))), ((int)(((byte)(239)))));
            this.loginButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(30, 351);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(343, 40);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // usernameTB
            // 
            this.usernameTB.Animated = true;
            this.usernameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.usernameTB.BorderRadius = 17;
            this.usernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameTB.DefaultText = "";
            this.usernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameTB.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernameTB.ForeColor = System.Drawing.Color.Black;
            this.usernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.usernameTB.Location = new System.Drawing.Point(30, 161);
            this.usernameTB.Name = "usernameTB";
            this.usernameTB.PasswordChar = '\0';
            this.usernameTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.usernameTB.PlaceholderText = "Enter Username";
            this.usernameTB.SelectedText = "";
            this.usernameTB.Size = new System.Drawing.Size(343, 36);
            this.usernameTB.TabIndex = 3;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(30, 217);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(91, 25);
            this.guna2HtmlLabel2.TabIndex = 2;
            this.guna2HtmlLabel2.Text = "Password";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.White;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(30, 130);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(95, 25);
            this.guna2HtmlLabel1.TabIndex = 1;
            this.guna2HtmlLabel1.Text = "Username";
            // 
            // titleLogin
            // 
            this.titleLogin.BackColor = System.Drawing.Color.Transparent;
            this.titleLogin.Font = new System.Drawing.Font("Inter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLogin.ForeColor = System.Drawing.Color.White;
            this.titleLogin.Location = new System.Drawing.Point(170, 50);
            this.titleLogin.Name = "titleLogin";
            this.titleLogin.Size = new System.Drawing.Size(79, 31);
            this.titleLogin.TabIndex = 0;
            this.titleLogin.Text = "LOGIN";
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageRotate = 0F;
            this.close.Location = new System.Drawing.Point(511, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(27, 31);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 1;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.guna2PictureBox1_Click);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(190, 150);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Visible = false;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.LoginCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.LoginCard.ResumeLayout(false);
            this.LoginCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LoginCard;
        private Guna.UI2.WinForms.Guna2HtmlLabel titleLogin;
        private Guna.UI2.WinForms.Guna2TextBox usernameTB;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2PictureBox close;
        private Guna.UI2.WinForms.Guna2CheckBox showPassword;
        private Guna.UI2.WinForms.Guna2TextBox passwordTB;
        private System.Windows.Forms.Label lblMessage;
    }
}