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

        private void RecipeSearch_Load(object sender, EventArgs e)
        {
            help.dbConnection();


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
    }
}
