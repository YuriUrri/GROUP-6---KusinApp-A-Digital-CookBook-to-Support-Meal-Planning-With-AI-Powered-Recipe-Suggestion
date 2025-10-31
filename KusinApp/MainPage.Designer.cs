using KusinApp;

namespace KusinApp
{
    partial class MainPage
    {

        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            itemList = new ListBox();
            label2 = new Label();
            recipeSuggestionBox = new ListView();
            RecipeNameDefaultPanel = new ColumnHeader();
            defaultPanel = new Panel();
            textBox1 = new TextBox();
            ingBox = new TextBox();
            addButton1 = new Button();
            ingIncrementer = new KusinApp.Services.IncrementerButton();
            label4 = new Label();
            searchPanel = new Panel();
            AIReccomendationView = new ListView();
            Recipes = new ColumnHeader();
            recipeListView = new ListView();
            recipeColumn = new ColumnHeader();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            searchBox = new TextBox();
            navBar1 = new KusinApp.Components.NavBar();
            logoutButton1 = new KusinApp.Components.LogoutButton();
            pictureBox2 = new PictureBox();
            defaultPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // itemList
            // 
            itemList.ForeColor = Color.FromArgb(0, 48, 73);
            itemList.FormattingEnabled = true;
            itemList.ItemHeight = 15;
            itemList.Location = new Point(24, 84);
            itemList.Name = "itemList";
            itemList.Size = new Size(292, 124);
            itemList.TabIndex = 7;
            itemList.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(23, 223);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 10;
            label2.Text = "Meals From Your Ingredients";
            label2.Click += label2_Click;
            // 
            // recipeSuggestionBox
            // 
            recipeSuggestionBox.Columns.AddRange(new ColumnHeader[] { RecipeNameDefaultPanel });
            recipeSuggestionBox.Font = new Font("Segoe UI", 9F);
            recipeSuggestionBox.ForeColor = Color.FromArgb(0, 48, 73);
            recipeSuggestionBox.FullRowSelect = true;
            recipeSuggestionBox.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            recipeSuggestionBox.Location = new Point(24, 249);
            recipeSuggestionBox.MultiSelect = false;
            recipeSuggestionBox.Name = "recipeSuggestionBox";
            recipeSuggestionBox.Size = new Size(292, 173);
            recipeSuggestionBox.TabIndex = 11;
            recipeSuggestionBox.UseCompatibleStateImageBehavior = false;
            recipeSuggestionBox.View = View.Details;
            recipeSuggestionBox.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // RecipeNameDefaultPanel
            // 
            RecipeNameDefaultPanel.Text = "Recipe name";
            RecipeNameDefaultPanel.Width = 500;
            // 
            // defaultPanel
            // 
            defaultPanel.Controls.Add(textBox1);
            defaultPanel.Controls.Add(ingBox);
            defaultPanel.Controls.Add(addButton1);
            defaultPanel.Controls.Add(ingIncrementer);
            defaultPanel.Controls.Add(recipeSuggestionBox);
            defaultPanel.Controls.Add(itemList);
            defaultPanel.Controls.Add(label4);
            defaultPanel.Controls.Add(label2);
            defaultPanel.Location = new Point(3, 132);
            defaultPanel.Margin = new Padding(2, 1, 2, 1);
            defaultPanel.Name = "defaultPanel";
            defaultPanel.Size = new Size(338, 429);
            defaultPanel.TabIndex = 14;
            // 
            // textBox1
            // 
            textBox1.ForeColor = Color.FromArgb(0, 48, 73);
            textBox1.Location = new Point(187, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(31, 23);
            textBox1.TabIndex = 24;
            textBox1.Text = "0";
            textBox1.TextAlign = HorizontalAlignment.Center;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // ingBox
            // 
            ingBox.Location = new Point(24, 48);
            ingBox.Name = "ingBox";
            ingBox.Size = new Size(157, 23);
            ingBox.TabIndex = 23;
            ingBox.TextChanged += ingBox_TextChanged_1;
            // 
            // addButton1
            // 
            addButton1.BackColor = Color.FromArgb(247, 127, 0);
            addButton1.FlatAppearance.BorderSize = 0;
            addButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            addButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            addButton1.FlatStyle = FlatStyle.Flat;
            addButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton1.ForeColor = Color.FromArgb(0, 48, 73);
            addButton1.Location = new Point(258, 48);
            addButton1.Name = "addButton1";
            addButton1.Size = new Size(59, 23);
            addButton1.TabIndex = 12;
            addButton1.Text = "ADD";
            addButton1.UseVisualStyleBackColor = false;
            addButton1.Click += roundedButton1_Click;
            // 
            // ingIncrementer
            // 
            ingIncrementer.ArrowColor = Color.White;
            ingIncrementer.BackColor = Color.Transparent;
            ingIncrementer.ButtonColor = Color.FromArgb(252, 191, 73);
            ingIncrementer.CornerRadius = 10;
            ingIncrementer.Location = new Point(224, 39);
            ingIncrementer.Name = "ingIncrementer";
            ingIncrementer.Size = new Size(28, 40);
            ingIncrementer.Step = 1;
            ingIncrementer.TabIndex = 14;
            ingIncrementer.Load += ingIncrementer_Load;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 48, 73);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(24, 15);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 8;
            label4.Text = "ADD INGREDIENTS";
            label4.Click += label4_Click;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(AIReccomendationView);
            searchPanel.Controls.Add(recipeListView);
            searchPanel.Controls.Add(label1);
            searchPanel.Controls.Add(label3);
            searchPanel.Location = new Point(373, 132);
            searchPanel.Margin = new Padding(2, 1, 2, 1);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(338, 429);
            searchPanel.TabIndex = 15;
            searchPanel.Visible = false;
            searchPanel.Paint += searchPanel_Paint;
            // 
            // AIReccomendationView
            // 
            AIReccomendationView.AccessibleName = "";
            AIReccomendationView.AllowColumnReorder = true;
            AIReccomendationView.BorderStyle = BorderStyle.None;
            AIReccomendationView.Columns.AddRange(new ColumnHeader[] { Recipes });
            AIReccomendationView.Font = new Font("Segoe UI", 9F);
            AIReccomendationView.ForeColor = Color.FromArgb(0, 48, 73);
            AIReccomendationView.FullRowSelect = true;
            AIReccomendationView.Location = new Point(22, 39);
            AIReccomendationView.MultiSelect = false;
            AIReccomendationView.Name = "AIReccomendationView";
            AIReccomendationView.Size = new Size(292, 148);
            AIReccomendationView.TabIndex = 13;
            AIReccomendationView.UseCompatibleStateImageBehavior = false;
            AIReccomendationView.View = View.Details;
            AIReccomendationView.SelectedIndexChanged += AIReccomendationView_SelectedIndexChanged;
            // 
            // Recipes
            // 
            Recipes.Text = "Recipe Name";
            Recipes.Width = 1000;
            // 
            // recipeListView
            // 
            recipeListView.BorderStyle = BorderStyle.None;
            recipeListView.Columns.AddRange(new ColumnHeader[] { recipeColumn });
            recipeListView.Cursor = Cursors.Hand;
            recipeListView.Font = new Font("Segoe UI", 9F);
            recipeListView.ForeColor = Color.FromArgb(0, 48, 73);
            recipeListView.FullRowSelect = true;
            recipeListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            recipeListView.HoverSelection = true;
            recipeListView.Location = new Point(22, 223);
            recipeListView.Name = "recipeListView";
            recipeListView.Size = new Size(292, 199);
            recipeListView.TabIndex = 14;
            recipeListView.UseCompatibleStateImageBehavior = false;
            recipeListView.View = View.Details;
            recipeListView.SelectedIndexChanged += recipeListView_SelectedIndexChanged;
            // 
            // recipeColumn
            // 
            recipeColumn.Text = "Recipe Name";
            recipeColumn.Width = 1000;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 48, 73);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(188, 21);
            label1.TabIndex = 12;
            label1.Text = "MEALS YOU MIGHT LIKE";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 48, 73);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(24, 192);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 10;
            label3.Text = "SUGGESTED MEALS";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(85, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(179, 61);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // searchBox
            // 
            searchBox.Location = new Point(62, 101);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search Recipes";
            searchBox.Size = new Size(257, 23);
            searchBox.TabIndex = 24;
            searchBox.TextChanged += searchBox_TextChanged_1;
            // 
            // navBar1
            // 
            navBar1.BackColor = Color.FromArgb(0, 48, 73);
            navBar1.Location = new Point(-7, 583);
            navBar1.Name = "navBar1";
            navBar1.Size = new Size(356, 77);
            navBar1.TabIndex = 25;
            navBar1.Load += navBar1_Load;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.Transparent;
            logoutButton1.Location = new Point(18, 35);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Size = new Size(38, 38);
            logoutButton1.TabIndex = 26;
            logoutButton1.Load += logoutButton1_Load;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 101);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(29, 24);
            pictureBox2.TabIndex = 27;
            pictureBox2.TabStop = false;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(722, 659);
            Controls.Add(pictureBox2);
            Controls.Add(logoutButton1);
            Controls.Add(navBar1);
            Controls.Add(searchBox);
            Controls.Add(pictureBox1);
            Controls.Add(searchPanel);
            Controls.Add(defaultPanel);
            ForeColor = Color.FromArgb(0, 48, 73);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            Click += MainPage_Click;
            defaultPanel.ResumeLayout(false);
            defaultPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox itemList;
        private Label label2;
        private ListView recipeSuggestionBox;
        private ImageList recipesImageList;
        private Panel defaultPanel;
        private Panel searchPanel;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button addButton1;
        private Services.IncrementerButton ingIncrementer;
        private Label label1;
        private ListView AIReccomendationView;
        public ListView recipeListView;
        private ColumnHeader recipeColumn;
        private TextBox ingBox;
        private ColumnHeader Recipes;
        private ColumnHeader RecipeNameDefaultPanel;
        private TextBox searchBox;
        private Components.NavBar navBar1;
        private Components.LogoutButton logoutButton1;
        private TextBox textBox1;
        private PictureBox pictureBox2;
    }
}
