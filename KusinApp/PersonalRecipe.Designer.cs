namespace KusinApp
{
    partial class PersonalRecipe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalRecipe));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            logoutButton1 = new KusinApp.Components.LogoutButton();
            navBar1 = new KusinApp.Components.NavBar();
            inputRecipeBox = new TextBox();
            updateButton = new Button();
            addRecipeButton = new Button();
            deleteRecipeButton = new Button();
            showPersonalRecipeView = new ListView();
            displayPersonalRecipe = new ColumnHeader();
            titleBox = new TextBox();
            ingredientInputBox = new TextBox();
            inputRecipePanel = new Panel();
            viewRecipesButton = new Button();
            showRecipePanel = new Panel();
            backButton = new Button();
            selectButton = new Button();
            titleShowBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            inputRecipePanel.SuspendLayout();
            showRecipePanel.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(80, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 65);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 48, 73);
            label1.Location = new Point(29, 100);
            label1.Name = "label1";
            label1.Size = new Size(158, 21);
            label1.TabIndex = 10;
            label1.Text = "PERSONAL RECIPES";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // logoutButton1
            // 
            logoutButton1.BackColor = Color.Transparent;
            logoutButton1.Location = new Point(29, 33);
            logoutButton1.Name = "logoutButton1";
            logoutButton1.Size = new Size(38, 38);
            logoutButton1.TabIndex = 11;
            // 
            // navBar1
            // 
            navBar1.BackColor = Color.FromArgb(0, 48, 73);
            navBar1.Location = new Point(-4, 579);
            navBar1.Name = "navBar1";
            navBar1.Size = new Size(354, 82);
            navBar1.TabIndex = 12;
            navBar1.Load += navBar1_Load;
            // 
            // inputRecipeBox
            // 
            inputRecipeBox.AllowDrop = true;
            inputRecipeBox.BorderStyle = BorderStyle.None;
            inputRecipeBox.Location = new Point(11, 51);
            inputRecipeBox.Multiline = true;
            inputRecipeBox.Name = "inputRecipeBox";
            inputRecipeBox.PlaceholderText = "Input Steps";
            inputRecipeBox.ScrollBars = ScrollBars.Vertical;
            inputRecipeBox.Size = new Size(280, 270);
            inputRecipeBox.TabIndex = 13;
            inputRecipeBox.TextChanged += textBox1_TextChanged;
            // 
            // updateButton
            // 
            updateButton.BackColor = Color.FromArgb(247, 127, 0);
            updateButton.Cursor = Cursors.Hand;
            updateButton.FlatStyle = FlatStyle.Popup;
            updateButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            updateButton.ForeColor = Color.FromArgb(0, 48, 73);
            updateButton.Location = new Point(68, 376);
            updateButton.Name = "updateButton";
            updateButton.Size = new Size(75, 23);
            updateButton.TabIndex = 16;
            updateButton.Text = "UPDATE";
            updateButton.UseVisualStyleBackColor = true;
            // 
            // addRecipeButton
            // 
            addRecipeButton.BackColor = Color.FromArgb(247, 127, 0);
            addRecipeButton.Cursor = Cursors.Hand;
            addRecipeButton.FlatStyle = FlatStyle.Popup;
            addRecipeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            addRecipeButton.ForeColor = Color.FromArgb(0, 48, 73);
            addRecipeButton.Location = new Point(149, 376);
            addRecipeButton.Name = "addRecipeButton";
            addRecipeButton.Size = new Size(75, 23);
            addRecipeButton.TabIndex = 17;
            addRecipeButton.Text = "ADD";
            addRecipeButton.UseVisualStyleBackColor = true;
            addRecipeButton.Click += addRecipeButton_Click;
            // 
            // deleteRecipeButton
            // 
            deleteRecipeButton.BackColor = Color.FromArgb(247, 127, 0);
            deleteRecipeButton.Cursor = Cursors.Hand;
            deleteRecipeButton.FlatStyle = FlatStyle.Popup;
            deleteRecipeButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            deleteRecipeButton.ForeColor = Color.FromArgb(0, 48, 73);
            deleteRecipeButton.Location = new Point(106, 376);
            deleteRecipeButton.Name = "deleteRecipeButton";
            deleteRecipeButton.Size = new Size(75, 23);
            deleteRecipeButton.TabIndex = 18;
            deleteRecipeButton.Text = "DELETE";
            deleteRecipeButton.UseVisualStyleBackColor = true;
            deleteRecipeButton.Click += deleteRecipeButton_Click;
            // 
            // showPersonalRecipeView
            // 
            showPersonalRecipeView.Columns.AddRange(new ColumnHeader[] { displayPersonalRecipe });
            showPersonalRecipeView.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            showPersonalRecipeView.GridLines = true;
            showPersonalRecipeView.Location = new Point(10, 51);
            showPersonalRecipeView.Name = "showPersonalRecipeView";
            showPersonalRecipeView.Size = new Size(280, 309);
            showPersonalRecipeView.TabIndex = 19;
            showPersonalRecipeView.UseCompatibleStateImageBehavior = false;
            showPersonalRecipeView.View = View.Details;
            showPersonalRecipeView.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // displayPersonalRecipe
            // 
            displayPersonalRecipe.Text = "Personal Recipes";
            displayPersonalRecipe.Width = 277;
            // 
            // titleBox
            // 
            titleBox.AllowDrop = true;
            titleBox.BorderStyle = BorderStyle.None;
            titleBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleBox.Location = new Point(11, 12);
            titleBox.Multiline = true;
            titleBox.Name = "titleBox";
            titleBox.PlaceholderText = "Recipe Title";
            titleBox.ScrollBars = ScrollBars.Vertical;
            titleBox.Size = new Size(280, 33);
            titleBox.TabIndex = 20;
            titleBox.TextChanged += titleBox_TextChanged;
            // 
            // ingredientInputBox
            // 
            ingredientInputBox.AllowDrop = true;
            ingredientInputBox.BorderStyle = BorderStyle.None;
            ingredientInputBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ingredientInputBox.Location = new Point(11, 327);
            ingredientInputBox.Multiline = true;
            ingredientInputBox.Name = "ingredientInputBox";
            ingredientInputBox.PlaceholderText = "Input Ingredients";
            ingredientInputBox.ScrollBars = ScrollBars.Vertical;
            ingredientInputBox.Size = new Size(280, 33);
            ingredientInputBox.TabIndex = 21;
            ingredientInputBox.TextChanged += ingredientInputBox_TextChanged;
            // 
            // inputRecipePanel
            // 
            inputRecipePanel.Controls.Add(viewRecipesButton);
            inputRecipePanel.Controls.Add(inputRecipeBox);
            inputRecipePanel.Controls.Add(updateButton);
            inputRecipePanel.Controls.Add(ingredientInputBox);
            inputRecipePanel.Controls.Add(titleBox);
            inputRecipePanel.Controls.Add(addRecipeButton);
            inputRecipePanel.Location = new Point(12, 124);
            inputRecipePanel.Name = "inputRecipePanel";
            inputRecipePanel.Size = new Size(302, 449);
            inputRecipePanel.TabIndex = 22;
            // 
            // viewRecipesButton
            // 
            viewRecipesButton.BackColor = Color.FromArgb(247, 127, 0);
            viewRecipesButton.Cursor = Cursors.Hand;
            viewRecipesButton.FlatStyle = FlatStyle.Popup;
            viewRecipesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            viewRecipesButton.ForeColor = Color.FromArgb(0, 48, 73);
            viewRecipesButton.Location = new Point(50, 405);
            viewRecipesButton.Name = "viewRecipesButton";
            viewRecipesButton.Size = new Size(191, 23);
            viewRecipesButton.TabIndex = 23;
            viewRecipesButton.Text = "VIEW PERSONAL RECIPES";
            viewRecipesButton.UseVisualStyleBackColor = true;
            viewRecipesButton.Click += viewRecipesButton_Click;
            // 
            // showRecipePanel
            // 
            showRecipePanel.Controls.Add(backButton);
            showRecipePanel.Controls.Add(selectButton);
            showRecipePanel.Controls.Add(titleShowBox);
            showRecipePanel.Controls.Add(showPersonalRecipeView);
            showRecipePanel.Controls.Add(deleteRecipeButton);
            showRecipePanel.Location = new Point(12, 124);
            showRecipePanel.Name = "showRecipePanel";
            showRecipePanel.Size = new Size(302, 449);
            showRecipePanel.TabIndex = 23;
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(247, 127, 0);
            backButton.Cursor = Cursors.Hand;
            backButton.FlatStyle = FlatStyle.Popup;
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            backButton.ForeColor = Color.FromArgb(0, 48, 73);
            backButton.Location = new Point(86, 405);
            backButton.Name = "backButton";
            backButton.Size = new Size(123, 23);
            backButton.TabIndex = 24;
            backButton.Text = "CREATE RECIPES";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // selectButton
            // 
            selectButton.BackColor = Color.FromArgb(247, 127, 0);
            selectButton.Cursor = Cursors.Hand;
            selectButton.FlatStyle = FlatStyle.Popup;
            selectButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            selectButton.ForeColor = Color.FromArgb(0, 48, 73);
            selectButton.Location = new Point(215, 22);
            selectButton.Name = "selectButton";
            selectButton.Size = new Size(75, 23);
            selectButton.TabIndex = 23;
            selectButton.Text = "SELECT";
            selectButton.UseVisualStyleBackColor = true;
            selectButton.Click += selectButton_Click;
            // 
            // titleShowBox
            // 
            titleShowBox.AllowDrop = true;
            titleShowBox.BorderStyle = BorderStyle.None;
            titleShowBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            titleShowBox.Location = new Point(10, 22);
            titleShowBox.Multiline = true;
            titleShowBox.Name = "titleShowBox";
            titleShowBox.PlaceholderText = "Recipe Title";
            titleShowBox.ReadOnly = true;
            titleShowBox.ScrollBars = ScrollBars.Vertical;
            titleShowBox.Size = new Size(199, 23);
            titleShowBox.TabIndex = 22;
            titleShowBox.TextChanged += textBox1_TextChanged_1;
            // 
            // PersonalRecipe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(340, 659);
            Controls.Add(showRecipePanel);
            Controls.Add(inputRecipePanel);
            Controls.Add(navBar1);
            Controls.Add(logoutButton1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PersonalRecipe";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeSearch";
            Load += RecipeSearch_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            inputRecipePanel.ResumeLayout(false);
            inputRecipePanel.PerformLayout();
            showRecipePanel.ResumeLayout(false);
            showRecipePanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label1;
        private Components.LogoutButton logoutButton1;
        private Components.NavBar navBar1;
        private TextBox inputRecipeBox;
        private Button updateButton;
        private Button addRecipeButton;
        private Button deleteRecipeButton;
        private ListView showPersonalRecipeView;
        private TextBox titleBox;
        private TextBox ingredientInputBox;
        private Panel inputRecipePanel;
        private Panel showRecipePanel;
        private TextBox titleShowBox;
        private Button selectButton;
        private ColumnHeader displayPersonalRecipe;
        private Button viewRecipesButton;
        private Button backButton;
    }
}