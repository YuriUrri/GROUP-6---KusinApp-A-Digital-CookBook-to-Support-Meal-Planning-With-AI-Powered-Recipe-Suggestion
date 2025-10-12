using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace KusinApp
{
    public partial class Inventory : Form
    {
        SQLHelper help = new SQLHelper();
        LoginPage login = new LoginPage();
        string sql = "";
        public Inventory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            DataGridViewRow selectedRow = inventoryDG.Rows[i];
            nameTextBox.Text = selectedRow.Cells[2].Value.ToString();
            quantityTextBox.Text = selectedRow.Cells[3].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage main = new MainPage();
            main.Show();
            this.Hide();
        }


        private void Inventory_Load_1(object sender, EventArgs e)
        {

            help.dbConnection();
            LoadUserInventory();


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
            inventoryDG.DataSource = dt;

            foreach (DataRow row in dt.Rows)
            {
                string name = row["ingredient_name"].ToString();
                string qty = row["ingredient_quantity"].ToString();

            }
        }




        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void inventorySearch_TextChanged(object sender, EventArgs e)
        {
            searchIngredient();
        }


        private void searchIngredient()
        {
            string searchTerm = inventorySearch.Text.Trim();
            string userID = login.GetID();
            if (string.IsNullOrEmpty(userID))
            {
                MessageBox.Show("User ID not found. Please log in again.");
                return;
            }
            DataTable dt = help.SearchUserInventory(userID, searchTerm);
            inventoryDG.DataSource = dt;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateInventory();
        }
        private void updateInventory()
        {
            sql = "UPDATE `user_inventory` SET" +
                $"`ingredient_name`='{nameTextBox.Text}'" +
                $",`ingredient_quantity`='{quantityTextBox};";
            help.SQLManager(sql);
            help.displayRecords("SELECT * FROM `user_inventory`",inventoryDG);
        }
    }
}
