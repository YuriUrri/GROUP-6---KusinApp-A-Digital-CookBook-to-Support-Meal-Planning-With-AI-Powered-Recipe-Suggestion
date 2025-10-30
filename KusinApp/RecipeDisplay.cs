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
using System.Xml.Linq;

namespace KusinApp
{
    public partial class RecipeDisplay : Form
    {

        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string strConn = "Server=mysql-579981-urrijehan1-5156.b.aivencloud.com;Port=17519;Database=defaultdb;Uid=avnadmin;Pwd=AVNS_k5T1-B2oaaNzDgSDamX;SslMode=Required;";

        private string recipeName;
        private string recipeIngredients;
        private string recipeSteps;
        public RecipeDisplay(string name, string ingredients, string steps)
        {
            InitializeComponent();


            recipeName = name;
            recipeIngredients = ingredients;
            recipeSteps = steps;
        }

        private void RecipeDisplay_Load(object sender, EventArgs e)
        {
            recipeNameLabel.Text = recipeName;
            recipeIngredientsLabel.Text = recipeIngredients;
            recipeStepsLabel.Text = recipeSteps;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            mainPage.Show();
            this.Hide();
        }

        private void recipeIngredientsLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
