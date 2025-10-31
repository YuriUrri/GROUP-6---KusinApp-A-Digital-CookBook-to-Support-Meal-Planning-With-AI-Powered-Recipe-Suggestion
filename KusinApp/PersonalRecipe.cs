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
using DotNetEnv;

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

        }

        private void navBar1_Load(object sender, EventArgs e)
        {

        }
    }
}
