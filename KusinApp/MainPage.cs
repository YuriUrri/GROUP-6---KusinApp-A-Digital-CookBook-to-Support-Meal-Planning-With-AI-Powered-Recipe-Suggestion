using KusinApp;
using MySql.Data.MySqlClient;
using System.Data;

namespace KusinApp
{
    public partial class MainPage : Form
    {
        SQLHelper db = new SQLHelper();
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

                DataTable dt = db.displayRecords(query);

                AutoCompleteStringCollection autoSource = new AutoCompleteStringCollection();

                foreach (DataRow row in dt.Rows)
                {
                    autoSource.Add(row["ingredient_name"].ToString());
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

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
    }
}

