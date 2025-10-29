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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            SearchRecipeButton = new KusinApp.Services.RoundedButton();
            itemList = new ListBox();
            label2 = new Label();
            recipeSuggestionBox = new ListView();
            defaultPanel = new Panel();
            ingBox = new TextBox();
            addButton1 = new KusinApp.Services.RoundedButton();
            ingIncrementer = new KusinApp.Services.IncrementerButton();
            label4 = new Label();
            searchBox = new KusinApp.Services.RoundedTextBox();
            searchPanel = new Panel();
            AIReccomendationView = new ListView();
            recipeListView = new ListView();
            recipeColumn = new ColumnHeader();
            label1 = new Label();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            defaultPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // SearchRecipeButton
            // 
            SearchRecipeButton.BackColor = Color.FromArgb(247, 127, 0);
            SearchRecipeButton.CornerRadius = 15;
            SearchRecipeButton.FlatStyle = FlatStyle.Flat;
            SearchRecipeButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            SearchRecipeButton.ForeColor = Color.FromArgb(0, 48, 73);
            SearchRecipeButton.Location = new Point(240, 101);
            SearchRecipeButton.Name = "SearchRecipeButton";
            SearchRecipeButton.Size = new Size(79, 23);
            SearchRecipeButton.TabIndex = 4;
            SearchRecipeButton.Text = "SEARCH";
            SearchRecipeButton.UseVisualStyleBackColor = true;
            SearchRecipeButton.Click += button3_Click;
            // 
            // itemList
            // 
            itemList.FormattingEnabled = true;
            itemList.ItemHeight = 15;
            itemList.Location = new Point(13, 69);
            itemList.Name = "itemList";
            itemList.Size = new Size(320, 109);
            itemList.TabIndex = 7;
            itemList.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(13, 190);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 10;
            label2.Text = "Meals From Your Ingredients";
            label2.Click += label2_Click;
            // 
            // recipeSuggestionBox
            // 
            recipeSuggestionBox.Location = new Point(13, 216);
            recipeSuggestionBox.Name = "recipeSuggestionBox";
            recipeSuggestionBox.Size = new Size(320, 137);
            recipeSuggestionBox.TabIndex = 11;
            recipeSuggestionBox.UseCompatibleStateImageBehavior = false;
            recipeSuggestionBox.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // defaultPanel
            // 
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
            defaultPanel.Size = new Size(338, 365);
            defaultPanel.TabIndex = 14;
            // 
            // ingBox
            // 
            ingBox.Location = new Point(13, 39);
            ingBox.Name = "ingBox";
            ingBox.Size = new Size(193, 23);
            ingBox.TabIndex = 22;
            ingBox.TextChanged += ingBox_TextChanged;
            // 
            // addButton1
            // 
            addButton1.BackColor = Color.FromArgb(247, 127, 0);
            addButton1.CornerRadius = 15;
            addButton1.FlatAppearance.BorderSize = 0;
            addButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            addButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            addButton1.FlatStyle = FlatStyle.Flat;
            addButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addButton1.ForeColor = Color.FromArgb(0, 48, 73);
            addButton1.Location = new Point(246, 39);
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
            ingIncrementer.Location = new Point(212, 23);
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
            label4.Location = new Point(13, 15);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 8;
            label4.Text = "ADD INGREDIENTS";
            label4.Click += label4_Click;
            // 
            // searchBox
            // 
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.BorderStyle = BorderStyle.None;
            searchBox.CornerRadius = 10;
            searchBox.ForeColor = Color.Gray;
            searchBox.LeftMargin = 20;
            searchBox.Location = new Point(27, 101);
            searchBox.Multiline = true;
            searchBox.Name = "searchBox";
            searchBox.PlaceholderColor = Color.Gray;
            searchBox.PlaceholderText = "Search Recipes";
            searchBox.Size = new Size(207, 23);
            searchBox.TabIndex = 14;
            searchBox.Text = "Search Recipes";
            searchBox.TopPadding = 10;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(AIReccomendationView);
            searchPanel.Controls.Add(recipeListView);
            searchPanel.Controls.Add(label1);
            searchPanel.Controls.Add(label3);
            searchPanel.Location = new Point(3, 132);
            searchPanel.Margin = new Padding(2, 1, 2, 1);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(338, 432);
            searchPanel.TabIndex = 15;
            searchPanel.Visible = false;
            searchPanel.Paint += searchPanel_Paint;
            // 
            // AIReccomendationView
            // 
            AIReccomendationView.Location = new Point(24, 69);
            AIReccomendationView.Name = "AIReccomendationView";
            AIReccomendationView.Size = new Size(292, 109);
            AIReccomendationView.TabIndex = 13;
            AIReccomendationView.UseCompatibleStateImageBehavior = false;
            // 
            // recipeListView
            // 
            recipeListView.Columns.AddRange(new ColumnHeader[] { recipeColumn });
            recipeListView.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recipeListView.FullRowSelect = true;
            recipeListView.Location = new Point(24, 216);
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
            label1.Location = new Point(24, 45);
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
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 38);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 29);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-8, 580);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(363, 84);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(0, 48, 73);
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(53, 602);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 33);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(0, 48, 73);
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(156, 602);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(35, 33);
            pictureBox5.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(0, 48, 73);
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(261, 602);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(35, 33);
            pictureBox6.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox6.TabIndex = 21;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(344, 659);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(searchBox);
            Controls.Add(SearchRecipeButton);
            Controls.Add(searchPanel);
            Controls.Add(defaultPanel);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            defaultPanel.ResumeLayout(false);
            defaultPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private KusinApp.Services.RoundedButton SearchRecipeButton;
        private ListBox itemList;
        private Label label2;
        private ListView recipeSuggestionBox;
        private ImageList recipesImageList;
        private Panel defaultPanel;
        private KusinApp.Services.RoundedTextBox searchBox;
        private Panel searchPanel;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Services.RoundedButton addButton1;
        private Services.IncrementerButton ingIncrementer;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label1;
        private TextBox ingBox;
        private ContextMenuStrip contextMenuStrip1;
        private ListView AIReccomendationView;
        public ListView recipeListView;
        private ColumnHeader recipeColumn;
    }
}
