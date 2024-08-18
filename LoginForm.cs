using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PointOfSaleSystem
{
    public partial class LoginForm : Form
    {
        public static readonly string con_string = (@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Asus TUF\OneDrive\Documents\cafe.mdf"";Integrated Security=True;Connect Timeout=30");
        public static SqlConnection connect = new SqlConnection(con_string);
        public LoginForm()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public bool emptyFields()
        {
            if (loginUsernameTB.Text == "" ||  loginPasswordTB.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectAccount = "SELECT * FROM users WHERE username = @user AND password = @pass AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectAccount, connect))
                        {
                            cmd.Parameters.AddWithValue("@user", loginUsernameTB.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", loginPasswordTB.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable table = new DataTable();
                            adapter.Fill(table);

                            if (table.Rows.Count >= 1)
                            {
                                MessageBox.Show("Login Successfully.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Dashboard dashboard = new Dashboard();
                                dashboard.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password or there's no Admin's approval.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Failed." + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }

                }
            }
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            loginPasswordTB.PasswordChar = showPassword.Checked ? '\0' : '●';
        }

        private void close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm SignUp = new SignUpForm();
            SignUp.Show();
            this.Hide();
        }
    }
}
