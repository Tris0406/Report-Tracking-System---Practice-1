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
        private bool tabsInitiallyDisabled = false;
        private string sConnectionString = @"Server=localhost;Database=Report_Tracker_System_Practice_1;Trusted_Connection=True;";

        private AddToDB db;
        private ValidateInputs validator;

        public Menu()
        {
            InitializeComponent();
            db = new AddToDB(sConnectionString);
            validator = new ValidateInputs();

            this.Load += Menu_Load;

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Disable all tabs except Login and Register
            foreach (TabPage tab in tMenu.TabPages)
            {
                if (tab != tLogin && tab != tRegister)
                    tab.Enabled = false;
            }

            // Attach tab selection validation once
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

        private void EnableAllTabs()
        {
            foreach (TabPage tab in tMenu.TabPages)
            {
                tab.Enabled = true;
            }
        }

        // === REGISTER TAB ===
        private void btnRRegister_Click(object sender, EventArgs e)
        {
            string name = txtRName.Text.Trim();
            string surname = txtRSurname.Text.Trim();
            string username = txtRUsername.Text.Trim();
            string password = txtRPassword.Text.Trim();

            if (!validator.ValidateRegistrationInputs(name, surname, username, password))
                return;

            if (db.UsernameExists(username))
            {
                MessageBox.Show("Username already exists. Please choose another one.");
                txtRUsername.Clear();
                return;
            }

            string hashedPassword = db.HashPassword(password);

            bool saved = db.SaveUser(name, surname, username, hashedPassword);
            if (saved)
            {
                MessageBox.Show("User saved successfully!");
                RClear_Fields();
            }
            else
            {
                MessageBox.Show("Failed to save user.");
            }
        }

        private void chboxRShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtRPassword.UseSystemPasswordChar = !chboxRShowPassword.Checked;
        }

        private void RClear_Fields()
        {
            txtRName.Clear();
            txtRSurname.Clear();
            txtRUsername.Clear();
            txtRPassword.Clear();
            chboxRShowPassword.Checked = false;
        }

        private void btnRCancel_Click(object sender, EventArgs e)
        {
            RClear_Fields();
        }

        // === LOGIN TAB ===
        private void btnLLogin_Click(object sender, EventArgs e)
        {
            string username = txtLUsername.Text.Trim();
            string password = txtLPassword.Text.Trim();

            if (!validator.ValidateLoginInputs(username, password))
                return;

            string hashedPassword = db.HashPassword(password);
            string storedPassword = db.GetStoredHashedPassword(username);

            if (storedPassword == null)
            {
                MessageBox.Show("Username not found. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (hashedPassword == storedPassword)
            {
                MessageBox.Show("Login successful!", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                bLoggedin = true;
                EnableAllTabs();
                LClear_Fields();
            }
            else
            {
                MessageBox.Show("Incorrect password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chboxLShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtLPassword.UseSystemPasswordChar = !chboxLShowPassword.Checked;
        }

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

        
        private string GenerateReportID()
        {
            return db.GenerateRepoprtID(); 
        }
    }
}