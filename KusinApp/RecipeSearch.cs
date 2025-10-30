using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KusinApp
{
    public partial class RecipeSearch : Form
    {
        MainPage main = new MainPage();
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string strConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=defaultdb;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";
        public RecipeSearch()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SearchRecipe_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Recipe Name", 200);
            listView1.Columns.Add("Ingredients", 300);

            string userId = LoginPage.LoggedInId; // Logged-in user from LoginPage
            DataTable dt = help.GetUserRecipes(userId);

            listView1.Items.Clear();
            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row["recipe_name"].ToString());
                item.SubItems.Add(row["ingredients"].ToString());
                item.Tag = row; // store full row for later use
                listView1.Items.Add(item);
            }
        }


        private void pbHome_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void pbRecipe_Click(object sender, EventArgs e)
        {
            RecipeSearch recipe = new RecipeSearch();
            recipe.Show();
            this.Hide();
        }

        private void pbInventory_Click(object sender, EventArgs e)
        {
            Inventory inventory = new Inventory();
            inventory.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                // Get the selected recipe row
                DataRow row = (DataRow)listView1.SelectedItems[0].Tag;

                string recipeName = row["recipe_name"].ToString();
                string ingredients = row["ingredients"].ToString();
                string instructions = row["instructions"].ToString();

                // Example: display in TextBoxes or MessageBox
                MessageBox.Show(
                    $"🍳 Recipe: {recipeName}\n\nIngredients:\n{ingredients}\n\nInstructions:\n{instructions}",
                    "Recipe Details",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

    }
}
