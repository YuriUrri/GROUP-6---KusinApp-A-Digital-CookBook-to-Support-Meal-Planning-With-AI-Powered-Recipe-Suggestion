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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            txtUsername.LeftMargin = 20;
            txtUsername.Location = new Point(61, 290);
            txtUsername.Margin = new Padding(2, 1, 2, 1);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(220, 23);
            txtUsername.TabIndex = 3;
            txtUsername.TopPadding = 15;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.CornerRadius = 10;
            txtPassword.Font = new Font("Segoe UI", 10F);
            txtPassword.LeftMargin = 20;
            txtPassword.Location = new Point(61, 376);
            txtPassword.Margin = new Padding(2, 1, 2, 1);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(220, 23);
            txtPassword.TabIndex = 4;
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
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(252, 191, 73);
            ClientSize = new Size(340, 590);
            Controls.Add(pictureBox1);
            Controls.Add(registerButton);
            Controls.Add(loginButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Margin = new Padding(2, 1, 2, 1);
            Name = "LoginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Load += LoginPage_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
    }
}