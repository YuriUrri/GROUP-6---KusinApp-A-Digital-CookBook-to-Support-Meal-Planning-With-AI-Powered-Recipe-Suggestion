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
            ingBox = new TextBox();
            SearchRecipeButton = new KusinApp.Services.RoundedButton();
            addButton = new Button();
            itemList = new ListBox();
            Addlabel = new Label();
            label2 = new Label();
            recipeSuggestionBox = new ListView();
            ingCountIncrementer = new NumericUpDown();
            defaultPanel = new Panel();
            searchBox = new KusinApp.Services.RoundedTextBox();
            searchPanel = new Panel();
            incrementerButton1 = new KusinApp.Services.IncrementerButton();
            roundedTextBox1 = new KusinApp.Services.RoundedTextBox();
            roundedButton1 = new KusinApp.Services.RoundedButton();
            listView1 = new ListView();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ingCountIncrementer).BeginInit();
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
            // ingBox
            // 
            ingBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            ingBox.Location = new Point(13, 40);
            ingBox.Name = "ingBox";
            ingBox.Size = new Size(175, 23);
            ingBox.TabIndex = 1;
            ingBox.TextChanged += textBox1_TextChanged;
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
            // addButton
            // 
            addButton.Location = new Point(258, 40);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button4_Click;
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
            // Addlabel
            // 
            Addlabel.AutoSize = true;
            Addlabel.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addlabel.ImageAlign = ContentAlignment.TopCenter;
            Addlabel.Location = new Point(13, 14);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(113, 23);
            Addlabel.TabIndex = 8;
            Addlabel.Text = "Add Ingredients";
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
            // ingCountIncrementer
            // 
            ingCountIncrementer.Location = new Point(194, 40);
            ingCountIncrementer.Name = "ingCountIncrementer";
            ingCountIncrementer.Size = new Size(58, 23);
            ingCountIncrementer.TabIndex = 13;
            ingCountIncrementer.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // defaultPanel
            // 
            defaultPanel.Controls.Add(recipeSuggestionBox);
            defaultPanel.Controls.Add(ingCountIncrementer);
            defaultPanel.Controls.Add(ingBox);
            defaultPanel.Controls.Add(addButton);
            defaultPanel.Controls.Add(itemList);
            defaultPanel.Controls.Add(label2);
            defaultPanel.Controls.Add(Addlabel);
            defaultPanel.Location = new Point(3, 132);
            defaultPanel.Margin = new Padding(2, 1, 2, 1);
            defaultPanel.Name = "defaultPanel";
            defaultPanel.Size = new Size(338, 365);
            defaultPanel.TabIndex = 14;
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
            searchPanel.Controls.Add(incrementerButton1);
            searchPanel.Controls.Add(roundedTextBox1);
            searchPanel.Controls.Add(roundedButton1);
            searchPanel.Controls.Add(listView1);
            searchPanel.Controls.Add(listBox1);
            searchPanel.Controls.Add(label3);
            searchPanel.Controls.Add(label4);
            searchPanel.Location = new Point(5, 132);
            searchPanel.Margin = new Padding(2, 1, 2, 1);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(331, 430);
            searchPanel.TabIndex = 15;
            searchPanel.Visible = false;
            searchPanel.Paint += searchPanel_Paint;
            // 
            // incrementerButton1
            // 
            incrementerButton1.ArrowColor = Color.White;
            incrementerButton1.BackColor = Color.Transparent;
            incrementerButton1.ButtonColor = Color.FromArgb(252, 191, 73);
            incrementerButton1.CornerRadius = 10;
            incrementerButton1.Location = new Point(89, 40);
            incrementerButton1.Name = "incrementerButton1";
            incrementerButton1.Size = new Size(28, 40);
            incrementerButton1.Step = 1;
            incrementerButton1.TabIndex = 14;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BorderStyle = BorderStyle.None;
            roundedTextBox1.CornerRadius = 10;
            roundedTextBox1.ForeColor = Color.Gray;
            roundedTextBox1.LeftMargin = 20;
            roundedTextBox1.Location = new Point(123, 49);
            roundedTextBox1.Multiline = true;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderColor = Color.Gray;
            roundedTextBox1.PlaceholderText = "Ex. Avocado";
            roundedTextBox1.Size = new Size(193, 23);
            roundedTextBox1.TabIndex = 13;
            roundedTextBox1.Text = "Ex. Avocado";
            roundedTextBox1.TopPadding = 6;
            roundedTextBox1.TextChanged += roundedTextBox1_TextChanged;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(247, 127, 0);
            roundedButton1.CornerRadius = 15;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            roundedButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.FromArgb(0, 48, 73);
            roundedButton1.Location = new Point(24, 49);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(59, 23);
            roundedButton1.TabIndex = 12;
            roundedButton1.Text = "ADD";
            roundedButton1.UseVisualStyleBackColor = false;
            roundedButton1.Click += roundedButton1_Click;
            // 
            // listView1
            // 
            listView1.ForeColor = Color.FromArgb(0, 48, 73);
            listView1.Location = new Point(24, 276);
            listView1.Name = "listView1";
            listView1.Size = new Size(292, 137);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            listBox1.ForeColor = Color.FromArgb(0, 48, 73);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(24, 84);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(292, 154);
            listBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(0, 48, 73);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(22, 252);
            label3.Name = "label3";
            label3.Size = new Size(152, 21);
            label3.TabIndex = 10;
            label3.Text = "SUGGESTED MEALS";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(0, 48, 73);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(24, 16);
            label4.Name = "label4";
            label4.Size = new Size(147, 21);
            label4.TabIndex = 8;
            label4.Text = "ADD INGREDIENTS";
            label4.Click += label4_Click;
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
            ((System.ComponentModel.ISupportInitialize)ingCountIncrementer).EndInit();
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
        private TextBox ingBox;
        private KusinApp.Services.RoundedButton SearchRecipeButton;
        private Button addButton;
        private ListBox itemList;
        private Label Addlabel;
        private Label label2;
        private ListView recipeSuggestionBox;
        private ImageList recipesImageList;
        private NumericUpDown ingCountIncrementer;
        private Panel defaultPanel;
        private KusinApp.Services.RoundedTextBox searchBox;
        private Panel searchPanel;
        private ListView listView1;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Services.RoundedButton roundedButton1;
        private Services.RoundedTextBox roundedTextBox1;
        private Services.IncrementerButton incrementerButton1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
    }
}
