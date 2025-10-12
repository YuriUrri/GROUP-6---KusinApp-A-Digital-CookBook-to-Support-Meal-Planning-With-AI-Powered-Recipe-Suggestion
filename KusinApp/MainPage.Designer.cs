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
            button3 = new Button();
            addButton = new Button();
            itemList = new ListBox();
            Addlabel = new Label();
            label2 = new Label();
            recipeSuggestionBox = new ListView();
            recipesImageList = new ImageList(components);
            suggestionBox = new ListBox();
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
            // searchBox
            // 
            searchBox.AutoCompleteMode = AutoCompleteMode.Suggest;
            searchBox.Location = new Point(12, 109);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(231, 23);
            searchBox.TabIndex = 1;
            searchBox.TextChanged += textBox1_TextChanged;
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
            // button3
            // 
            button3.Location = new Point(224, 555);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 4;
            button3.Text = "Search Recipes";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(257, 109);
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
            itemList.Location = new Point(12, 138);
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
            Addlabel.Location = new Point(12, 83);
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
            label2.Location = new Point(12, 259);
            label2.Name = "label2";
            label2.Size = new Size(200, 23);
            label2.TabIndex = 10;
            label2.Text = "Meals From Your Ingredients";
            label2.Click += label2_Click;
            // 
            // recipeSuggestionBox
            // 
            recipeSuggestionBox.Location = new Point(12, 285);
            recipeSuggestionBox.Name = "recipeSuggestionBox";
            recipeSuggestionBox.Size = new Size(320, 137);
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
            // suggestionBox
            // 
            suggestionBox.FormattingEnabled = true;
            suggestionBox.ItemHeight = 15;
            suggestionBox.Location = new Point(12, 138);
            suggestionBox.Name = "suggestionBox";
            suggestionBox.Size = new Size(231, 94);
            suggestionBox.TabIndex = 5;
            suggestionBox.Visible = false;
            suggestionBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 590);
            Controls.Add(recipeSuggestionBox);
            Controls.Add(label2);
            Controls.Add(Addlabel);
            Controls.Add(itemList);
            Controls.Add(addButton);
            Controls.Add(suggestionBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(searchBox);
            Controls.Add(label1);
            Name = "MainPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KusinApp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox searchBox;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button addButton;
        private ListBox itemList;
        private Label Addlabel;
        private Label label2;
        private ListView recipeSuggestionBox;
        private ImageList recipesImageList;
        private ListBox suggestionBox;
    }
}
