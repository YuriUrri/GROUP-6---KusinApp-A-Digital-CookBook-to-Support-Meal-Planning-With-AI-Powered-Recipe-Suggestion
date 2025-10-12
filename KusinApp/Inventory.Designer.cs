namespace KusinApp
{
    partial class Inventory
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
            inventoryDG = new DataGridView();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            inventorySearch = new TextBox();
            nameTextBox = new TextBox();
            quantityTextBox = new TextBox();
            label1 = new Label();
            Search = new Label();
            labelName = new Label();
            label3 = new Label();
            updateButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryDG).BeginInit();
            SuspendLayout();
            // 
            // inventoryDG
            // 
            inventoryDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryDG.Location = new Point(12, 50);
            inventoryDG.MultiSelect = false;
            inventoryDG.Name = "inventoryDG";
            inventoryDG.ReadOnly = true;
            inventoryDG.Size = new Size(320, 353);
            inventoryDG.TabIndex = 0;
            inventoryDG.CellContentClick += dataGridView1_CellContentClick;
            // 
            // button3
            // 
            button3.Location = new Point(227, 555);
            button3.Name = "button3";
            button3.Size = new Size(96, 23);
            button3.TabIndex = 7;
            button3.Text = "Search Recipes";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(17, 555);
            button2.Name = "button2";
            button2.Size = new Size(123, 23);
            button2.TabIndex = 6;
            button2.Text = "Personal Recipes";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(146, 555);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "Home";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // inventorySearch
            // 
            inventorySearch.Location = new Point(64, 10);
            inventorySearch.Margin = new Padding(2, 1, 2, 1);
            inventorySearch.Name = "inventorySearch";
            inventorySearch.Size = new Size(146, 23);
            inventorySearch.TabIndex = 8;
            inventorySearch.TextChanged += inventorySearch_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(17, 426);
            nameTextBox.Margin = new Padding(2, 1, 2, 1);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(146, 23);
            nameTextBox.TabIndex = 9;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Location = new Point(177, 426);
            quantityTextBox.Margin = new Padding(2, 1, 2, 1);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(146, 23);
            quantityTextBox.TabIndex = 10;
            quantityTextBox.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(348, 447);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 11;
            label1.Text = "label1";
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(17, 18);
            Search.Name = "Search";
            Search.Size = new Size(42, 15);
            Search.TabIndex = 12;
            Search.Text = "Search";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(17, 410);
            labelName.Name = "labelName";
            labelName.Size = new Size(39, 15);
            labelName.TabIndex = 13;
            labelName.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 410);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 14;
            label3.Text = "Quantity";
            // 
            // updateButton
            // 
            updateButton.Location = new Point(126, 487);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 15;
            updateButton.Text = "Update";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += button4_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 590);
            Controls.Add(updateButton);
            Controls.Add(label3);
            Controls.Add(labelName);
            Controls.Add(Search);
            Controls.Add(label1);
            Controls.Add(quantityTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(inventorySearch);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(inventoryDG);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load_1;
            ((System.ComponentModel.ISupportInitialize)inventoryDG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inventoryDG;
        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox inventorySearch;
        private TextBox nameTextBox;
        private TextBox quantityTextBox;
        private Label label1;
        private Label Search;
        private Label labelName;
        private Label label3;
        private Button updateButton;
    }
}