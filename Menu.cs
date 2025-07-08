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

namespace Report_Tracking_System___Practice_1
{
    public partial class Menu : Form
    {
        public bool bLoggedin = false;
        public string sConnectionString = @"Server=localhost;Database=Report_Tracker_System_Practice_1;Trusted_Connection=True;";
        // creates connection to db

        public Menu()
        {
            InitializeComponent();
        }

        private void tMenu_Click(object sender, EventArgs e)
        {
            
            foreach (TabPage tab in tMenu.TabPages)
            {
                if (tab != tLogin && tab != tRegister)
                    tab.Enabled = false;
            }
            // all tabs are not accesible until login

            tMenu.Selecting += (s, args) =>
            {
                if (!bLoggedin && args.TabPage != tLogin && args.TabPage != tRegister)
                {
                    args.Cancel = true;
                    MessageBox.Show("Please log in first.");
                }
            };
        }

        private void btnRRegister_Click(object sender, EventArgs e)
        {
            string sName = txtRName.Text.Trim();
            string sSurname = txtRSurname.Text.Trim();
            string sUsername = txtRUsername.Text.Trim();
            string sPassword = txtRPassword.Text.Trim();
            // gets user inputs


            if (!ValidateInputs(sName, sSurname, sUsername, sPassword))
                return;

            string sHashedPassword = HashPassword(sPassword);
            string newUserID = GenerateNextUserID();

            SaveUserToDatabase(newUserID, sName, sSurname, sUsername, sHashedPassword);
        }

        private bool ValidateInputs(string sName, string sSurname, string sUsername, string sPassword)
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
                            txtRName.Clear();
                            txtRSurname.Clear();
                            txtRUsername.Clear();
                            txtRPassword.Clear();
                            chboxRShowPassword.Checked = false;
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
        
        
    }
}
