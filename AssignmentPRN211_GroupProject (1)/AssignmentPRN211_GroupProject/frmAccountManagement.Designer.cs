namespace BirdCageShopGUI
{
    partial class frmAccountManagement
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
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
            cboRole = new ComboBox();
            txtPhone = new TextBox();
            txtLastname = new TextBox();
            txtEmail = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtFirstname = new TextBox();
            groupBox3 = new GroupBox();
            btnSearch = new Button();
            txtKeyword = new TextBox();
            label12 = new Label();
            label8 = new Label();
            label13 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            back = new Label();
            dgvUserList = new DataGridView();
            groupBox1 = new GroupBox();
            txtUserId = new TextBox();
            label9 = new Label();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(btnAdd);
            groupBox2.Location = new Point(27, 474);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(414, 78);
            groupBox2.TabIndex = 24;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.MediumSeaGreen;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(308, 34);
            btnDelete.Margin = new Padding(2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 27);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.MediumSeaGreen;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(161, 34);
            btnUpdate.Margin = new Padding(2);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 27);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.MediumSeaGreen;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Location = new Point(18, 34);
            btnAdd.Margin = new Padding(2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 27);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // cboRole
            // 
            cboRole.FormattingEnabled = true;
            cboRole.Location = new Point(136, 328);
            cboRole.Margin = new Padding(2);
            cboRole.Name = "cboRole";
            cboRole.Size = new Size(245, 28);
            cboRole.TabIndex = 18;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(136, 241);
            txtPhone.Margin = new Padding(2);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(245, 27);
            txtPhone.TabIndex = 17;
            // 
            // txtLastname
            // 
            txtLastname.Location = new Point(136, 198);
            txtLastname.Margin = new Padding(2);
            txtLastname.Name = "txtLastname";
            txtLastname.Size = new Size(245, 27);
            txtLastname.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(136, 281);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(245, 27);
            txtEmail.TabIndex = 15;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(136, 78);
            txtUsername.Margin = new Padding(2);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(245, 27);
            txtUsername.TabIndex = 13;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(136, 116);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = 'x';
            txtPassword.Size = new Size(245, 27);
            txtPassword.TabIndex = 12;
            // 
            // txtFirstname
            // 
            txtFirstname.Location = new Point(136, 155);
            txtFirstname.Margin = new Padding(2);
            txtFirstname.Name = "txtFirstname";
            txtFirstname.Size = new Size(245, 27);
            txtFirstname.TabIndex = 11;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSearch);
            groupBox3.Controls.Add(txtKeyword);
            groupBox3.Controls.Add(label12);
            groupBox3.Location = new Point(460, 81);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(532, 63);
            groupBox3.TabIndex = 25;
            groupBox3.TabStop = false;
            groupBox3.Text = "Search";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.MediumSeaGreen;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Location = new Point(398, 22);
            btnSearch.Margin = new Padding(2);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 27);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(123, 24);
            txtKeyword.Margin = new Padding(2);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(245, 27);
            txtKeyword.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(35, 26);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(67, 20);
            label12.TabIndex = 20;
            label12.Text = "Keyword";
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
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(465, 149);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 27;
            label13.Text = "User List";
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
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(back);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 57);
            panel1.TabIndex = 26;
            // 
            // back
            // 
            back.AutoSize = true;
            back.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            back.ForeColor = SystemColors.ControlLightLight;
            back.Location = new Point(26, 14);
            back.Margin = new Padding(2, 0, 2, 0);
            back.Name = "back";
            back.Size = new Size(197, 37);
            back.TabIndex = 0;
            back.Text = "User Manager";
            back.Click += back_Click;
            // 
            // dgvUserList
            // 
            dgvUserList.BackgroundColor = SystemColors.ButtonFace;
            dgvUserList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUserList.Location = new Point(460, 176);
            dgvUserList.Margin = new Padding(2);
            dgvUserList.Name = "dgvUserList";
            dgvUserList.RowHeadersWidth = 62;
            dgvUserList.RowTemplate.Height = 33;
            dgvUserList.Size = new Size(532, 377);
            dgvUserList.TabIndex = 23;
            dgvUserList.SelectionChanged += dgvUserList_SelectionChanged;
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
            groupBox1.Location = new Point(27, 81);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(414, 376);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            groupBox1.Text = "User Info";
            // 
            // txtUserId
            // 
            txtUserId.Location = new Point(136, 35);
            txtUserId.Margin = new Padding(2);
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
            // frmAccountManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 582);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(label13);
            Controls.Add(panel1);
            Controls.Add(dgvUserList);
            Controls.Add(groupBox1);
            Margin = new Padding(2);
            Name = "frmAccountManagement";
            Text = "User Manager";
            Load += frmAccountManagement_Load;
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUserList).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private ComboBox cboRole;
        private TextBox txtPhone;
        private TextBox txtLastname;
        private TextBox txtEmail;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtFirstname;
        private GroupBox groupBox3;
        private Button btnSearch;
        private TextBox txtKeyword;
        private Label label12;
        private Label label8;
        private Label label13;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Label back;
        private DataGridView dgvUserList;
        private GroupBox groupBox1;
        private TextBox txtUserId;
        private Label label9;
    }
}