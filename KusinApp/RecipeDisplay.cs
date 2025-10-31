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
            AdjustRecipeLayout();
        }

        private void AdjustRecipeLayout()
        {
            int padding = 10;
            int panelWidth = recipeDetailPanel.ClientSize.Width - 2 * padding;

            recipeNameLabel.MaximumSize = new Size(panelWidth, 0);
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Location = new Point(padding, padding);

            recipeIngredientsLabel.MaximumSize = new Size(panelWidth, 0);
            recipeIngredientsLabel.AutoSize = true;
            recipeIngredientsLabel.Location = new Point(padding, recipeNameLabel.Bottom + padding);

            recipeStepsLabel.MaximumSize = new Size(panelWidth, 0);
            recipeStepsLabel.AutoSize = true;
            recipeStepsLabel.Location = new Point(padding, recipeIngredientsLabel.Bottom + padding);

            int totalContentHeight = recipeStepsLabel.Bottom + padding;
            recipeDetailPanel.AutoScrollMinSize = new Size(0, totalContentHeight);
        }
    }
}