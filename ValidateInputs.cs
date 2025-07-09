using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Tracking_System___Practice_1
{
    public class ValidateInputs
    {
        public bool ValidateRegistrationInputs(string name, string surname, string username, string password)
        {
            int maxLength = 25;

            if (string.IsNullOrWhiteSpace(name) || name.Length > maxLength)
            {
                MessageBox.Show("Please enter your Name (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(surname) || surname.Length > maxLength)
            {
                MessageBox.Show("Please enter your Surname (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(username) || username.Length > maxLength)
            {
                MessageBox.Show("Please enter your Username (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length > maxLength)
            {
                MessageBox.Show("Please enter your Password (max 25 characters).");
                return false;
            }

            bool hasNumber = password.Any(char.IsDigit);
            bool hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

            if (!hasNumber || !hasSpecialChar)
            {
                MessageBox.Show("Password must contain at least one number and one special character.");
                return false;
            }

            return true;
        }

        public bool ValidateLoginInputs(string username, string password)
        {
            int maxLength = 25;

            if (string.IsNullOrWhiteSpace(username) || username.Length > maxLength)
            {
                MessageBox.Show("Please enter your Username (max 25 characters).");
                return false;
            }

            if (string.IsNullOrWhiteSpace(password) || password.Length > maxLength)
            {
                MessageBox.Show("Please enter your Password (max 25 characters).");
                return false;
            }

            return true;
        }
    }
}
