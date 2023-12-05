using BCSService;
using BusinessObject.Models;
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
    public partial class frmAccountManagement : Form
    {
        private IAccountService _accountService;
        private IRoleService _roleService;
        public frmAccountManagement()
        {
            InitializeComponent();
            _accountService = new AccountService();
            _roleService = new RoleService();
        }

        private void frmAccountManagement_Load(object sender, EventArgs e)
        {
            var result = _accountService.GetAllAccount();
            dgvUserList.DataSource = null;
            dgvUserList.DataSource = result;

            dgvUserList.Columns["Password"].Visible = false;
            dgvUserList.Columns["Role"].Visible = false;
            dgvUserList.Columns["OrderInfos"].Visible = false;

            cboRole.DataSource = _roleService.GetAll();
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "RoleID";
        }

        private void dgvUserList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUserList.SelectedRows.Count > 0)
            {
                var selectedAccount = (Account)dgvUserList.SelectedRows[0].DataBoundItem;
                txtUserId.Text = selectedAccount.UserId.ToString();
                txtUsername.Text = selectedAccount.Username;
                txtPassword.Text = selectedAccount.Password;
                txtFirstname.Text = selectedAccount.FirstName;
                txtLastname.Text = selectedAccount.LastName;
                txtPhone.Text = selectedAccount.PhoneNumber;
                txtEmail.Text = selectedAccount.Email;
                cboRole.SelectedValue = selectedAccount.RoleId;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || !int.TryParse(txtUserId.Text, out id))
            {
                MessageBox.Show("The User ID is invalid. Please input a number!!!",
                    "Invalid User ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            _accountService.DeleteAccount(id);
            var result = _accountService.GetAllAccount();
            dgvUserList.DataSource = null;
            dgvUserList.DataSource = result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAccount accountForm = new frmAccount();
            accountForm.userId = null;
            accountForm.ShowDialog();

            var result = _accountService.GetAllAccount();
            dgvUserList.DataSource = null;
            dgvUserList.DataSource = result;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtUserId.Text) || !int.TryParse(txtUserId.Text, out id))
            {
                MessageBox.Show("The User ID is invalid. Please input a number!!!",
                    "Invalid User ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmAccount accountForm = new frmAccount();
            accountForm.userId = int.Parse(txtUserId.Text);
            accountForm.ShowDialog();

            var result = _accountService.GetAllAccount();
            dgvUserList.DataSource = null;
            dgvUserList.DataSource = result;
        }



        private void back_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.Show();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtKeyword.Text))
            {
                MessageBox.Show("The search keyword is required!!!",
                    "Search keyword required",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var result = _accountService.SearchAccounts(txtKeyword.Text);
            dgvUserList.DataSource = null;
            dgvUserList.DataSource = result;
            dgvUserList.Columns["Password"].Visible = false;
        }
    }
}
