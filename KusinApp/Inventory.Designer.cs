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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventory));
            inventoryDG = new DataGridView();
            inventorySearch = new KusinApp.Services.RoundedTextBox();
            nameTextBox = new KusinApp.Services.RoundedTextBox();
            quantityTextBox = new TextBox();
            label1 = new Label();
            updateButton = new KusinApp.Services.RoundedButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            incrementerButton1 = new KusinApp.Services.IncrementerButton();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)inventoryDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // inventoryDG
            // 
            inventoryDG.AllowUserToAddRows = false;
            inventoryDG.AllowUserToResizeColumns = false;
            inventoryDG.AllowUserToResizeRows = false;
            inventoryDG.BackgroundColor = Color.White;
            inventoryDG.BorderStyle = BorderStyle.None;
            inventoryDG.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryDG.Location = new Point(31, 172);
            inventoryDG.MultiSelect = false;
            inventoryDG.Name = "inventoryDG";
            inventoryDG.ReadOnly = true;
            inventoryDG.RowHeadersVisible = false;
            inventoryDG.Size = new Size(276, 354);
            inventoryDG.TabIndex = 0;
            inventoryDG.CellContentClick += dataGridView1_CellContentClick;
            // 
            // inventorySearch
            // 
            inventorySearch.BorderStyle = BorderStyle.None;
            inventorySearch.CornerRadius = 10;
            inventorySearch.ForeColor = Color.Gray;
            inventorySearch.LeftMargin = 20;
            inventorySearch.Location = new Point(31, 103);
            inventorySearch.Margin = new Padding(2, 1, 2, 1);
            inventorySearch.Multiline = true;
            inventorySearch.Name = "inventorySearch";
            inventorySearch.PlaceholderColor = Color.Gray;
            inventorySearch.PlaceholderText = "Search ingredients";
            inventorySearch.Size = new Size(276, 23);
            inventorySearch.TabIndex = 8;
            inventorySearch.Text = "Search ingredients";
            inventorySearch.TopPadding = 6;
            inventorySearch.TextChanged += inventorySearch_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.BorderStyle = BorderStyle.None;
            nameTextBox.CornerRadius = 10;
            nameTextBox.ForeColor = Color.Gray;
            nameTextBox.LeftMargin = 20;
            nameTextBox.Location = new Point(156, 135);
            nameTextBox.Margin = new Padding(2, 1, 2, 1);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderColor = Color.Gray;
            nameTextBox.PlaceholderText = " ";
            nameTextBox.Size = new Size(151, 23);
            nameTextBox.TabIndex = 9;
            nameTextBox.Text = " ";
            nameTextBox.TopPadding = 6;
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.Enabled = false;
            quantityTextBox.Location = new Point(140, 135);
            quantityTextBox.Margin = new Padding(2, 1, 2, 1);
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.PlaceholderText = "0";
            quantityTextBox.Size = new Size(25, 23);
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
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(247, 127, 0);
            updateButton.CornerRadius = 15;
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Flat;
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateButton.ForeColor = Color.FromArgb(0, 48, 73);
            updateButton.Location = new Point(31, 135);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 15;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = true;
            updateButton.Click += button4_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(89, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 62);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(31, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 24);
            pictureBox2.TabIndex = 17;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // incrementerButton1
            // 
            incrementerButton1.ArrowColor = Color.White;
            incrementerButton1.BackColor = Color.Transparent;
            incrementerButton1.ButtonColor = Color.FromArgb(252, 191, 73);
            incrementerButton1.CornerRadius = 10;
            incrementerButton1.Cursor = Cursors.Hand;
            incrementerButton1.Location = new Point(112, 130);
            incrementerButton1.Name = "incrementerButton1";
            incrementerButton1.Size = new Size(28, 36);
            incrementerButton1.Step = 1;
            incrementerButton1.TabIndex = 18;
            incrementerButton1.Load += incrementerButton1_Load;
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
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox6_Click;
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
            pictureBox5.TabIndex = 24;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox5_Click;
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
            pictureBox4.TabIndex = 23;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-8, 580);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(363, 84);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(344, 659);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(incrementerButton1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(updateButton);
            Controls.Add(label1);
            Controls.Add(quantityTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(inventorySearch);
            Controls.Add(inventoryDG);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load_1;
            ((System.ComponentModel.ISupportInitialize)inventoryDG).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inventoryDG;
        private KusinApp.Services.RoundedTextBox inventorySearch;
        private KusinApp.Services.RoundedTextBox nameTextBox;
        private TextBox quantityTextBox;
        private Label label1;
        private KusinApp.Services.RoundedButton updateButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Services.IncrementerButton incrementerButton1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
    }
}