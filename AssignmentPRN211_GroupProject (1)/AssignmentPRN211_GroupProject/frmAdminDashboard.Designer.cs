namespace BirdCageShopGUI
{
    partial class frmAdminDashboard
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            menuStrip1 = new MenuStrip();
            ssaffToolStripMenuItem = new ToolStripMenuItem();
            viewAllUsersToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            viewAllCageToolStripMenuItem = new ToolStripMenuItem();
            ordersToolStripMenuItem = new ToolStripMenuItem();
            viewAllOrderToolStripMenuItem = new ToolStripMenuItem();
            myAccountToolStripMenuItem = new ToolStripMenuItem();
            signOutToolStripMenuItem = new ToolStripMenuItem();
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            label6 = new Label();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            linkLabel1 = new LinkLabel();
            pictureBox1 = new PictureBox();
            menuStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(24, 24);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ssaffToolStripMenuItem, productToolStripMenuItem, ordersToolStripMenuItem, myAccountToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(5, 2, 0, 2);
            menuStrip1.Size = new Size(1089, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // ssaffToolStripMenuItem
            // 
            ssaffToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllUsersToolStripMenuItem });
            ssaffToolStripMenuItem.Name = "ssaffToolStripMenuItem";
            ssaffToolStripMenuItem.Size = new Size(146, 24);
            ssaffToolStripMenuItem.Text = "Staff Management";
            // 
            // viewAllUsersToolStripMenuItem
            // 
            viewAllUsersToolStripMenuItem.Name = "viewAllUsersToolStripMenuItem";
            viewAllUsersToolStripMenuItem.Size = new Size(183, 26);
            viewAllUsersToolStripMenuItem.Text = "View all Users";
            viewAllUsersToolStripMenuItem.Click += viewAllUsersToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllCageToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(63, 24);
            productToolStripMenuItem.Text = "Cages";
            // 
            // viewAllCageToolStripMenuItem
            // 
            viewAllCageToolStripMenuItem.Name = "viewAllCageToolStripMenuItem";
            viewAllCageToolStripMenuItem.Size = new Size(182, 26);
            viewAllCageToolStripMenuItem.Text = "View all Cage";
            viewAllCageToolStripMenuItem.Click += viewAllCageToolStripMenuItem_Click;
            // 
            // ordersToolStripMenuItem
            // 
            ordersToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewAllOrderToolStripMenuItem });
            ordersToolStripMenuItem.Name = "ordersToolStripMenuItem";
            ordersToolStripMenuItem.Size = new Size(67, 24);
            ordersToolStripMenuItem.Text = "Orders";
            // 
            // viewAllOrderToolStripMenuItem
            // 
            viewAllOrderToolStripMenuItem.Name = "viewAllOrderToolStripMenuItem";
            viewAllOrderToolStripMenuItem.Size = new Size(188, 26);
            viewAllOrderToolStripMenuItem.Text = "View All Order";
            viewAllOrderToolStripMenuItem.Click += viewAllOrderToolStripMenuItem_Click;
            // 
            // myAccountToolStripMenuItem
            // 
            myAccountToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { signOutToolStripMenuItem });
            myAccountToolStripMenuItem.Name = "myAccountToolStripMenuItem";
            myAccountToolStripMenuItem.Size = new Size(99, 24);
            myAccountToolStripMenuItem.Text = "My account";
            // 
            // signOutToolStripMenuItem
            // 
            signOutToolStripMenuItem.Name = "signOutToolStripMenuItem";
            signOutToolStripMenuItem.Size = new Size(147, 26);
            signOutToolStripMenuItem.Text = "Sign out";
            signOutToolStripMenuItem.Click += signOutToolStripMenuItem_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 644);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 42);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(409, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(345, 28);
            label1.TabIndex = 0;
            label1.Text = "Developed By: 3 HANDSOME BOYS";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Teal;
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(linkLabel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 28);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1089, 160);
            panel2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(28, 125);
            label6.Name = "label6";
            label6.Size = new Size(242, 23);
            label6.TabIndex = 9;
            label6.Text = "Address: FPTU HCM, Viet Nam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(91, 102);
            label3.Name = "label3";
            label3.Size = new Size(108, 23);
            label3.TabIndex = 8;
            label3.Text = "037.251.3251";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 26F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(20, 18);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(537, 60);
            label2.TabIndex = 1;
            label2.Text = "BIRD CAGE DASHBOARD";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(28, 102);
            label4.Name = "label4";
            label4.Size = new Size(69, 23);
            label4.TabIndex = 7;
            label4.Text = "Hotline:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(28, 80);
            label5.Name = "label5";
            label5.Size = new Size(58, 23);
            label5.TabIndex = 5;
            label5.Text = "Gmail:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.SpringGreen;
            linkLabel1.Location = new Point(92, 82);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(202, 20);
            linkLabel1.TabIndex = 6;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "thegioilongchim@gmail.com";
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.logo;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.InitialImage = Properties.Resources.logo;
            pictureBox1.Location = new Point(2, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1087, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // frmAdminDashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 686);
            Controls.Add(pictureBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "frmAdminDashboard";
            Text = "Admin Dashboard";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ssaffToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem viewAllCageToolStripMenuItem;
        private ToolStripMenuItem ordersToolStripMenuItem;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private ToolStripMenuItem myAccountToolStripMenuItem;
        private Label label6;
        private Label label3;
        private Label label4;
        private Label label5;
        private LinkLabel linkLabel1;
        private ToolStripMenuItem signOutToolStripMenuItem;
        private ToolStripMenuItem viewAllUsersToolStripMenuItem;
        private ToolStripMenuItem viewAllOrderToolStripMenuItem;
        private PictureBox pictureBox1;
    }
}