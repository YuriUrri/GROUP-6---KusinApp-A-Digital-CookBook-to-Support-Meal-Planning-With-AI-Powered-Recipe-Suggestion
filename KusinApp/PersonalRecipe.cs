using DotNetEnv;
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KusinApp
{
    public partial class PersonalRecipe : Form
    {
        MainPage main = new MainPage();
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string strConn;

        public PersonalRecipe()
        {
            InitializeComponent();
            Env.Load();
            strConn = Environment.GetEnvironmentVariable("DB_CONNECTION");

            if (string.IsNullOrEmpty(strConn))
            {
                MessageBox.Show("Database connection string is missing. Check your .env file.");
                return;
            }
            LoadUserRecipes();
            LoadPersonalRecipes();
        }

        private void LoadUserRecipes()
        {
            string userId = help.GetUserID(login.GetUser(), login.GetPass());
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("User not found. Please log in again.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "SELECT personal_recipe_name, personal_recipe_ingredients, personal_recipe_steps " +
                                   "FROM kusinapp.personal_recipe WHERE user_id = @userId";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        using (var reader = cmd.ExecuteReader())
                        {
                            showPersonalRecipeView.Items.Clear();
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader["personal_recipe_name"].ToString());
                                item.SubItems.Add(reader["personal_recipe_ingredients"].ToString());
                                item.SubItems.Add(reader["personal_recipe_steps"].ToString());
                                showPersonalRecipeView.Items.Add(item);
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
        private void LoadPersonalRecipes()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = "SELECT personal_recipe_name FROM kusinapp.personal_recipe WHERE user_id = @user_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user_id", login.GetID());

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            showPersonalRecipeView.Items.Clear();

                            while (reader.Read())
                            {
                                string recipeTitle = reader["personal_recipe_name"].ToString();
                                ListViewItem item = new ListViewItem(recipeTitle);
                                showPersonalRecipeView.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading personal recipes: " + ex.Message);
            }
        }

        private void inputRecipeBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = true;

                    int stepCount = inputRecipeBox.Lines.Count(line => line.StartsWith("Step"));

                    inputRecipeBox.AppendText($"\r\nStep {stepCount + 1}:\r\n   ");

                    inputRecipeBox.SelectionStart = inputRecipeBox.Text.Length;
                }
                else if (e.KeyCode != Keys.Left && e.KeyCode != Keys.Right && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down)
                {
                    int currentLine = inputRecipeBox.GetLineFromCharIndex(inputRecipeBox.SelectionStart);
                    string lineText = inputRecipeBox.Lines[currentLine];

                    if (lineText.StartsWith("Step"))
                    {
                        e.SuppressKeyPress = true;
                        inputRecipeBox.SelectionStart = inputRecipeBox.Text.Length;
                    }
                }
            }
            catch (Exception ex)
            {
                return;
            }

        }

        private void addRecipeButton_Click(object sender, EventArgs e)
        {
            string userId = help.GetUserID(login.GetUser(), login.GetPass());
            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("User not found. Please log in again.");
                return;
            }

            string title = titleBox.Text.Trim();
            string ingredients = ingredientInputBox.Text.Trim();
            string steps = inputRecipeBox.Text.Trim();

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(ingredients) || string.IsNullOrEmpty(steps))
            {
                MessageBox.Show("Please fill in all fields before adding a recipe.");
                return;
            }

            try
            {
                using (var conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = @"INSERT INTO kusinapp.personal_recipe 
                                    (user_id, personal_recipe_name, personal_recipe_ingredients, personal_recipe_steps) 
                                    VALUES (@userId, @name, @ingredients, @steps)";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);
                        cmd.Parameters.AddWithValue("@name", title);
                        cmd.Parameters.AddWithValue("@ingredients", ingredients);
                        cmd.Parameters.AddWithValue("@steps", steps);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Recipe added successfully!");
                LoadUserRecipes();
                ClearInputBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding recipe: " + ex.Message);
            }
        }

        private void deleteRecipeButton_Click(object sender, EventArgs e)
        {
            string userId = help.GetUserID(login.GetUser(), login.GetPass());
            string selectedRecipe = titleShowBox.Text.Trim();

            if (string.IsNullOrEmpty(userId))
            {
                MessageBox.Show("User not found. Please log in again.");
                return;
            }

            if (string.IsNullOrEmpty(selectedRecipe))
            {
                MessageBox.Show("Please select a recipe to delete.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete '{selectedRecipe}'?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var conn = new MySqlConnection(strConn))
                    {
                        conn.Open();
                        string query = "DELETE FROM kusinapp.personal_recipe WHERE user_id = @userId AND personal_recipe_name = @name";
                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@userId", userId);
                            cmd.Parameters.AddWithValue("@name", selectedRecipe);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Recipe deleted successfully!");
                    LoadUserRecipes();
                    LoadPersonalRecipes();
                    titleShowBox.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting recipe: " + ex.Message);
                }
            }
        }

        private void ClearInputBoxes()
        {
            titleBox.Clear();
            ingredientInputBox.Clear();
            inputRecipeBox.Clear();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (showPersonalRecipeView.SelectedItems.Count == 0)
                return;


            string selectedTitle = showPersonalRecipeView.SelectedItems[0].Text;


            titleShowBox.Text = selectedTitle;
        }
        private void selectButton_Click(object sender, EventArgs e)
        {
            string selectedTitle = titleShowBox.Text.Trim();
            string userId = help.GetUserID(login.GetUser(), login.GetPass());

            if (string.IsNullOrEmpty(selectedTitle))
            {
                MessageBox.Show("Please select a recipe from the list first.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string query = @"SELECT personal_recipe_ingredients, personal_recipe_steps 
                             FROM kusinapp.personal_recipe 
                             WHERE personal_recipe_name = @name AND user_id = @user_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@name", selectedTitle);
                        cmd.Parameters.AddWithValue("@user_id", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                titleBox.Text = selectedTitle;
                                ingredientInputBox.Text = reader["personal_recipe_ingredients"].ToString();
                                inputRecipeBox.Text = reader["personal_recipe_steps"].ToString();

                                inputRecipePanel.BringToFront();
                            }
                            else
                            {
                                MessageBox.Show("Recipe not found or doesn't belong to this user.");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading recipe details: " + ex.Message);
            }
        }

        private void viewRecipesButton_Click(object sender, EventArgs e)
        {
            showRecipePanel.BringToFront();
            showRecipePanel.Visible = true;
            titleBox.Clear();
            inputRecipeBox.Text = "Step 1:\r\n   ";
            inputRecipeBox.SelectionStart = inputRecipeBox.Text.Length;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            inputRecipePanel.BringToFront();
            inputRecipePanel.Visible = true;
        }


        private void updateButton_Click_1(object sender, EventArgs e)
        {
            string userID = help.GetUserID(login.GetUser(), login.GetPass());
            string originalName = titleShowBox.Text.Trim(); // the recipe currently selected
            string title = titleBox.Text.Trim();
            string ingredients = ingredientInputBox.Text.Trim();
            string steps = inputRecipeBox.Text.Trim();

            try
            {
                using (var conn = new MySqlConnection(strConn))
                {
                    conn.Open();
                    string sql = @"UPDATE kusinapp.personal_recipe 
                           SET personal_recipe_name = @name,
                               personal_recipe_ingredients = @ingredients,
                               personal_recipe_steps = @steps
                           WHERE user_id = @userID AND personal_recipe_name = @originalName";

                    using (var cmd = new MySqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);
                        cmd.Parameters.AddWithValue("@originalName", originalName);
                        cmd.Parameters.AddWithValue("@name", title);
                        cmd.Parameters.AddWithValue("@ingredients", ingredients);
                        cmd.Parameters.AddWithValue("@steps", steps);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Recipe updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating recipe: " + ex.Message);
            }

            LoadPersonalRecipes();
            LoadUserRecipes();
        }

        private void ingredientInputBox_TextChanged(object sender, EventArgs e) { }
        private void titleBox_TextChanged(object sender, EventArgs e) { }
        private void textBox1_TextChanged_1(object sender, EventArgs e) { }
        private void button1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e) { }
        private void button3_Click(object sender, EventArgs e) { }
        private void RecipeSearch_Load(object sender, EventArgs e) { }
        private void navBar1_Load(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
    }
}
