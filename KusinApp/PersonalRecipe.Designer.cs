namespace KusinApp
{
    partial class PersonalRecipe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalRecipe));
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            logoutButton1 = new KusinApp.Components.LogoutButton();
            navBar1 = new KusinApp.Components.NavBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.BorderStyle = BorderStyle.None;
            listView1.ForeColor = Color.FromArgb(0, 48, 73);
            listView1.Location = new Point(29, 137);
            listView1.Name = "listView1";
            listView1.Size = new Size(280, 411);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 65);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 48, 73);
            label1.Location = new Point(29, 100);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 10;
            label1.Text = "PERSONAL RECIPES";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.Transparent;
            logoutButton1.Location = new Point(29, 33);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Size = new Size(38, 38);
            logoutButton1.TabIndex = 11;
            // 
            // navBar1
            // 
            navBar1.BackColor = Color.FromArgb(0, 48, 73);
            navBar1.Location = new Point(-4, 579);
            navBar1.Name = "navBar1";
            navBar1.Size = new Size(354, 82);
            navBar1.TabIndex = 12;
            navBar1.Load += navBar1_Load;
            // 
            // PersonalRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(344, 659);
            Controls.Add(navBar1);
            Controls.Add(logoutButton1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalRecipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeSearch";
            Load += RecipeSearch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private PictureBox pictureBox1;
        private Label label1;
        private Components.LogoutButton logoutButton1;
        private Components.NavBar navBar1;
    }
}