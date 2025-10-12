using KusinApp;
using MySql.Data.MySqlClient;
using System.Data;

namespace KusinApp
{
    public partial class MainPage : Form
    {
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string strConn = "server=127.0.0.1;uid=root;pwd=;database=kusinapp;";
        public MainPage()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupAutoComplete();
        }

        private void SetupAutoComplete()
        {
            try
            {
                string query = "SELECT `ingredient_id`, `ingredient_name` FROM `ingredient_list`";

                DataTable dt = help.displayRecords(query);

                AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();

                foreach (DataRow row in dt.Rows)
                {
                    autoSource.Add(row["ingredient_name"].ToString());
                    autoSource.Add(row["ingredient_id"].ToString());
                }

                searchBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                searchBox.AutoCompleteSource = AutoCompleteSource.CustomSource;
                searchBox.AutoCompleteCustomSource = autoSource;
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

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }





        private void button4_Click(object sender, EventArgs e)
        {

            string ingredient = searchBox.Text.Trim();
            string userID = help.GetUserID(login.GetUser(), login.GetPass());
            string quantity = ingCountIncrementer.Value.ToString();

            if (!string.IsNullOrEmpty(ingredient))
            {
                string ingredientID = GetIngredientID(ingredient);

                insertIngredient(ingredient, ingredientID, userID, quantity);
                itemList.Items.Add($"{quantity} - {ingredient}");

            }
            else
            {
                MessageBox.Show("Please enter an ingredient name.");
            }

        }

        private string GetIngredientID(string ingredientName)
        {
            string query = "SELECT ingredient_id FROM ingredient_list WHERE ingredient_name = @name LIMIT 1";
            string id = "";

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

            return id;
        }
        private void insertIngredient(string ingredient, string ingredientID, string userID, string quantity)
        {
            string query = "INSERT INTO `user_inventory`(`user_id`,`ingredient_id`, `ingredient_name`, `ingredient_quantity`)" +
                " VALUES (@U_id,@I_id,@I_name,@I_quantity)";
            MySqlConnection conn = new MySqlConnection(strConn);
            try
            {

                conn.Open();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@U_id", userID);
                cmd.Parameters.AddWithValue("@I_name", ingredient);
                cmd.Parameters.AddWithValue("@I_id", ingredientID);
                cmd.Parameters.AddWithValue("@I_quantity", quantity);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ingredient added successfully!");
                searchBox.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding ingredient: " + ex.Message);
            }
            finally
            {
                conn.Close();
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
    }
}

