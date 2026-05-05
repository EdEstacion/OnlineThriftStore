using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics.Eventing.Reader;

namespace Project2_Online_Thrifiting_Store
{
    public partial class Form1 : Form
    {
        private readonly string userFile = "users.txt";
        private Timer MesTimer;
        public Form1()
        {
            InitializeComponent();
            HideCredentials();

            if (!File.Exists(userFile))
            {
                File.Create(userFile).Close();
            }

            MesTimer = new Timer();
            MesTimer.Interval = 1000;
            MesTimer.Tick += MesTimer_Tick;

        }

        private void MesTimer_Tick(object sender, EventArgs e)
        {
            MesTimer.Stop();

            ErroMessage.Text = "";

            var welecomeForm = new Form2(txbUserName.Text);
            welecomeForm.Show();
            this.Hide();
        }

        private void HideCredentials()
        {
            txbUserName.Visible = false;
            txbPassword.Visible = false;
            btnSubmit.Visible = false;
            txbCreateUsername.Visible = false;
            txbCreatePassword.Visible = false;
        }

        private void ShowLogin()
        {
            txbUserName.Visible = true;
            txbPassword.Visible = true;
            txbCreateUsername.Visible = false;
            txbCreatePassword.Visible = false;
            btnSubmit.Visible = true;
            btnSubmit.Tag = "Login";
            ErroMessage.Text = ""; // Clear any previous error messages
        }

        private void ShowSignup()
        {
            txbCreateUsername.Visible = true;
            txbCreatePassword.Visible = true;
            txbUserName.Visible = false;
            txbPassword.Visible = false;
            btnSubmit.Visible = true;
            btnSubmit.Tag = "Signup";
            ErroMessage.Text = ""; // Clear any previous error messages
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            ShowSignup();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string action = btnSubmit.Tag as string;

            if (action == "Login")
            {
                HandleLogin();
            }
            else if (action == "Signup")
            {
                HandleSignup();
            }
            else
            {
                ErroMessage.Text = "Please select Login or Sign Up first.";
            }
        }

        private void HandleLogin()
        {
            // Get login input
            string username = txbUserName.Text.Trim();
            string password = txbPassword.Text.Trim();

            // Validate login fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ErroMessage.Text = "Please enter both username and password for login.";
                return;
            }

            // Validate credentials from file
            if (ValidateLogin(username, password))
            {
                ErroMessage.Text = "Login Successful";
                MesTimer.Start();
            }
            else
            {
                ErroMessage.Text = "Invalid login credentials. Please try again.";
            }
        }

        private void HandleSignup()
        {
            // Get signup input
            string username = txbCreateUsername.Text.Trim();
            string password = txbCreatePassword.Text.Trim();

            // Validate signup fields
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                ErroMessage.Text = "Please enter both username and password to sign up.";
                return;
            }

            // Save the new user to file
            if (SaveNewUser(username, password))
            {
                ErroMessage.Text = "Login Successful";
                MesTimer.Start();
            }
            else
            {
                ErroMessage.Text = "Username already exists. Please try a different one.";
            }
        }

        private bool ValidateLogin(string username, string password)
        {
            string[] users = File.ReadAllLines(userFile);
            foreach (string user in users)
            {
                string[] parts = user.Split(':');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    return true;
                }
            }
            return false;
        }

        private bool SaveNewUser(string username, string password)
        {
            string[] users = File.ReadAllLines(userFile);

            foreach (string user in users)
            {
                string[] parts = user.Split(':');
                if (parts.Length == 2 && parts[0] == username)
                {
                    return false; // Username already exists
                }
            }

            try
            {
                using (StreamWriter writer = File.AppendText(userFile))
                {
                    writer.WriteLine($"{username}:{password}");
                }
                return true;
            }

            catch (Exception ex)
            {
                {
                    MessageBox.Show($"Error Saving User: {ex.Message}");
                    return false;
                }


            }

        }


    }
}
