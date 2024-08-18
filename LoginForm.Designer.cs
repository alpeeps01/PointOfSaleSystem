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
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.loginPasswordTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.showPassword = new Guna.UI2.WinForms.Guna2CheckBox();
            this.loginButton = new Guna.UI2.WinForms.Guna2Button();
            this.loginUsernameTB = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.close = new Guna.UI2.WinForms.Guna2PictureBox();
            this.signUpButton = new Guna.UI2.WinForms.Guna2Button();
            this.LoginCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginCard
            // 
            this.LoginCard.BackColor = System.Drawing.Color.Wheat;
            this.LoginCard.BorderColor = System.Drawing.Color.Black;
            this.LoginCard.BorderRadius = 7;
            this.LoginCard.BorderThickness = 1;
            this.LoginCard.Controls.Add(this.signUpButton);
            this.LoginCard.Controls.Add(this.guna2PictureBox1);
            this.LoginCard.Controls.Add(this.loginPasswordTB);
            this.LoginCard.Controls.Add(this.showPassword);
            this.LoginCard.Controls.Add(this.loginButton);
            this.LoginCard.Controls.Add(this.loginUsernameTB);
            this.LoginCard.Location = new System.Drawing.Point(75, 50);
            this.LoginCard.Name = "LoginCard";
            this.LoginCard.Size = new System.Drawing.Size(400, 500);
            this.LoginCard.TabIndex = 0;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 7;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(80, 12);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(240, 179);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 8;
            this.guna2PictureBox1.TabStop = false;
            // 
            // loginPasswordTB
            // 
            this.loginPasswordTB.Animated = true;
            this.loginPasswordTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.loginPasswordTB.BorderRadius = 17;
            this.loginPasswordTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginPasswordTB.DefaultText = "";
            this.loginPasswordTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginPasswordTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginPasswordTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPasswordTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginPasswordTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginPasswordTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTB.ForeColor = System.Drawing.Color.Black;
            this.loginPasswordTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.loginPasswordTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("loginPasswordTB.IconLeft")));
            this.loginPasswordTB.IconLeftSize = new System.Drawing.Size(30, 30);
            this.loginPasswordTB.Location = new System.Drawing.Point(30, 248);
            this.loginPasswordTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginPasswordTB.Name = "loginPasswordTB";
            this.loginPasswordTB.PasswordChar = '●';
            this.loginPasswordTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.loginPasswordTB.PlaceholderText = "Enter Password";
            this.loginPasswordTB.SelectedText = "";
            this.loginPasswordTB.Size = new System.Drawing.Size(343, 36);
            this.loginPasswordTB.TabIndex = 7;
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
            this.loginButton.FillColor = System.Drawing.Color.Beige;
            this.loginButton.Font = new System.Drawing.Font("Inter", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.ForeColor = System.Drawing.Color.Black;
            this.loginButton.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.loginButton.HoverState.ForeColor = System.Drawing.Color.Black;
            this.loginButton.Location = new System.Drawing.Point(30, 351);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(343, 40);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // loginUsernameTB
            // 
            this.loginUsernameTB.Animated = true;
            this.loginUsernameTB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(19)))), ((int)(((byte)(21)))));
            this.loginUsernameTB.BorderRadius = 17;
            this.loginUsernameTB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.loginUsernameTB.DefaultText = "";
            this.loginUsernameTB.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.loginUsernameTB.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.loginUsernameTB.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginUsernameTB.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.loginUsernameTB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.loginUsernameTB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginUsernameTB.ForeColor = System.Drawing.Color.Black;
            this.loginUsernameTB.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(45)))));
            this.loginUsernameTB.IconLeft = ((System.Drawing.Image)(resources.GetObject("loginUsernameTB.IconLeft")));
            this.loginUsernameTB.IconLeftSize = new System.Drawing.Size(30, 30);
            this.loginUsernameTB.Location = new System.Drawing.Point(30, 206);
            this.loginUsernameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginUsernameTB.Name = "loginUsernameTB";
            this.loginUsernameTB.PasswordChar = '\0';
            this.loginUsernameTB.PlaceholderForeColor = System.Drawing.Color.DimGray;
            this.loginUsernameTB.PlaceholderText = "Enter Username";
            this.loginUsernameTB.SelectedText = "";
            this.loginUsernameTB.Size = new System.Drawing.Size(343, 36);
            this.loginUsernameTB.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(190, 220);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 13);
            this.lblMessage.TabIndex = 2;
            this.lblMessage.Visible = false;
            // 
            // close
            // 
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageRotate = 0F;
            this.close.Location = new System.Drawing.Point(507, 12);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(31, 36);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.close.TabIndex = 8;
            this.close.TabStop = false;
            this.close.Click += new System.EventHandler(this.close_Click_1);
            // 
            // signUpButton
            // 
            this.signUpButton.Animated = true;
            this.signUpButton.BorderColor = System.Drawing.Color.White;
            this.signUpButton.BorderRadius = 17;
            this.signUpButton.BorderThickness = 2;
            this.signUpButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpButton.FillColor = System.Drawing.Color.Empty;
            this.signUpButton.Font = new System.Drawing.Font("Inter", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.ForeColor = System.Drawing.Color.Black;
            this.signUpButton.HoverState.FillColor = System.Drawing.SystemColors.Control;
            this.signUpButton.Location = new System.Drawing.Point(29, 435);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(343, 40);
            this.signUpButton.TabIndex = 9;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(550, 600);
            this.Controls.Add(this.close);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.LoginCard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.LoginCard.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LoginCard;
        private Guna.UI2.WinForms.Guna2TextBox loginUsernameTB;
        private Guna.UI2.WinForms.Guna2Button loginButton;
        private Guna.UI2.WinForms.Guna2CheckBox showPassword;
        private Guna.UI2.WinForms.Guna2TextBox loginPasswordTB;
        private System.Windows.Forms.Label lblMessage;
        private Guna.UI2.WinForms.Guna2PictureBox close;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button signUpButton;
    }
}