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
        private Panel lastActivePanel;

        private readonly string strConn;
        public MainPage()
        {
            InitializeComponent();
            Env.Load();
            strConn = Environment.GetEnvironmentVariable("DB_CONNECTION");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadUserInventory();
            SetupAutoComplete();
            help.dbConnection();
            LoadRecipes();
            //aiHelper.aiSuggest(recipeSuggestionBox);

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
                string query = "SELECT ingredient_name FROM kusinapp.ingredient_list";

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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e) 
        {
            if (recipeSuggestionBox.SelectedItems.Count > 0)
            {
                searchBox.Text = recipeSuggestionBox.SelectedItems[0].Text;
                
            }
        }

        private void showPanel()
        {
            if (!searchPanel.Visible)
            {
                searchPanel.Visible = true;
                defaultPanel.Visible = false;
                searchPanel.BringToFront();
            }
        }
        private void showDefault()
        {
           if (!defaultPanel.Visible)
           {
                defaultPanel.Visible = true;
                searchPanel.Visible = false;
                defaultPanel.BringToFront();
           }
            ingBox.BringToFront();
            ingBox.Focus();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
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
            ingBox.Clear();
            textBox1.Clear();
        }

        public void recipeListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            listViewClick((ListView)sender);
        }

        public void listViewClick(ListView listview)
        {
            if (listview.SelectedItems.Count == 0)
                return;

            ListViewItem selected = listview.SelectedItems[0];
            string recipeName = selected.SubItems[0].Text;
            string ingredients = "";
            string steps = "";

            // Check which listview triggered this
            if (listview == recipeListView)
            {
                // Normal database recipes (3 columns)
                if (selected.SubItems.Count > 1)
                    ingredients = selected.SubItems[1].Text;

                if (selected.SubItems.Count > 2)
                    steps = selected.SubItems[2].Text;
            }

            // Open the recipe display window (or panel)
            RecipeDisplay display = new RecipeDisplay(recipeName, ingredients, steps);
            display.Show();

            this.Hide();
        }

        private void AIReccomendationView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AIReccomendationView.SelectedItems.Count > 0)
            {
                searchBox.Text = AIReccomendationView.SelectedItems[0].Text;
            }
        }

        private void MainPage_Click(object sender, EventArgs e)
        {
            recipeListView.SelectedItems.Clear();
            recipeSuggestionBox.SelectedItems.Clear();
        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text))
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

        private void ingBox_TextChanged_1(object sender, EventArgs e)
        {
            ingIncrementer.ValueChanged += (s, val) =>
            {
                textBox1.Text = val.ToString();
            };
        }


        private void roundedTextBox1_TextChanged(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void searchPanel_Paint(object sender, PaintEventArgs e) { }
        private void ingIncrementer_Load(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }
        private void ingBox_TextChanged(object sender, EventArgs e) { }
        private void ShowRecipeDetails(string name, string ingredients, string steps) { }
        private void navBar1_Load(object sender, EventArgs e) { }
        private void logoutButton1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void searchBox_TextChanged(object sender, EventArgs e) { }
        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label4_Click(object sender, EventArgs e) { }
        private void button2_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}

