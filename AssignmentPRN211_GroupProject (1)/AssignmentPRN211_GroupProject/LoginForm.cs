using BCSService;
using BirdCageShopGUI;
using BusinessObject.Models;

namespace AssignmentPRN211_GroupProject
{
    public partial class LoginForm : Form
    {
        private IAccountService accountService;
        public LoginForm()
        {
            InitializeComponent();
            accountService = new AccountService();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Account account = accountService.GetAccountByEmail(txtEmail.Text.Trim());
            if (account != null && txtPassword.Text.Trim().Equals(account.Password))
            {
                switch (account.RoleId)
                {
                    case 1:
                        frmAdminDashboard adDashboard = new frmAdminDashboard();
                        adDashboard.Show();
                        this.Hide();
                        break;
                    case 2:
                        BirdCageShopManagementForm birdCageShopManagementForm = new BirdCageShopManagementForm();
                        birdCageShopManagementForm.id = account.UserId;
                        birdCageShopManagementForm.Show();
                        this.Hide();
                        break;
                }
            }
        }
    }
}