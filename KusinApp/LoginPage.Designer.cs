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
            txtUsername = new KusinApp.Services.RoundedTextBox();
            txtPassword = new KusinApp.Services.RoundedTextBox();
            label4 = new Label();
            label5 = new Label();
            loginButton = new KusinApp.Services.RoundedButton();
            registerButton = new KusinApp.Services.RoundedButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            pictureBox4 = new PictureBox();
            roundedButton1 = new KusinApp.Services.RoundedButton();
            roundedTextBox2 = new KusinApp.Services.RoundedTextBox();
            roundedTextBox1 = new KusinApp.Services.RoundedTextBox();
            pictureBox3 = new PictureBox();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            txtUsername.BorderStyle = BorderStyle.None;
            txtUsername.CornerRadius = 10;
            txtUsername.Font = new Font("Segoe UI", 10F);
            txtUsername.ForeColor = Color.Gray;
            txtUsername.LeftMargin = 20;
            txtUsername.Location = new Point(61, 290);
            txtUsername.Margin = new Padding(2, 1, 2, 1);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderColor = Color.Gray;
            txtUsername.PlaceholderText = "Enter Username";
            txtUsername.Size = new Size(220, 23);
            txtUsername.TabIndex = 3;
            txtUsername.Text = "Enter Username";
            txtUsername.TopPadding = 15;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.CornerRadius = 10;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.ForeColor = Color.Gray;
            txtPassword.LeftMargin = 20;
            txtPassword.Location = new Point(61, 376);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderColor = Color.Gray;
            txtPassword.PlaceholderText = "Enter Password";
            txtPassword.Size = new Size(220, 23);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "Enter Password";
            txtPassword.TopPadding = 6;
            txtPassword.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(0, 48, 73);
            label4.Location = new Point(66, 338);
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
            loginButton.CornerRadius = 20;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            loginButton.ForeColor = Color.FromArgb(0, 48, 73);
            loginButton.Location = new Point(128, 417);
            loginButton.Margin = new Padding(2, 1, 2, 1);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(81, 29);
            loginButton.TabIndex = 8;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += button1_Click;
            // 
            // registerButton
            // 
            registerButton.BackColor = Color.White;
            registerButton.CornerRadius = 20;
            registerButton.FlatAppearance.BorderSize = 0;
            registerButton.FlatStyle = FlatStyle.Flat;
            registerButton.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            registerButton.ForeColor = Color.FromArgb(0, 48, 73);
            registerButton.Location = new Point(128, 467);
            registerButton.Margin = new Padding(2, 1, 2, 1);
            registerButton.Name = "registerButton";
            registerButton.Size = new Size(81, 30);
            registerButton.TabIndex = 9;
            registerButton.Text = "Register";
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
            panel1.Controls.Add(pictureBox4);
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
            // pictureBox4
            // 
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(291, 21);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 24);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            pictureBox4.Click += pictureBox4_Click;
            // 
            // roundedButton1
            // 
            roundedButton1.BackColor = Color.FromArgb(247, 127, 0);
            roundedButton1.CornerRadius = 15;
            roundedButton1.Cursor = Cursors.Hand;
            roundedButton1.FlatAppearance.BorderSize = 0;
            roundedButton1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            roundedButton1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            roundedButton1.FlatStyle = FlatStyle.Flat;
            roundedButton1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            roundedButton1.ForeColor = Color.White;
            roundedButton1.Location = new Point(120, 257);
            roundedButton1.Name = "roundedButton1";
            roundedButton1.Size = new Size(81, 30);
            roundedButton1.TabIndex = 6;
            roundedButton1.Text = "REGISTER";
            roundedButton1.UseVisualStyleBackColor = false;
            // 
            // roundedTextBox2
            // 
            roundedTextBox2.BorderStyle = BorderStyle.None;
            roundedTextBox2.CornerRadius = 10;
            roundedTextBox2.Cursor = Cursors.IBeam;
            roundedTextBox2.ForeColor = Color.Gray;
            roundedTextBox2.LeftMargin = 20;
            roundedTextBox2.Location = new Point(62, 206);
            roundedTextBox2.Multiline = true;
            roundedTextBox2.Name = "roundedTextBox2";
            roundedTextBox2.PasswordChar = '*';
            roundedTextBox2.PlaceholderColor = Color.Gray;
            roundedTextBox2.PlaceholderText = "Enter text...";
            roundedTextBox2.Size = new Size(203, 23);
            roundedTextBox2.TabIndex = 5;
            roundedTextBox2.Text = "Enter text...";
            roundedTextBox2.TopPadding = 6;
            roundedTextBox2.TextChanged += roundedTextBox2_TextChanged;
            // 
            // roundedTextBox1
            // 
            roundedTextBox1.BorderStyle = BorderStyle.None;
            roundedTextBox1.CornerRadius = 10;
            roundedTextBox1.Cursor = Cursors.IBeam;
            roundedTextBox1.ForeColor = Color.Gray;
            roundedTextBox1.LeftMargin = 20;
            roundedTextBox1.Location = new Point(62, 127);
            roundedTextBox1.Multiline = true;
            roundedTextBox1.Name = "roundedTextBox1";
            roundedTextBox1.PlaceholderColor = Color.Gray;
            roundedTextBox1.PlaceholderText = "Enter username";
            roundedTextBox1.Size = new Size(203, 23);
            roundedTextBox1.TabIndex = 4;
            roundedTextBox1.Text = "Enter username";
            roundedTextBox1.TopPadding = 6;
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
            label6.Location = new Point(62, 169);
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
            ClientSize = new Size(340, 590);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private KusinApp.Services.RoundedTextBox txtUsername;
        private KusinApp.Services.RoundedTextBox txtPassword;
        private Label label4;
        private Label label5;
        private KusinApp.Services.RoundedButton loginButton;
        private KusinApp.Services.RoundedButton registerButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label label2;
        private Services.RoundedTextBox roundedTextBox1;
        private PictureBox pictureBox3;
        private Label label6;
        private Label label3;
        private Services.RoundedTextBox roundedTextBox2;
        private PictureBox pictureBox4;
        private Services.RoundedButton roundedButton1;
    }
}