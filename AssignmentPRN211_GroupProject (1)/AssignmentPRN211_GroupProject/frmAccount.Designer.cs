namespace BirdCageShopGUI
{
    partial class frmAccount
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
            btnSave = new Button();
            btnCancel = new Button();
            panel1 = new Panel();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtUserId = new TextBox();
            label9 = new Label();
            cboRole = new ComboBox();
            txtPhone = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtFirstname = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.MediumSeaGreen;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(212, 465);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.MediumSeaGreen;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(342, 465);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2, 2, 2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 57);
            panel1.TabIndex = 27;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(18, 17);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(122, 37);
            label1.TabIndex = 0;
            label1.Text = "Account";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtUserId);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboRole);
            groupBox1.Controls.Add(txtPhone);
            groupBox1.Controls.Add(txtLastname);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtUsername);
            groupBox1.Controls.Add(txtPassword);
            groupBox1.Controls.Add(txtFirstname);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(18, 73);
            groupBox1.Margin = new Padding(2, 2, 2, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2, 2, 2, 2);
            groupBox1.Size = new Size(414, 376);
            groupBox1.TabIndex = 28;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Info";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(136, 35);
            txtUserId.Margin = new Padding(2, 2, 2, 2);
            txtUserId.Name = "txtUserId";
            txtUserId.ReadOnly = true;
            txtUserId.Size = new Size(245, 27);
            txtUserId.TabIndex = 20;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(18, 38);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(53, 20);
            label9.TabIndex = 19;
            label9.Text = "UserID";
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(136, 328);
            cboRole.Margin = new Padding(2, 2, 2, 2);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(245, 28);
            cboRole.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(136, 241);
            txtPhone.Margin = new Padding(2, 2, 2, 2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(245, 27);
            txtPhone.TabIndex = 17;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(136, 198);
            txtLastname.Margin = new Padding(2, 2, 2, 2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(245, 27);
            txtLastname.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 281);
            txtEmail.Margin = new Padding(2, 2, 2, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 78);
            txtUsername.Margin = new Padding(2, 2, 2, 2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(245, 27);
            txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 116);
            txtPassword.Margin = new Padding(2, 2, 2, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(245, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(136, 155);
            txtFirstname.Margin = new Padding(2, 2, 2, 2);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(245, 27);
            txtFirstname.TabIndex = 11;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(18, 118);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 6;
            label8.Text = "Password";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(18, 158);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 5;
            label7.Text = "First name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(18, 200);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(76, 20);
            label6.TabIndex = 4;
            label6.Text = "Last name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(18, 243);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(105, 20);
            label5.TabIndex = 3;
            label5.Text = "Phone number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(18, 283);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(46, 20);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(18, 330);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 1;
            label3.Text = "Role";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(18, 80);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // frmAccount
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(450, 509);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Margin = new Padding(2, 2, 2, 2);
            Name = "frmAccount";
            Text = "Edit Account";
            Load += frmAccount_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private Button btnCancel;
        private Panel panel1;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtUserId;
        private Label label9;
        private ComboBox cboRole;
        private TextBox txtPhone;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFirstname;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
    }
}