
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
namespace KusinApp
{
    class SQLHelper
    {
        private MySqlConnection dbConn;
        private MySqlCommand sqlCommand;
        private MySqlDataAdapter da;
        private DataTable dt;

        private string strConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=kusinapp;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";
        private string strOtherConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=kusinapp;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";



        public void dbConnection()
        {
            dbConn = new MySqlConnection(strConn);
            dbConn.Open();
            
            dbConn.Close();
        }

        public void dbConnection(string database)
        {
            dbConn = new MySqlConnection(strOtherConn + database);
            dbConn.Open();
            MessageBox.Show("Test Connection successful");
            dbConn.Close();
        }

        public DataTable displayRecords(String strQuery) // display to combobox and etc using datatable
        {
            try
            {
                dbConn = new MySqlConnection(strConn);
                dbConn.Open();
                da = new MySqlDataAdapter(strQuery, dbConn);
                dt = new DataTable();
                da.Fill(dt); //whatever records in the server is present, will be filled into datagrid
                dbConn.Close();
                return dt;
            }
            catch(Exception ex)
            {
                return dt;
            }
            
        }

        public void displayRecords(String strQuery, DataGridView DG) //for datagrid view
        {
            try
            {
                dbConn.Open();
                da = new MySqlDataAdapter(strQuery, dbConn);
                dt = new DataTable();
                da.Fill(dt); //whatever records in the server is present, will be filled into datagrid
                DG.DataSource = dt;
                dbConn.Close();
            }
            catch(Exception ex)
            {
                return;
            }
        }

        public void SQLManager(String strQuery)
        {
            try
            {
                dbConn.Open();
                sqlCommand = new MySqlCommand(strQuery, dbConn);
                sqlCommand.ExecuteNonQuery();
                dbConn.Close();
            }
            catch(Exception ex)
            {
                return;
            }
            
        }

        public bool ValidateLogin(string user, string pass)
        {
            string query = "SELECT password FROM kusinapp.user_login WHERE username = @user;";
            
            MySqlCommand cmd = null;
            
            try
            {
                
                cmd = new MySqlCommand(query, dbConn);
                cmd.Parameters.AddWithValue("@user", user);
                dbConn.Open();
                string result = (string)cmd.ExecuteScalar();
                Console.WriteLine(result);

                if (result != null)
                {
                    string storedPass = result.ToString();  

                    return pass == storedPass;
                }

                return false;
            }
            catch (Exception ex)
                { 
            
                return false;
            }
            finally
            {
                if (cmd != null)
                    cmd.Dispose();
                if (dbConn != null)
                    dbConn.Close();
            }

           
        }

        public string GetUserID(string username, string password)
        {
            string query = @"
        SELECT user_id 
        FROM kusinapp.user_login 
        WHERE LOWER(TRIM(username)) = LOWER(TRIM(@username)) 
          AND TRIM(password) = TRIM(@password)
        LIMIT 1;";

            string userId = string.Empty;

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

                        if (result != null)
                        {
                            userId = result.ToString();
                            // Optional: You can log or debug this if needed
                            // MessageBox.Show("User found: " + userId);
                        }
                        else
                        {
                            MessageBox.Show($"❌ No user found.\nUsername: {username}\nPassword: {password}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("⚠️ Database error: " + ex.Message);
            }

            return userId;
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
                dbConn.Open();
                using (var cmd = new MySqlCommand(insertQuery, dbConn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error executing non-query: " + ex.Message);
                throw;
            }
            finally
            {
                if (dbConn != null)
                    dbConn.Close();
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
