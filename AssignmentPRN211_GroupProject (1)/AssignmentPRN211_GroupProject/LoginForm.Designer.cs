namespace AssignmentPRN211_GroupProject
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            Email = new Label();
            label1 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            panel1 = new Panel();
            btnLogin = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Email.Location = new Point(37, 91);
            Email.Name = "Email";
            Email.Size = new Size(71, 32);
            Email.TabIndex = 0;
            Email.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 199);
            label1.Name = "label1";
            label1.Size = new Size(111, 32);
            label1.TabIndex = 1;
            label1.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = SystemColors.Window;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(42, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(311, 39);
            txtEmail.TabIndex = 2;
            txtEmail.Text = "jamie.taylor@example.com";
            // 
            // txtPassword
            // 
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.Location = new Point(42, 234);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(311, 39);
            txtPassword.TabIndex = 3;
            txtPassword.Text = "password2";
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(148, 34);
            label2.Name = "label2";
            label2.Size = new Size(117, 45);
            label2.TabIndex = 4;
            label2.Text = "LOGIN";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(txtEmail);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Email);
            panel1.Location = new Point(45, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 445);
            panel1.TabIndex = 5;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.ForestGreen;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ButtonHighlight;
            btnLogin.Location = new Point(42, 319);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(311, 64);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(423, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 52);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(491, 575);
            ControlBox = false;
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label Email;
        private Label label1;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label2;
        private Panel panel1;
        private Button btnLogin;
        private PictureBox pictureBox1;
    }
}