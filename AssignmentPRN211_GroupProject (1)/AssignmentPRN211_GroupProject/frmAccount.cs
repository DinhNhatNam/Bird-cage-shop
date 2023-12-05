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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BirdCageShopGUI
{
    public partial class frmAccount : Form
    {
        public int? userId { get; set; }
        private AccountService _accountService = new();
        private RoleService _roleService = new();

        public frmAccount()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAccount_Load(object sender, EventArgs e)
        {
            cboRole.DataSource = _roleService.GetAll();
            cboRole.DisplayMember = "Name";
            cboRole.ValueMember = "RoleID";

            if (this.userId != null)
            {
                var account = _accountService.GetAnAccount((int)userId);

                txtUserId.Text = account.UserId.ToString();
                txtUsername.Text = account.Username;
                txtPassword.Text = account.Password;
                txtFirstname.Text = account.FirstName;
                txtLastname.Text = account.LastName;
                txtPhone.Text = account.PhoneNumber;
                txtEmail.Text = account.Email;
                cboRole.SelectedValue = account.RoleId;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new();
                //  account.UserId = int.Parse(txtUserId.Text.Trim());
                account.Username = txtUsername.Text.Trim();
                account.Password = txtPassword.Text.Trim();
                account.FirstName = txtFirstname.Text.Trim();
                account.LastName = txtLastname.Text.Trim();
                account.PhoneNumber = txtPhone.Text.Trim();
                account.Email = txtEmail.Text.Trim();
                account.RoleId = int.Parse(cboRole.SelectedValue.ToString());

                if (userId != 0)
                    _accountService.UpdateAccount(account);
                else
                    _accountService.AddAccount(account);
                MessageBox.Show("suscess!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("error!!!");
            }



        }
    }
}
