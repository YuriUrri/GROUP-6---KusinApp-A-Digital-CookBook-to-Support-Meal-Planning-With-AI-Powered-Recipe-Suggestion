namespace KusinApp
{
    partial class RecipeSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeSearch));
            listView1 = new ListView();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pbInventory = new PictureBox();
            pbRecipe = new PictureBox();
            pbHome = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbInventory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbRecipe).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.ForeColor = Color.FromArgb(0, 48, 73);
            listView1.Location = new Point(33, 183);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(280, 353);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(91, 29);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 73);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(33, 52);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(31, 33);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 48, 73);
            label1.Location = new Point(33, 133);
            label1.Name = "label1";
            label1.Size = new Size(196, 28);
            label1.TabIndex = 10;
            label1.Text = "PERSONAL RECIPES";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pbInventory
            // 
            pbInventory.BackColor = Color.FromArgb(0, 48, 73);
            pbInventory.Cursor = Cursors.Hand;
            pbInventory.Image = (Image)resources.GetObject("pbInventory.Image");
            pbInventory.Location = new Point(261, 528);
            pbInventory.Name = "pbInventory";
            pbInventory.Size = new Size(35, 33);
            pbInventory.SizeMode = PictureBoxSizeMode.AutoSize;
            pbInventory.TabIndex = 25;
            pbInventory.TabStop = false;
            pbInventory.Click += pbInventory_Click;
            // 
            // pbRecipe
            // 
            pbRecipe.BackColor = Color.FromArgb(0, 48, 73);
            pbRecipe.Cursor = Cursors.Hand;
            pbRecipe.Image = (Image)resources.GetObject("pbRecipe.Image");
            pbRecipe.Location = new Point(156, 528);
            pbRecipe.Name = "pbRecipe";
            pbRecipe.Size = new Size(35, 33);
            pbRecipe.SizeMode = PictureBoxSizeMode.AutoSize;
            pbRecipe.TabIndex = 24;
            pbRecipe.TabStop = false;
            pbRecipe.Click += pbRecipe_Click;
            // 
            // pbHome
            // 
            pbHome.BackColor = Color.FromArgb(0, 48, 73);
            pbHome.Cursor = Cursors.Hand;
            pbHome.Image = (Image)resources.GetObject("pbHome.Image");
            pbHome.Location = new Point(53, 528);
            pbHome.Name = "pbHome";
            pbHome.Size = new Size(35, 33);
            pbHome.SizeMode = PictureBoxSizeMode.AutoSize;
            pbHome.TabIndex = 23;
            pbHome.TabStop = false;
            pbHome.Click += pbHome_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-8, 506);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(415, 112);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // RecipeSearch
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(344, 578);
            Controls.Add(pbInventory);
            Controls.Add(pbRecipe);
            Controls.Add(pbHome);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(listView1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "RecipeSearch";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeSearch";
            Load += SearchRecipe_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbInventory).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbRecipe).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHome).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listView1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pbInventory;
        private PictureBox pbRecipe;
        private PictureBox pbHome;
        private PictureBox pictureBox3;
    }
}