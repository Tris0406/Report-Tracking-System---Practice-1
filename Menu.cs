using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Report_Tracking_System___Practice_1
{
    public partial class Menu : Form
    {
        public bool bLoggedin = false;
        public string sConnectionString = @"Server=localhost;Database=Report_Tracker_System_Practice_1;Trusted_Connection=True;";
        // creates connection to db
        private bool tabsInitiallyDisabled = false;
        // disables tabs once

        public Menu()
        {
            InitializeComponent();
            this.Load += tMenu_Click;
        }

        private void tMenu_Click(object sender, EventArgs e)
        {

            // Disable tabs except Login and Register only once
            if (!tabsInitiallyDisabled)
            {
                foreach (TabPage tab in tMenu.TabPages)
                {
                    if (tab != tLogin && tab != tRegister)
                        tab.Enabled = false;
                }
                tabsInitiallyDisabled = true;
            }

            // Attach the tab selecting event once
            tMenu.Selecting -= tMenu_Selecting; // Remove if already attached (to avoid multiple attaches)
            tMenu.Selecting += tMenu_Selecting;
        }
        private void tMenu_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!bLoggedin && e.TabPage != tLogin && e.TabPage != tRegister)
            {
                e.Cancel = true;
                MessageBox.Show("Please log in first.");
            }
        }
        // requires the user to login before accessing other tabs
                
        private void EnableAllTabs()
        {
            foreach (TabPage tab in tMenu.TabPages)
            {
                tab.Enabled = true;
            }
        }
        // enables all the tabs after login

        // *** RESGISTER TAB ***
        private void btnRRegister_Click(object sender, EventArgs e)
        {
            string sName = txtRName.Text.Trim();
            string sSurname = txtRSurname.Text.Trim();
            string sUsername = txtRUsername.Text.Trim();
            string sPassword = txtRPassword.Text.Trim();
            // gets user inputs


            if (!ValidateRInputs(sName, sSurname, sUsername, sPassword))
                return;

            string sHashedPassword = HashPassword(sPassword);
            string newUserID = GenerateNextUserID();

            SaveUserToDatabase(newUserID, sName, sSurname, sUsername, sHashedPassword);
        }

        private bool ValidateRInputs(string sName, string sSurname, string sUsername, string sPassword)
        {
            int maxLength = 25;

            if (string.IsNullOrWhiteSpace(sName) || sName.Length > maxLength)
            {
                MessageBox.Show("Please enter your Name (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(sSurname) || sSurname.Length > maxLength)
            {
                MessageBox.Show("Please enter your Surname (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(sUsername) || sUsername.Length > maxLength)
            {
                MessageBox.Show("Please enter your Username (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(sPassword) || sPassword.Length > maxLength)
            {
                MessageBox.Show("Please enter your Password (max 25 characters).");
                return false;
            }

            bool hasNumber = sPassword.Any(char.IsDigit);
            bool hasSpecialChar = sPassword.Any(ch => !char.IsLetterOrDigit(ch));

            if (!hasNumber || !hasSpecialChar)
            {
                MessageBox.Show("Password must contain at least one number and one special character.");
                return false;
            }

            return true;
        }
        // validates the inputs 

        private void chboxRShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtRPassword.UseSystemPasswordChar = !chboxRShowPassword.Checked;
        }
        // shows the pw when chbox is clicked

        private string GenerateNextUserID()
        {
            string nextId = "RPT001";

            using (SqlConnection con = new SqlConnection(sConnectionString))
            using (SqlCommand cmd = new SqlCommand("SELECT MAX(UserID) FROM Users WHERE UserID LIKE 'RPT%'", con))
            {
                con.Open();
                var result = cmd.ExecuteScalar();
                if (result != DBNull.Value && result != null)
                {
                    string lastId = (string)result;
                    int number = int.Parse(lastId.Substring(3)) + 1;
                    nextId = "RPT" + number.ToString("D3");
                }
            }

            return nextId;
        }
        // auto generate the report id 

        private void SaveUserToDatabase(string userID, string sName, string sSurname, string sUsername, string sHashedPassword)
        {
            using (SqlConnection con = new SqlConnection(sConnectionString))
            {
                try
                {
                    con.Open();

                    using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", con))
                    {
                        checkCmd.Parameters.AddWithValue("@Username", sUsername);
                        int userCount = (int)checkCmd.ExecuteScalar();
                        if (userCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose another one.");
                            txtRUsername.Clear();
                            return;
                        }
                    }

                    using (SqlCommand insertCmd = new SqlCommand(
                        "INSERT INTO Users (UserID, Name, Surname, Username, Password) VALUES (@UserID, @Name, @Surname, @Username, @Password)", con))
                    {
                        insertCmd.Parameters.AddWithValue("@UserID", userID);
                        insertCmd.Parameters.AddWithValue("@Name", sName);
                        insertCmd.Parameters.AddWithValue("@Surname", sSurname);
                        insertCmd.Parameters.AddWithValue("@Username", sUsername);
                        insertCmd.Parameters.AddWithValue("@Password", sHashedPassword);

                        int rowsAffected = insertCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User saved successfully!");
                            RClear_Fields();
                            
                        }
                        else
                        {
                            MessageBox.Show("Failed to save user.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        // saves users details to the db
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }
        // hashes the pw

        private void RClear_Fields()
        {
            txtRName.Clear();
            txtRSurname.Clear();
            txtRUsername.Clear();
            txtRPassword.Clear();
            chboxRShowPassword.Checked = false;
        }
        // clears the txt
        private void btnRCancel_Click(object sender, EventArgs e)
        {
            RClear_Fields();
        }
        // clears the txt

        // *** LOGIN TAB ***
        private void btnLLogin_Click(object sender, EventArgs e)
        {
            string sUsername = txtLUsername.Text.Trim();
            string sPassword = txtLPassword.Text.Trim();

            if (!ValidateLInputs(sUsername, sPassword))
                return;

            string hashedPassword = HashPassword(sPassword);

            using (SqlConnection con = new SqlConnection(sConnectionString))
            {
                try
                {
                    con.Open();

                    // Step 1: Check if username exists
                    string checkUserQuery = "SELECT Password FROM Users WHERE Username = @Username";
                    using (SqlCommand cmd = new SqlCommand(checkUserQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@Username", sUsername);
                        object result = cmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Username not found. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string storedHashedPassword = result.ToString().Trim();

                        if (storedHashedPassword == hashedPassword)
                        {
                            MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            bLoggedin = true;
                            EnableAllTabs();

                            // Enable all tabs
                            foreach (TabPage tab in tMenu.TabPages)
                            {
                                tab.Enabled = true;
                            }

                            LClear_Fields();
                        }

                        else
                        {
                            MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Login failed: " + ex.Message);
                }
            }
        }
        // allows the user to login

        private void chboxLShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtLPassword.UseSystemPasswordChar = !chboxLShowPassword.Checked;
        }
        // shows the pw
        private bool ValidateLInputs(string sUsername, string sPassword)
        {
            int maxLength = 25;
            if (string.IsNullOrWhiteSpace(sUsername) || sUsername.Length > maxLength)
            {
                MessageBox.Show("Please enter your Username (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(sPassword) || sPassword.Length > maxLength)
            {
                MessageBox.Show("Please enter your Password (max 25 characters).");
                return false;
            }

           
            return true;
        }
        // validates the inputs
        private void btnLCancel_Click(object sender, EventArgs e)
        {
            LClear_Fields();
        }
        private void LClear_Fields()
        {
            txtLUsername.Clear();
            txtLPassword.Clear();
            chboxLShowPassword.Checked = false;
        }
        // clears the txt
    }
}