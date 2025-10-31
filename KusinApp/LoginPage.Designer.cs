namespace KusinApp
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            label1 = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label4 = new Label();
            label5 = new Label();
            loginButton = new Button();
            registerButton = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            closeButton1 = new KusinApp.Components.CloseButton();
            roundedButton1 = new Button();
            roundedTextBox2 = new TextBox();
            roundedTextBox1 = new TextBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 145);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.White;
            txtUsername.Font = new Font("Segoe UI", 9F);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.Location = new Point(66, 290);
            txtUsername.Margin = new Padding(2, 1, 2, 1);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(215, 23);
            txtUsername.TabIndex = 3;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.Font = new Font("Segoe UI", 9F);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.Location = new Point(66, 376);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(215, 23);
            txtPassword.TabIndex = 4;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 48, 73);
            label4.Location = new Point(61, 338);
            label4.Margin = new Padding(2, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 5;
            label4.Text = "Password";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(0, 48, 73);
            label5.Location = new Point(61, 252);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(106, 28);
            label5.TabIndex = 6;
            label5.Text = "Username";
            label5.Click += label5_Click;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.FromArgb(247, 127, 0);
            loginButton.BackgroundImageLayout = ImageLayout.Zoom;
            loginButton.FlatStyle = FlatStyle.Popup;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            loginButton.ForeColor = Color.FromArgb(0, 48, 73);
            loginButton.Location = new Point(128, 417);
            loginButton.Margin = new Padding(2, 1, 2, 1);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(81, 29);
            loginButton.TabIndex = 8;
            loginButton.Text = "LOGIN";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.White;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Popup;
            registerButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            registerButton.ForeColor = Color.FromArgb(0, 48, 73);
            registerButton.Location = new Point(128, 467);
            registerButton.Margin = new Padding(2, 1, 2, 1);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(81, 30);
            registerButton.TabIndex = 9;
            registerButton.Text = "REGISTER";
            registerButton.UseVisualStyleBackColor = false;
            registerButton.Click += registerButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 115);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 82);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 467);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(342, 123);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(closeButton1);
            panel1.Controls.Add(roundedButton1);
            panel1.Controls.Add(roundedTextBox2);
            panel1.Controls.Add(roundedTextBox1);
            panel1.Controls.Add(pictureBox3);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(342, 379);
            panel1.TabIndex = 12;
            panel1.Visible = false;
            panel1.Paint += panel1_Paint;
            // 
            // closeButton1
            // 
            closeButton1.BackColor = Color.Transparent;
            closeButton1.Location = new Point(275, 20);
            closeButton1.Name = "closeButton1";
            closeButton1.Size = new Size(38, 38);
            closeButton1.TabIndex = 7;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(247, 127, 0);
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            roundedButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            roundedButton1.FlatStyle = FlatStyle.Popup;
            roundedButton1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(120, 265);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(79, 30);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "REGISTER";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.Cursor = Cursors.IBeam;
            roundedTextBox2.ForeColor = Color.Gray;
            roundedTextBox2.Location = new Point(62, 206);
            roundedTextBox2.Multiline = true;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PasswordChar = '*';
            roundedTextBox2.PlaceholderText = "Enter Password";
            roundedTextBox2.Size = new Size(203, 23);
            roundedTextBox2.TabIndex = 5;
            roundedTextBox2.TextChanged += roundedTextBox2_TextChanged;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.Cursor = Cursors.IBeam;
            roundedTextBox1.ForeColor = Color.Gray;
            roundedTextBox1.ImeMode = ImeMode.Off;
            roundedTextBox1.Location = new Point(62, 127);
            roundedTextBox1.Multiline = true;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderText = "Enter username";
            roundedTextBox1.Size = new Size(203, 23);
            roundedTextBox1.TabIndex = 10;
            roundedTextBox1.TextChanged += roundedTextBox1_TextChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 279);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(342, 100);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 48, 73);
            label6.Location = new Point(59, 169);
            label6.Name = "label6";
            label6.Size = new Size(87, 19);
            label6.TabIndex = 2;
            label6.Text = "PASSWORD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(0, 48, 73);
            label3.Location = new Point(59, 94);
            label3.Name = "label3";
            label3.Size = new Size(84, 19);
            label3.TabIndex = 1;
            label3.Text = "USERNAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 48, 73);
            label2.Location = new Point(40, 41);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 0;
            label2.Text = "REGISTER";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(342, 590);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "git ";
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
        private Label label5;
        private Button loginButton;
        private Button registerButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private TextBox roundedTextBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label3;
        private TextBox roundedTextBox2;
        private Button roundedButton1;
        private Components.CloseButton closeButton1;
    }
}