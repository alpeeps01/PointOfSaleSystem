using Guna.UI2.WinForms;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSaleSystem
{
    public partial class LoginForm : Form
    {
        private readonly MongoDBConnection _dbConnection;
        private readonly UserRepository _userRepository;

        public LoginForm()
        {
            InitializeComponent();
            _dbConnection = new MongoDBConnection("mongodb://localhost:27017/", "user_admin");
            _userRepository = new UserRepository(_dbConnection);
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernameTB.Text;
                string password = passwordTB.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    lblMessage.Text = "Username or Password field is blank.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Visible = true;
                    return;
                }

                var user = _userRepository.GetUserByUsername(username);

                if (user != null && _userRepository.VerifyPassword(user, password))
                {
                    lblMessage.Visible = false;
                    MessageBox.Show("Login Successfully");

                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                    this.Hide();

                }
                else
                {
                    lblMessage.Text = "Invalid Username or Password.";
                    lblMessage.ForeColor = System.Drawing.Color.Red;
                    lblMessage.Visible = true;
                }
            } 
            catch(MongoConnectionException)
            {
                lblMessage.Text = "There was a problem with out database.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Visible = true;
            }
            catch (Exception ex)
            {
                lblMessage.Text = "An unexpected error occured.";
                lblMessage.ForeColor = System.Drawing.Color.Red;
                lblMessage.Visible = true;

                Console.WriteLine(ex.Message);
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            passwordTB.PasswordChar = showPassword.Checked ? '\0' : '●';
        }
    }
}
