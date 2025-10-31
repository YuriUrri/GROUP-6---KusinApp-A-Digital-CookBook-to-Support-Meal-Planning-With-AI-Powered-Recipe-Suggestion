using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;
using System.Drawing;

namespace KusinApp
{
    public partial class LoginPage : Form
    {
        SQLHelper help = new SQLHelper();
        string SQL = "";
        public static string LoggedInUser { get; private set; }
        public static string LoggedInPass { get; private set; }
        public static string LoggedInId { get; private set; }

        public LoginPage()
        {
            InitializeComponent();
            help.dbConnection();
            this.AcceptButton = loginButton;
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {

                MessageBox.Show("Please enter both username and password.", "Input Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            try
            {
                if (help.ValidateLogin(username, password))
                {
                    LoggedInUser = username;
                    LoggedInPass = password;
                    LoggedInId = help.GetUserID(username, password);

                    MainPage mainForm = new MainPage();
                    mainForm.Show();
                    this.DialogResult = DialogResult.OK;
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string GetID()
        {
            return LoggedInId;
        }
        public string GetUser()
        {
            return LoggedInUser;
        }
        public string GetPass()
        {
            return LoggedInPass;
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            ShowPanel();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void ShowPanel()
        {
            int targetHeight = 379;
            int radius = 20;


            panel1.Visible = true;
            panel1.Height = targetHeight;
            panel1.Top = this.ClientSize.Height;

            int targetTop = this.ClientSize.Height - targetHeight;
            int step = 20;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1 };
            timer.Tick += (s, e) =>
            {
                if (panel1.Top > targetTop)
                {
                    panel1.Top -= step;

                    var path = new System.Drawing.Drawing2D.GraphicsPath();
                    path.AddArc(0, 0, radius, radius, 180, 90);
                    path.AddArc(panel1.Width - radius, 0, radius, radius, 270, 90);
                    path.AddArc(panel1.Width - radius, panel1.Height - radius, radius, radius, 0, 90);
                    path.AddArc(0, panel1.Height - radius, radius, radius, 90, 90);
                    path.CloseAllFigures();
                    panel1.Region = new Region(path);
                }
                else
                {
                    timer.Stop();
                }
            };
            timer.Start();
        }

        public void HidePanel()
        {
            int targetHeight = 379;
            int step = 20;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer { Interval = 1 };
            timer.Tick += (s, e) =>
            {
                if (panel1.Top < this.ClientSize.Height)
                {
                    panel1.Top += step;
                }
                else
                {
                    timer.Stop();
                    panel1.Visible = false;
                }
            };
            timer.Start();
        }

        private void roundedTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void roundedTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
