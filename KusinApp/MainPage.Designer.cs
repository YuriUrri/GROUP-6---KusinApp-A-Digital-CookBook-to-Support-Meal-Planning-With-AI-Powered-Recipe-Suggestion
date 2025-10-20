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
            label1 = new Label();
            searchBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SearchRecipeButton = new Button();
            addButton = new Button();
            itemList = new ListBox();
            Addlabel = new Label();
            label2 = new Label();
            recipeSuggestionBox = new ListView();
            recipesImageList = new ImageList(components);
            button4 = new Button();
            ingCountIncrementer = new NumericUpDown();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ingCountIncrementer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(93, 19);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(492, 133);
            label1.TabIndex = 0;
            label1.Text = "KusinApp";
            label1.Click += label1_Click;
            // 
            // searchBox
            // 
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.Location = new Point(22, 233);
            searchBox.Margin = new Padding(6);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(322, 39);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += textBox1_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(266, 1184);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(139, 49);
            button1.TabIndex = 2;
            button1.Text = "Inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(26, 1184);
            button2.Margin = new Padding(6);
            button2.Name = "button2";
            button2.Size = new Size(228, 49);
            button2.TabIndex = 3;
            button2.Text = "Personal Recipes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SearchRecipeButton
            // 
            SearchRecipeButton.Location = new Point(416, 1184);
            SearchRecipeButton.Margin = new Padding(6);
            SearchRecipeButton.Name = "SearchRecipeButton";
            SearchRecipeButton.Size = new Size(201, 49);
            SearchRecipeButton.TabIndex = 4;
            SearchRecipeButton.Text = "Search Recipes";
            SearchRecipeButton.UseVisualStyleBackColor = true;
            SearchRecipeButton.Click += button3_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(477, 233);
            addButton.Margin = new Padding(6);
            addButton.Name = "addButton";
            addButton.Size = new Size(139, 49);
            addButton.TabIndex = 6;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button4_Click;
            // 
            // itemList
            // 
            itemList.FormattingEnabled = true;
            itemList.Location = new Point(22, 294);
            itemList.Margin = new Padding(6);
            itemList.Name = "itemList";
            itemList.Size = new Size(591, 228);
            itemList.TabIndex = 7;
            itemList.SelectedIndexChanged += listBox1_SelectedIndexChanged_1;
            // 
            // Addlabel
            // 
            Addlabel.AutoSize = true;
            Addlabel.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Addlabel.ImageAlign = ContentAlignment.TopCenter;
            Addlabel.Location = new Point(22, 177);
            Addlabel.Margin = new Padding(6, 0, 6, 0);
            Addlabel.Name = "Addlabel";
            Addlabel.Size = new Size(225, 45);
            Addlabel.TabIndex = 8;
            Addlabel.Text = "Add Ingredients";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ImageAlign = ContentAlignment.TopCenter;
            label2.Location = new Point(22, 553);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(400, 45);
            label2.TabIndex = 10;
            label2.Text = "Meals From Your Ingredients";
            label2.Click += label2_Click;
            // 
            // recipeSuggestionBox
            // 
            recipeSuggestionBox.Location = new Point(22, 608);
            recipeSuggestionBox.Margin = new Padding(6);
            recipeSuggestionBox.Name = "recipeSuggestionBox";
            recipeSuggestionBox.Size = new Size(591, 288);
            recipeSuggestionBox.TabIndex = 11;
            recipeSuggestionBox.UseCompatibleStateImageBehavior = false;
            recipeSuggestionBox.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // recipesImageList
            // 
            recipesImageList.ColorDepth = ColorDepth.Depth32Bit;
            recipesImageList.ImageSize = new Size(16, 16);
            recipesImageList.TransparentColor = Color.Transparent;
            // 
            // button4
            // 
            button4.Location = new Point(416, 1122);
            button4.Margin = new Padding(6);
            button4.Name = "button4";
            button4.Size = new Size(201, 49);
            button4.TabIndex = 12;
            button4.Text = "Back To Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // ingCountIncrementer
            // 
            ingCountIncrementer.Location = new Point(358, 233);
            ingCountIncrementer.Margin = new Padding(6);
            ingCountIncrementer.Name = "ingCountIncrementer";
            ingCountIncrementer.Size = new Size(108, 39);
            ingCountIncrementer.TabIndex = 13;
            ingCountIncrementer.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // panel1
            // 
            panel1.Location = new Point(12, 925);
            panel1.Name = "panel1";
            panel1.Size = new Size(587, 200);
            panel1.TabIndex = 14;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 1259);
            Controls.Add(panel1);
            Controls.Add(ingCountIncrementer);
            Controls.Add(button4);
            Controls.Add(recipeSuggestionBox);
            Controls.Add(label2);
            Controls.Add(Addlabel);
            Controls.Add(itemList);
            Controls.Add(addButton);
            Controls.Add(SearchRecipeButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Margin = new Padding(6);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KusinApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ingCountIncrementer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchBox;
        private Button button1;
        private Button button2;
        private Button SearchRecipeButton;
        private Button addButton;
        private ListBox itemList;
        private Label Addlabel;
        private Label label2;
        private ListView recipeSuggestionBox;
        private ImageList recipesImageList;
        private Button button4;
        private NumericUpDown ingCountIncrementer;
        private Panel panel1;
    }
}
