using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace KusinApp
{
    public partial class Inventory : Form
    {
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string sql = "";
        string strConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=kusinapp;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";
        public Inventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int i = e.RowIndex;
                DataGridViewRow selectedRow = inventoryDG.Rows[i];
                nameTextBox.Text = selectedRow.Cells[2].Value.ToString();
                quantityTextBox.Text = selectedRow.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }


        private void Inventory_Load_1(object sender, EventArgs e)
        {

            help.dbConnection();
            LoadUserInventory();
            


        }
        private void LoadUserInventory()
        {
            string userID = login.GetID();
            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User ID not found. Please log in again.");
                return;
            }

            DataTable dt = help.GetUserInventory(userID);
            inventoryDG.DataSource = dt;

            foreach (DataRow row in dt.Rows)
            {
                string name = row["ingredient_name"].ToString();
                string qty = row["ingredient_quantity"].ToString();

            }
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void inventorySearch_TextChanged(object sender, EventArgs e)
        {
            searchIngredient();
        }

        
        private void searchIngredient()
        {
            string searchTerm = inventorySearch.Text.Trim();
            string userID = login.GetID();
            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User ID not found. Please log in again.");
                return;
            }
            DataTable dt = help.SearchUserInventory(userID, searchTerm);
            inventoryDG.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateInventory();
        }

        private void updateInventory()
        {
            
            if (string.IsNullOrWhiteSpace(quantityTextBox.Text) ||
                !int.TryParse(quantityTextBox.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Please enter a valid non-negative integer for quantity.");
                return;
            }

            if (string.IsNullOrWhiteSpace(nameTextBox.Text))
            {
                MessageBox.Show("Please enter or select an ingredient name.");
                return;
            }

            string ingredientName = nameTextBox.Text.Trim();
            string ingredientID = "";
            string userID = login.GetID();

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User not found. Please log in again.");
                return;
            }

            try
            {
                using (MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(strConn))
                {
                    conn.Open();

                    
                    string getIdQuery = "SELECT ingredient_id FROM ingredient_list WHERE ingredient_name = @name LIMIT 1";
                    using (MySql.Data.MySqlClient.MySqlCommand getIdCmd = new MySql.Data.MySqlClient.MySqlCommand(getIdQuery, conn))
                    {
                        getIdCmd.Parameters.AddWithValue("@name", ingredientName);
                        object result = getIdCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Ingredient not found in the database. Please check the name.");
                            return;
                        }

                        ingredientID = result.ToString();
                    }

                    
                    string updateQuery = "UPDATE user_inventory " +
                                         "SET ingredient_name = @name, ingredient_quantity = @quantity " +
                                         "WHERE ingredient_id = @id AND user_id = @uid";

                    using (MySql.Data.MySqlClient.MySqlCommand updateCmd = new MySql.Data.MySqlClient.MySqlCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.AddWithValue("@name", ingredientName);
                        updateCmd.Parameters.AddWithValue("@quantity", quantity);
                        updateCmd.Parameters.AddWithValue("@id", ingredientID);
                        updateCmd.Parameters.AddWithValue("@uid", userID);
                        int rowsAffected = updateCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Inventory updated successfully!");
                        else
                            MessageBox.Show("No matching inventory item found for update.");
                    }
                }

                help.displayRecords("SELECT * FROM user_inventory", inventoryDG);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory: " + ex.Message);
            }
        }


    }

}

