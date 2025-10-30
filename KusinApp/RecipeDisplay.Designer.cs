namespace KusinApp
{
    partial class RecipeDisplay
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
            recipeDetailPanel = new Panel();
            recipeIngredientsLabel = new Label();
            recipeStepsLabel = new Label();
            backButton = new KusinApp.Services.RoundedButton();
            recipeNameLabel = new Label();
            recipeDetailPanel.SuspendLayout();
            SuspendLayout();
            // 
            // recipeDetailPanel
            // 
            recipeDetailPanel.AutoScroll = true;
            recipeDetailPanel.Controls.Add(recipeIngredientsLabel);
            recipeDetailPanel.Controls.Add(recipeStepsLabel);
            recipeDetailPanel.Controls.Add(backButton);
            recipeDetailPanel.Controls.Add(recipeNameLabel);
            recipeDetailPanel.Location = new Point(-5, 46);
            recipeDetailPanel.Margin = new Padding(2, 1, 2, 1);
            recipeDetailPanel.Name = "recipeDetailPanel";
            recipeDetailPanel.Size = new Size(351, 442);
            recipeDetailPanel.TabIndex = 17;
            // 
            // recipeIngredientsLabel
            // 
            recipeIngredientsLabel.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recipeIngredientsLabel.Location = new Point(13, 58);
            recipeIngredientsLabel.Name = "recipeIngredientsLabel";
            recipeIngredientsLabel.Size = new Size(324, 55);
            recipeIngredientsLabel.TabIndex = 25;
            recipeIngredientsLabel.Text = "label5";
            // 
            // recipeStepsLabel
            // 
            recipeStepsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recipeStepsLabel.Location = new Point(13, 123);
            recipeStepsLabel.Name = "recipeStepsLabel";
            recipeStepsLabel.Size = new Size(324, 264);
            recipeStepsLabel.TabIndex = 24;
            recipeStepsLabel.Text = "label5";
            // 
            // backButton
            // 
            backButton.BackColor = Color.FromArgb(247, 127, 0);
            backButton.CornerRadius = 15;
            backButton.FlatAppearance.BorderSize = 0;
            backButton.FlatAppearance.MouseDownBackColor = Color.Transparent;
            backButton.FlatAppearance.MouseOverBackColor = Color.Transparent;
            backButton.FlatStyle = FlatStyle.Flat;
            backButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            backButton.ForeColor = Color.FromArgb(0, 48, 73);
            backButton.Location = new Point(13, 406);
            backButton.Name = "backButton";
            backButton.Size = new Size(59, 23);
            backButton.TabIndex = 23;
            backButton.Text = "BACK";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += backButton_Click;
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            recipeNameLabel.Location = new Point(13, 15);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(324, 32);
            recipeNameLabel.TabIndex = 0;
            recipeNameLabel.Text = "label5";
            // 
            // RecipeDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(344, 659);
            Controls.Add(recipeDetailPanel);
            Name = "RecipeDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeDisplay";
            Load += RecipeDisplay_Load;
            recipeDetailPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel recipeDetailPanel;
        private Label recipeIngredientsLabel;
        private Label recipeStepsLabel;
        private Services.RoundedButton backButton;
        private Label recipeNameLabel;
    }
}