
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DotNetEnv;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace KusinApp
{
    class SQLHelper
    {
        private MySqlConnection dbConn;
        private MySqlCommand sqlCommand;
        private MySqlDataAdapter da;
        private DataTable dt;

        //private string strConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=kusinapp;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";
        //private string strOtherConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=kusinapp;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";

        private readonly string strConn;


        public SQLHelper()
        {
            try
            {
                
                Env.Load();

                strConn = Environment.GetEnvironmentVariable("DB_CONNECTION");

                if (string.IsNullOrEmpty(strConn))
                {
                    //MessageBox.Show("⚠️ Database connection string missing — check your .env file or Copy to Output Directory setting.");
                    return;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void dbConnection()
        {
            try
            {
                using (dbConn = new MySqlConnection(strConn))
                {
                    dbConn.Open();
                    //MessageBox.Show("✅ Connection successful!");
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        //public void dbConnection(string database)
        //{
        //    dbConn = new MySqlConnection(strOtherConn + database);
        //    dbConn.Open();
        //    MessageBox.Show("Test Connection successful");
        //    dbConn.Close();
        //}

        public DataTable displayRecords(string strQuery)
        {
            try
            {
                using (dbConn = new MySqlConnection(strConn))
                {
                    dbConn.Open();
                    da = new MySqlDataAdapter(strQuery, dbConn);
                    dt = new DataTable();
                    da.Fill(dt);
                }
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching records: " + ex.Message);
                return null;
            }
        }

        public void displayRecords(string strQuery, DataGridView DG)
        {
            try
            {
                using (dbConn = new MySqlConnection(strConn))
                {
                    dbConn.Open();
                    da = new MySqlDataAdapter(strQuery, dbConn);
                    dt = new DataTable();
                    da.Fill(dt);
                    DG.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public void SQLManager(string strQuery)
        {
            try
            {
                using (dbConn = new MySqlConnection(strConn))
                {
                    dbConn.Open();
                    sqlCommand = new MySqlCommand(strQuery, dbConn);
                    sqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                return;
            }
        }

        public bool ValidateLogin(string user, string pass)
        {
            string query = "SELECT password FROM kusinapp.user_login WHERE username = @user;";
            try
            {
                using (dbConn = new MySqlConnection(strConn))
                {
                    dbConn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, dbConn))
                    {
                        cmd.Parameters.AddWithValue("@user", user);
                        string result = (string)cmd.ExecuteScalar();

                        if (result != null)
                            return pass == result;

                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validating login: " + ex.Message);
                return false;
            }
        }

        public string GetUserID(string username, string password)
        {
            string query = @"SELECT user_id FROM kusinapp.user_login 
                             WHERE LOWER(TRIM(username)) = LOWER(TRIM(@username)) 
                             AND TRIM(password) = TRIM(@password)
                             LIMIT 1;";
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Trim());
                        cmd.Parameters.AddWithValue("@password", password.Trim());

                        object result = cmd.ExecuteScalar();
                        return result?.ToString() ?? string.Empty;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getting user ID: " + ex.Message);
                return string.Empty;
            }
        }

        public DataTable GetUserInventory(string userID)
        {
            string query = @"SELECT user_id, ingredient_id, ingredient_name, ingredient_quantity 
                             FROM kusinapp.user_inventory 
                             WHERE user_id = @uid";
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", userID);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading inventory: " + ex.Message);
            }
            return dt;
        }

        internal void executeNonQuery(string insertQuery)
        {
            try
            {
                using (dbConn = new MySqlConnection(strConn))
                {
                    dbConn.Open();
                    using (var cmd = new MySqlCommand(insertQuery, dbConn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing non-query: " + ex.Message);
            }
        }

        internal DataTable SearchUserInventory(string userID, string searchTerm)
        {
            string query = @"SELECT user_id, ingredient_id, ingredient_name, ingredient_quantity 
                             FROM kusinapp.user_inventory 
                             WHERE user_id = @uid AND ingredient_name LIKE @searchTerm";
            DataTable dt = new DataTable();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@uid", userID);
                        cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");
                        MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                        da.Fill(dt);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching inventory: " + ex.Message);
            }
            return dt;
        }


    }
}
