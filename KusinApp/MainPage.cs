using KusinApp;
using MySql.Data.MySqlClient;
using System.Data;

namespace KusinApp
{
    public partial class MainPage : Form
    {
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string strConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=defaultdb;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";
        public MainPage()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserInventory();
            SetupAutoComplete();
            help.dbConnection();

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
            itemList.Items.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string name = row["ingredient_name"].ToString();
                string qty = row["ingredient_quantity"].ToString();
                itemList.Items.Add($"{qty} - {name}");
            }
        }


        private void SetupAutoComplete()
        {
            try
            {

                string query = "SELECT ingredient_name FROM ingredient_list";


                DataTable dt = help.displayRecords(query);

                if (dt == null || dt.Rows.Count == 0)
                {
                    MessageBox.Show("No ingredients found in the database.");
                    return;
                }


                AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["ingredient_name"] != DBNull.Value)
                        autoSource.Add(row["ingredient_name"].ToString());
                }


                ingBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                ingBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                ingBox.AutoCompleteCustomSource = autoSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading autocomplete: " + ex.Message);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            RecipeSearch recipe = new RecipeSearch();
            recipe.Show();
            this.Hide();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void button4_Click(object sender, EventArgs e)
        {
            string ingredient = ingBox.Text.Trim();
            string userID = help.GetUserID(login.GetUser(), login.GetPass());
            string quantity = ingCountIncrementer.Value.ToString();

            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User not found. Please log in again.");
                return;
            }

            if (quantity == "0")
            {
                MessageBox.Show("Please enter a quantity greater than zero.");
                return;
            }

            if (string.IsNullOrEmpty(ingredient))
            {
                MessageBox.Show("Please enter an ingredient name.");
                return;
            }


            string ingredientID = GetIngredientID(ingredient);

            if (string.IsNullOrEmpty(ingredientID))
            {
                MessageBox.Show($"The ingredient '{ingredient}' was not found.\nPlease select a valid ingredient.");
                return;
            }


            insertIngredient(ingredient, ingredientID, userID, quantity);
            LoadUserInventory();
        }


        private string GetIngredientID(string ingredientName)
        {
            string query = "SELECT ingredient_id FROM kusinapp.ingredient_list WHERE ingredient_name = @name LIMIT 1";
            string id = string.Empty;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", ingredientName);
                        object result = cmd.ExecuteScalar();
                        if (result != null)
                            id = result.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking ingredient: " + ex.Message);
            }

            return id;
        }
        private void insertIngredient(string ingredient, string ingredientID, string userID, string quantity)
        {
            string query = @"INSERT INTO kusinapp.user_inventory (user_id, ingredient_id, ingredient_name, ingredient_quantity) VALUES (@U_id, @I_id, @I_name, @I_quantity)";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@U_id", userID);
                        cmd.Parameters.AddWithValue("@I_name", ingredient);
                        cmd.Parameters.AddWithValue("@I_id", ingredientID);
                        cmd.Parameters.AddWithValue("@I_quantity", quantity);

                        cmd.ExecuteNonQuery();
                    }
                }


                ingBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding ingredient: " + ex.Message);
            }
        }


        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) //recipe suggestion box
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchBox.Text))
            {
                showDefault();
            }
            else
            {
                showPanel();
            }
            //plus actual search features
        }
        private void showPanel()
        {
            searchPanel.Visible = true;
            searchPanel.BringToFront();
            defaultPanel.Visible = false;
        }
        private void showDefault()
        {
            defaultPanel.Visible = true;
            defaultPanel.BringToFront();
            searchPanel.Visible = false;
        }
    }
}

