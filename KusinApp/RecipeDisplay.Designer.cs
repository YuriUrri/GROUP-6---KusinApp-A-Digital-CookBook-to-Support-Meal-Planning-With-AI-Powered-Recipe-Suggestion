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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecipeDisplay));
            recipeDetailPanel = new Panel();
            recipeNameLabel = new Label();
            recipeIngredientsLabel = new Label();
            recipeStepsLabel = new Label();
            pictureBox1 = new PictureBox();
            closeButton1 = new KusinApp.Components.CloseButton();
            recipeDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // recipeDetailPanel
            // 
            recipeDetailPanel.AutoScroll = true;
            recipeDetailPanel.BackColor = Color.White;
            recipeDetailPanel.Controls.Add(recipeNameLabel);
            recipeDetailPanel.Controls.Add(recipeIngredientsLabel);
            recipeDetailPanel.Controls.Add(recipeStepsLabel);
            recipeDetailPanel.Location = new Point(25, 116);
            recipeDetailPanel.Margin = new Padding(2, 1, 2, 1);
            recipeDetailPanel.Name = "recipeDetailPanel";
            recipeDetailPanel.Size = new Size(289, 376);
            recipeDetailPanel.TabIndex = 17;
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.AutoSize = true;
            recipeNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recipeNameLabel.Location = new Point(27, 14);
            recipeNameLabel.MaximumSize = new Size(230, 0);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(57, 21);
            recipeNameLabel.TabIndex = 0;
            recipeNameLabel.Text = "label5";
            // 
            // recipeIngredientsLabel
            // 
            recipeIngredientsLabel.AutoSize = true;
            recipeIngredientsLabel.Font = new Font("Segoe UI", 10F);
            recipeIngredientsLabel.Location = new Point(27, 59);
            recipeIngredientsLabel.MaximumSize = new Size(230, 0);
            recipeIngredientsLabel.Name = "recipeIngredientsLabel";
            recipeIngredientsLabel.Size = new Size(45, 19);
            recipeIngredientsLabel.TabIndex = 25;
            recipeIngredientsLabel.Text = "label5";
            // 
            // recipeStepsLabel
            // 
            recipeStepsLabel.AutoSize = true;
            recipeStepsLabel.Font = new Font("Segoe UI", 10F);
            recipeStepsLabel.Location = new Point(27, 138);
            recipeStepsLabel.MaximumSize = new Size(230, 0);
            recipeStepsLabel.Name = "recipeStepsLabel";
            recipeStepsLabel.Size = new Size(45, 19);
            recipeStepsLabel.TabIndex = 24;
            recipeStepsLabel.Text = "label5";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(88, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 63);
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // closeButton1
            // 
            closeButton1.BackColor = Color.Transparent;
            closeButton1.Location = new Point(25, 36);
            closeButton1.Name = "closeButton1";
            closeButton1.Size = new Size(38, 38);
            closeButton1.TabIndex = 19;
            // 
            // RecipeDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(344, 541);
            Controls.Add(closeButton1);
            Controls.Add(pictureBox1);
            Controls.Add(recipeDetailPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RecipeDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeDisplay";
            Load += RecipeDisplay_Load;
            recipeDetailPanel.ResumeLayout(false);
            recipeDetailPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel recipeDetailPanel;
        private Label recipeIngredientsLabel;
        private Label recipeStepsLabel;
        private Label recipeNameLabel;
        private PictureBox pictureBox1;
        private Components.CloseButton closeButton1;
    }
}