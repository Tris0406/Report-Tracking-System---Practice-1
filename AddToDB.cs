using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Report_Tracking_System___Practice_1
{
    public class AddToDB
    {
        private string _connectionString;

        public AddToDB(string connectionString)
        {
            _connectionString = connectionString;
        }

        public bool UsernameExists(string username)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand checkCmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Username = @Username", con))
                {
                    checkCmd.Parameters.AddWithValue("@Username", username);
                    int userCount = (int)checkCmd.ExecuteScalar();
                    return userCount > 0;
                }
            }
        }

        public bool SaveUser(string name, string surname, string username, string hashedPassword)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                using (SqlCommand insertCmd = new SqlCommand(
                    "INSERT INTO Users (Name, Surname, Username, Password) VALUES (@Name, @Surname, @Username, @Password)", con))
                {
                    insertCmd.Parameters.AddWithValue("@Name", name);
                    insertCmd.Parameters.AddWithValue("@Surname", surname);
                    insertCmd.Parameters.AddWithValue("@Username", username);
                    insertCmd.Parameters.AddWithValue("@Password", hashedPassword);

                    int rowsAffected = insertCmd.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public string GetStoredHashedPassword(string username)
        {
            using (SqlConnection con = new SqlConnection(_connectionString))
            {
                con.Open();
                string query = "SELECT Password FROM Users WHERE Username = @Username";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    object result = cmd.ExecuteScalar();
                    return result?.ToString();
                }
            }
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hashBytes = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hashBytes);
            }
        }

        public string GenerateRepoprtID()
        {
            string nextId = "RPT001";

            using (SqlConnection con = new SqlConnection(_connectionString))
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
    }
}
