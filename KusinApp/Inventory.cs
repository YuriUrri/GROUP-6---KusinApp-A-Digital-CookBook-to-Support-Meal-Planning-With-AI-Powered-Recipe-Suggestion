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
using DotNetEnv;

namespace KusinApp
{
    public partial class Inventory : Form
    {
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string sql = "";
        string strConn;
        public Inventory()
        {
            InitializeComponent();
            Env.Load();
            strConn = Environment.GetEnvironmentVariable("DB_CONNECTION");
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
            invShowView.SelectedIndexChanged += invShowView_SelectedIndexChanged;

        }
        private void LoadUserInventory()
        {
            invShowView.Items.Clear();
            invShowView.Columns.Clear(); 

            string userID = login.GetID();
            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User ID not found. Please log in again.");
                return;
            }

            DataTable dt = help.GetUserInventory(userID);

            
            invShowView.View = View.Details;
            invShowView.FullRowSelect = true;
            invShowView.GridLines = true;
            invShowView.HideSelection = false;

            
            invShowView.Columns.Add("Ingredient", 180, HorizontalAlignment.Center);
            invShowView.Columns.Add("Quantity", 100, HorizontalAlignment.Center);

            
            foreach (DataRow row in dt.Rows)
            {
                string ingredient = row["ingredient_name"].ToString();
                string quantity = row["ingredient_quantity"].ToString();

                
                ListViewItem item = new ListViewItem(ingredient);
                item.SubItems.Add(quantity);

                invShowView.Items.Add(item);
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
            invShowView.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string ingredient = row["ingredient_name"].ToString();
                string quantity = row["ingredient_quantity"].ToString();

                ListViewItem item = new ListViewItem("");
                item.SubItems.Add(ingredient);
                item.SubItems.Add(quantity);
                invShowView.Items.Add(item);
            }
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
            nameTextBox.Clear();
            quantityTextBox.Clear();
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
                using (MySql.Data.MySqlClient.MySqlConnection conn =
                       new MySql.Data.MySqlClient.MySqlConnection(strConn))
                {
                    conn.Open();


                    string getIdQuery = "SELECT ingredient_id FROM ingredient_list WHERE ingredient_name = @name LIMIT 1";
                    using (MySql.Data.MySqlClient.MySqlCommand getIdCmd =
                           new MySql.Data.MySqlClient.MySqlCommand(getIdQuery, conn))
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


                    string updateQuery = @"UPDATE user_inventory 
                                   SET ingredient_name = @name, ingredient_quantity = @quantity 
                                   WHERE ingredient_id = @id AND user_id = @uid";

                    using (MySql.Data.MySqlClient.MySqlCommand updateCmd =
                           new MySql.Data.MySqlClient.MySqlCommand(updateQuery, conn))
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


                LoadUserInventory();

                nameTextBox.Clear();
                quantityTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating inventory: " + ex.Message);
            }
        }

        private void incrementerButton1_Load(object sender, EventArgs e)
        {
            incrementerButton1.ValueChanged += (s, val) =>
            {
                quantityTextBox.Text = val.ToString();
            };
        }

        private void invShowView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (invShowView.SelectedItems.Count > 0)
            {
                var selectedItem = invShowView.SelectedItems[0];

                nameTextBox.Text = selectedItem.SubItems[0].Text;   
                quantityTextBox.Text = selectedItem.SubItems[1].Text; 
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            deleteInventory();
        }

        private void deleteInventory()
        {
            string ingredientName = nameTextBox.Text.Trim();
            string userID = login.GetID();

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User not found. Please log in again.");
                return;
            }

            if (string.IsNullOrEmpty(ingredientName))
            {
                MessageBox.Show("Please select an ingredient to delete.");
                return;
            }

            try
            {
                DialogResult confirm = MessageBox.Show(
                    $"Are you sure you want to delete '{ingredientName}' from your inventory?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.No)
                    return;

                using (MySql.Data.MySqlClient.MySqlConnection conn =
                       new MySql.Data.MySqlClient.MySqlConnection(strConn))
                {
                    conn.Open();

                   
                    string getIdQuery = "SELECT ingredient_id FROM ingredient_list WHERE ingredient_name = @name LIMIT 1";
                    string ingredientID = "";

                    using (MySql.Data.MySqlClient.MySqlCommand getIdCmd =
                           new MySql.Data.MySqlClient.MySqlCommand(getIdQuery, conn))
                    {
                        getIdCmd.Parameters.AddWithValue("@name", ingredientName);
                        object result = getIdCmd.ExecuteScalar();

                        if (result == null)
                        {
                            MessageBox.Show("Ingredient not found in the database.");
                            return;
                        }

                        ingredientID = result.ToString();
                    }

                    
                    string deleteQuery = "DELETE FROM user_inventory WHERE ingredient_id = @id AND user_id = @uid";

                    using (MySql.Data.MySqlClient.MySqlCommand deleteCmd =
                           new MySql.Data.MySqlClient.MySqlCommand(deleteQuery, conn))
                    {
                        deleteCmd.Parameters.AddWithValue("@id", ingredientID);
                        deleteCmd.Parameters.AddWithValue("@uid", userID);

                        int rowsAffected = deleteCmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                            MessageBox.Show("Ingredient deleted successfully!");
                        else
                            MessageBox.Show("No matching ingredient found to delete.");
                    }
                }

                LoadUserInventory();
                nameTextBox.Clear();
                quantityTextBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting ingredient: " + ex.Message);
            }
        }

    }
}

