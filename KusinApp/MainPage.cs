using DotNetEnv;
using KusinApp;
using MySql.Data.MySqlClient;
using System.Data;

namespace KusinApp
{
    public partial class MainPage : Form
    {
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        aiHelper aiHelper = new aiHelper();
        string strConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=defaultdb;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";
        public MainPage()
        {
            InitializeComponent();
        }

        private Panel lastActivePanel;
        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserInventory();
            SetupAutoComplete();
            help.dbConnection();
            LoadRecipes();
            aiHelper.aiSuggest(recipeSuggestionBox);
        }

        /**LoadRecipes @param searchTerm - method with optional search term
         * 
         * Displays recipes from the database into the list view.
         * 
         */
        private void LoadRecipes(string searchTerm = "")
        {
            string query = string.IsNullOrWhiteSpace(searchTerm)
                ? "SELECT recipe_id, recipe_name, recipe_ingredient_list, recipe_steps FROM kusinapp.recipe_list"
                : "SELECT recipe_id, recipe_name, recipe_ingredient_list, recipe_steps FROM kusinapp.recipe_list WHERE recipe_name LIKE @search OR recipe_ingredient_list LIKE @search";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrWhiteSpace(searchTerm))
                            cmd.Parameters.AddWithValue("@search", "%" + searchTerm + "%");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            recipeListView.Items.Clear();

                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["recipe_name"].ToString());
                                item.SubItems.Add(reader["recipe_ingredient_list"].ToString());
                                item.SubItems.Add(reader["recipe_steps"].ToString());
                                item.Tag = reader["recipe_id"]; // store ID
                                recipeListView.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recipes: " + ex.Message);
            }
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


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button3_Click(object sender, EventArgs e)
        {
            PersonalRecipe recipe = new PersonalRecipe();
            recipe.Show();
            this.Hide();

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
                LoadRecipes(searchBox.Text.Trim());
                aiHelper.aiSuggest(AIReccomendationView);
            }

        }
        private void showPanel()
        {
            lastActivePanel = defaultPanel;
            searchPanel.Visible = true;
            searchPanel.BringToFront();
            defaultPanel.Visible = false;
        }
        private void showDefault()
        {
            defaultPanel.Visible = true;
            defaultPanel.BringToFront();
            searchPanel.Visible = false;
            ingBox.BringToFront();

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void roundedButton1_Click(object sender, EventArgs e)
        {
            string ingredient = ingBox.Text.Trim();
            string userID = help.GetUserID(login.GetUser(), login.GetPass());
            string quantity = ingIncrementer.Value.ToString();

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

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void searchPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Inventory inv = new Inventory();
            inv.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PersonalRecipe recipe = new PersonalRecipe();
            recipe.Show();
            this.Hide();
        }



        private void ingIncrementer_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ingBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipeListView.SelectedItems.Count == 0)
                return;

            ListViewItem selected = recipeListView.SelectedItems[0];
            string recipeName = selected.SubItems[0].Text;
            string ingredients = selected.SubItems[1].Text;
            string steps = selected.SubItems[2].Text;

            ShowRecipeDetails(recipeName, ingredients, steps);
        }

        private void ShowRecipeDetails(string name, string ingredients, string steps)
        {
            
        }

        public void recipeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (recipeListView.SelectedItems.Count == 0)
                return;

            // get selected recipe
            ListViewItem selected = recipeListView.SelectedItems[0];
            string recipeName = selected.SubItems[0].Text;
            string ingredients = selected.SubItems[1].Text;
            string steps = selected.SubItems[2].Text;

            // open RecipeDisplay form with details
            RecipeDisplay display = new RecipeDisplay(recipeName, ingredients, steps);
            display.Show();

            this.Hide();


        }

        private void recipeDetailPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void recipeDetailPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void recipeNameLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

