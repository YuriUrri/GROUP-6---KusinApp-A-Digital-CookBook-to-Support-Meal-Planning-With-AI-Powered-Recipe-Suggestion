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
            inventorySearch = new TextBox();
            nameTextBox = new TextBox();
            quantityTextBox = new TextBox();
            label1 = new Label();
            updateButton = new KusinApp.Services.RoundedButton();
            pictureBox1 = new PictureBox();
            incrementerButton1 = new KusinApp.Services.IncrementerButton();
            navBar1 = new KusinApp.Components.NavBar();
            logoutButton1 = new KusinApp.Components.LogoutButton();
            ((System.ComponentModel.ISupportInitialize)inventoryDG).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            inventorySearch.ForeColor = Color.Gray;
            inventorySearch.Location = new Point(31, 103);
            inventorySearch.Margin = new Padding(2, 1, 2, 1);
            inventorySearch.Multiline = true;
            inventorySearch.Name = "inventorySearch";
            inventorySearch.PlaceholderText = "Search ingredients";
            inventorySearch.Size = new Size(276, 23);
            inventorySearch.TabIndex = 8;
            inventorySearch.Text = "Search ingredients";
            inventorySearch.TextChanged += inventorySearch_TextChanged;
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.White;
            nameTextBox.ForeColor = Color.Gray;
            nameTextBox.Location = new Point(181, 135);
            nameTextBox.Margin = new Padding(2, 1, 2, 1);
            nameTextBox.Multiline = true;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = " ";
            nameTextBox.Size = new Size(126, 23);
            nameTextBox.TabIndex = 9;
            nameTextBox.Text = " ";
            nameTextBox.TextChanged += textBox1_TextChanged;
            // 
            // quantityTextBox
            // 
            quantityTextBox.ForeColor = Color.FromArgb(0, 48, 73);
            quantityTextBox.Location = new Point(140, 135);
            quantityTextBox.Multiline = true;
            quantityTextBox.Name = "quantityTextBox";
            quantityTextBox.Size = new Size(36, 23);
            quantityTextBox.TabIndex = 24;
            quantityTextBox.Text = "0";
            quantityTextBox.TextAlign = HorizontalAlignment.Center;
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
            // navBar1
            // 
            navBar1.BackColor = Color.FromArgb(0, 48, 73);
            navBar1.Location = new Point(-7, 571);
            navBar1.Name = "navBar1";
            navBar1.Size = new Size(358, 94);
            navBar1.TabIndex = 19;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.Transparent;
            logoutButton1.Location = new Point(31, 33);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Size = new Size(38, 38);
            logoutButton1.TabIndex = 20;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(344, 659);
            Controls.Add(logoutButton1);
            Controls.Add(navBar1);
            Controls.Add(incrementerButton1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView inventoryDG;
        private TextBox inventorySearch;
        private TextBox nameTextBox;
        private TextBox quantityTextBox;
        private Label label1;
        private KusinApp.Services.RoundedButton updateButton;
        private PictureBox pictureBox1;
        private Services.IncrementerButton incrementerButton1;
        private Components.NavBar navBar1;
        private Components.LogoutButton logoutButton1;
    }
}