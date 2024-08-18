namespace PointOfSaleSystem
{
    partial class SignUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpForm));
            this.LoginCard = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.signUpPasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.showPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.signUpUsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.backToLogin = new Guna.UI2.WinForms.Guna2Button();
            this.LoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginCard
            // 
            this.LoginCard.BackColor = System.Drawing.Color.Wheat;
            this.LoginCard.BorderColor = System.Drawing.Color.Black;
            this.LoginCard.BorderRadius = 7;
            this.LoginCard.BorderThickness = 1;
            this.LoginCard.Controls.Add(this.backToLogin);
            this.LoginCard.Controls.Add(this.guna2TextBox1);
            this.LoginCard.Controls.Add(this.loginButton);
            this.LoginCard.Controls.Add(this.showPassword);
            this.LoginCard.Controls.Add(this.guna2PictureBox1);
            this.LoginCard.Controls.Add(this.signUpPasswordTB);
            this.LoginCard.Controls.Add(this.signUpUsernameTB);
            this.LoginCard.Location = new System.Drawing.Point(421, 114);
            this.LoginCard.Name = "LoginCard";
            this.LoginCard.Size = new System.Drawing.Size(400, 500);
            this.LoginCard.TabIndex = 1;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 7;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(80, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(240, 169);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // signUpPasswordTB
            // 
            this.signUpPasswordTB.Animated = true;
            this.signUpPasswordTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.signUpPasswordTB.BorderRadius = 17;
            this.signUpPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signUpPasswordTB.DefaultText = "";
            this.signUpPasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signUpPasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signUpPasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signUpPasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signUpPasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signUpPasswordTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.signUpPasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.signUpPasswordTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("signUpPasswordTB.IconLeft")));
            this.signUpPasswordTB.IconLeftSize = new System.Drawing.Size(30, 30);
            this.signUpPasswordTB.Location = new System.Drawing.Point(30, 232);
            this.signUpPasswordTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpPasswordTB.Name = "signUpPasswordTB";
            this.signUpPasswordTB.PasswordChar = '●';
            this.signUpPasswordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.signUpPasswordTB.PlaceholderText = "Enter Password";
            this.signUpPasswordTB.SelectedText = "";
            this.signUpPasswordTB.Size = new System.Drawing.Size(343, 36);
            this.signUpPasswordTB.TabIndex = 7;
            // 
            // showPassword
            // 
            this.showPassword.Animated = true;
            this.showPassword.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.showPassword.CheckedState.BorderRadius = 0;
            this.showPassword.CheckedState.BorderThickness = 0;
            this.showPassword.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.showPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPassword.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPassword.ForeColor = System.Drawing.Color.Black;
            this.showPassword.Location = new System.Drawing.Point(30, 319);
            this.showPassword.Name = "showPassword";
            this.showPassword.Size = new System.Drawing.Size(155, 37);
            this.showPassword.TabIndex = 6;
            this.showPassword.Text = "Show Password";
            this.showPassword.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.showPassword.UncheckedState.BorderRadius = 0;
            this.showPassword.UncheckedState.BorderThickness = 0;
            this.showPassword.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // signUpUsernameTB
            // 
            this.signUpUsernameTB.Animated = true;
            this.signUpUsernameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.signUpUsernameTB.BorderRadius = 17;
            this.signUpUsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.signUpUsernameTB.DefaultText = "";
            this.signUpUsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.signUpUsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.signUpUsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signUpUsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.signUpUsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.signUpUsernameTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpUsernameTB.ForeColor = System.Drawing.Color.Black;
            this.signUpUsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.signUpUsernameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("signUpUsernameTB.IconLeft")));
            this.signUpUsernameTB.IconLeftSize = new System.Drawing.Size(30, 30);
            this.signUpUsernameTB.Location = new System.Drawing.Point(30, 188);
            this.signUpUsernameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.signUpUsernameTB.Name = "signUpUsernameTB";
            this.signUpUsernameTB.PasswordChar = '\0';
            this.signUpUsernameTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.signUpUsernameTB.PlaceholderText = "Enter Username";
            this.signUpUsernameTB.SelectedText = "";
            this.signUpUsernameTB.Size = new System.Drawing.Size(343, 36);
            this.signUpUsernameTB.TabIndex = 3;
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
            this.loginButton.FillColor = System.Drawing.Color.Beige;
            this.loginButton.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.loginButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(30, 362);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(343, 40);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Sign Up";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Animated = true;
            this.guna2TextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.guna2TextBox1.BorderRadius = 17;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.guna2TextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("guna2TextBox1.IconLeft")));
            this.guna2TextBox1.IconLeftSize = new System.Drawing.Size(30, 30);
            this.guna2TextBox1.Location = new System.Drawing.Point(30, 276);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '●';
            this.guna2TextBox1.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.guna2TextBox1.PlaceholderText = "Confirm Password";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(343, 36);
            this.guna2TextBox1.TabIndex = 9;
            // 
            // backToLogin
            // 
            this.backToLogin.Animated = true;
            this.backToLogin.BorderColor = System.Drawing.Color.White;
            this.backToLogin.BorderRadius = 17;
            this.backToLogin.BorderThickness = 2;
            this.backToLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backToLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backToLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backToLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backToLogin.FillColor = System.Drawing.Color.Empty;
            this.backToLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToLogin.ForeColor = System.Drawing.Color.Black;
            this.backToLogin.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.backToLogin.Location = new System.Drawing.Point(29, 436);
            this.backToLogin.Name = "backToLogin";
            this.backToLogin.Size = new System.Drawing.Size(343, 40);
            this.backToLogin.TabIndex = 10;
            this.backToLogin.Text = "Back";
            this.backToLogin.Click += new System.EventHandler(this.backToLogin_Click);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 728);
            this.Controls.Add(this.LoginCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUpForm";
            this.LoginCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LoginCard;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox signUpPasswordTB;
        private Guna.UI2.WinForms.Guna2CheckBox showPassword;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2TextBox signUpUsernameTB;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2Button backToLogin;
    }
}