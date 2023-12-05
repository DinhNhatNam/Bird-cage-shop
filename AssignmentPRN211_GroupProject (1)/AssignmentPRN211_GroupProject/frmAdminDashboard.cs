using AssignmentPRN211_GroupProject;
using BCSService;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BirdCageShopGUI
{
    public partial class frmAdminDashboard : Form
    {
        public frmAdminDashboard()
        {
            InitializeComponent();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lgFrm = new LoginForm();
            lgFrm.Show();
            this.Close();
        }

        private void viewAllCageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void viewAllUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccountManagement frmAccountManagement = new frmAccountManagement();
            frmAccountManagement.Show();
            this.Hide();
        }

        private void viewAllOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrderManagementForm orderManagementForm = new OrderManagementForm();
            orderManagementForm.Show();
            this.Hide();
        }
    }
}
