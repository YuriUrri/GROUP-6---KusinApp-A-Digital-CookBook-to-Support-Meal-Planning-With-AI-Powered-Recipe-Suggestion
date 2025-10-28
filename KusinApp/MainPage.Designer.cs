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
            label1 = new Label();
            ingBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SearchRecipeButton = new Button();
            addButton = new Button();
            itemList = new ListBox();
            Addlabel = new Label();
            label2 = new Label();
            recipeSuggestionBox = new ListView();
            button4 = new Button();
            ingCountIncrementer = new NumericUpDown();
            defaultPanel = new Panel();
            searchBox = new TextBox();
            searchPanel = new Panel();
            listView1 = new ListView();
            listBox1 = new ListBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)ingCountIncrementer).BeginInit();
            defaultPanel.SuspendLayout();
            searchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gill Sans MT", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 67);
            label1.TabIndex = 0;
            label1.Text = "KusinApp";
            label1.Click += label1_Click;
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
            // button1
            // 
            button1.Location = new Point(143, 555);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 2;
            button1.Text = "Inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(14, 555);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 3;
            button2.Text = "Personal Recipes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SearchRecipeButton
            // 
            SearchRecipeButton.Location = new Point(7, 91);
            SearchRecipeButton.Name = "SearchRecipeButton";
            SearchRecipeButton.Size = new Size(108, 23);
            SearchRecipeButton.TabIndex = 4;
            SearchRecipeButton.Text = "Search Recipes";
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
            // button4
            // 
            button4.Location = new Point(224, 555);
            button4.Name = "button4";
            button4.Size = new Size(108, 23);
            button4.TabIndex = 12;
            button4.Text = "Back To Login";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
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
            searchBox.Location = new Point(121, 91);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(215, 23);
            searchBox.TabIndex = 14;
            searchBox.TextChanged += searchBox_TextChanged;
            // 
            // searchPanel
            // 
            searchPanel.Controls.Add(listView1);
            searchPanel.Controls.Add(listBox1);
            searchPanel.Controls.Add(label3);
            searchPanel.Controls.Add(label4);
            searchPanel.Location = new Point(3, 132);
            searchPanel.Margin = new Padding(2, 1, 2, 1);
            searchPanel.Name = "searchPanel";
            searchPanel.Size = new Size(338, 365);
            searchPanel.TabIndex = 15;
            searchPanel.Visible = false;
            // 
            // listView1
            // 
            listView1.Location = new Point(13, 216);
            listView1.Name = "listView1";
            listView1.Size = new Size(320, 137);
            listView1.TabIndex = 11;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(13, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(320, 139);
            listBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ImageAlign = ContentAlignment.TopCenter;
            label3.Location = new Point(13, 190);
            label3.Name = "label3";
            label3.Size = new Size(61, 23);
            label3.TabIndex = 10;
            label3.Text = "Recipes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Gill Sans MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ImageAlign = ContentAlignment.TopCenter;
            label4.Location = new Point(13, 14);
            label4.Name = "label4";
            label4.Size = new Size(129, 23);
            label4.TabIndex = 8;
            label4.Text = "Suggested Recipes";
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 590);
            Controls.Add(searchBox);
            Controls.Add(button4);
            Controls.Add(SearchRecipeButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(searchPanel);
            Controls.Add(defaultPanel);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KusinApp";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)ingCountIncrementer).EndInit();
            defaultPanel.ResumeLayout(false);
            defaultPanel.PerformLayout();
            searchPanel.ResumeLayout(false);
            searchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ingBox;
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
        private Panel defaultPanel;
        private TextBox searchBox;
        private Panel searchPanel;
        private ListView listView1;
        private ListBox listBox1;
        private Label label3;
        private Label label4;
    }
}
