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
            recipeIngredientsLabel = new Label();
            recipeStepsLabel = new Label();
            recipeNameLabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            recipeDetailPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // recipeDetailPanel
            // 
            recipeDetailPanel.AutoScroll = true;
            recipeDetailPanel.BackColor = Color.White;
            recipeDetailPanel.Controls.Add(recipeIngredientsLabel);
            recipeDetailPanel.Controls.Add(recipeStepsLabel);
            recipeDetailPanel.Controls.Add(recipeNameLabel);
            recipeDetailPanel.Location = new Point(25, 116);
            recipeDetailPanel.Margin = new Padding(2, 1, 2, 1);
            recipeDetailPanel.Name = "recipeDetailPanel";
            recipeDetailPanel.Size = new Size(289, 461);
            recipeDetailPanel.TabIndex = 17;
            // 
            // recipeIngredientsLabel
            // 
            recipeIngredientsLabel.Font = new Font("Segoe UI", 10F);
            recipeIngredientsLabel.Location = new Point(27, 59);
            recipeIngredientsLabel.Name = "recipeIngredientsLabel";
            recipeIngredientsLabel.Size = new Size(230, 70);
            recipeIngredientsLabel.TabIndex = 25;
            recipeIngredientsLabel.Text = "label5";
            recipeIngredientsLabel.Click += recipeIngredientsLabel_Click;
            // 
            // recipeStepsLabel
            // 
            recipeStepsLabel.Font = new Font("Segoe UI", 10F);
            recipeStepsLabel.Location = new Point(27, 138);
            recipeStepsLabel.Name = "recipeStepsLabel";
            recipeStepsLabel.Size = new Size(230, 294);
            recipeStepsLabel.TabIndex = 24;
            recipeStepsLabel.Text = "label5";
            // 
            // recipeNameLabel
            // 
            recipeNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recipeNameLabel.Location = new Point(27, 14);
            recipeNameLabel.Name = "recipeNameLabel";
            recipeNameLabel.Size = new Size(230, 32);
            recipeNameLabel.TabIndex = 0;
            recipeNameLabel.Text = "label5";
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
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(25, 40);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // RecipeDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(344, 659);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(recipeDetailPanel);
            Name = "RecipeDisplay";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RecipeDisplay";
            Load += RecipeDisplay_Load;
            recipeDetailPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel recipeDetailPanel;
        private Label recipeIngredientsLabel;
        private Label recipeStepsLabel;
        private Label recipeNameLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}