using BCSService;
using BusinessObject.Models;
using Microsoft.IdentityModel.Tokens;
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
    public partial class CheckoutForm : Form
    {
        private IAccountService accountService;
        private OrderService orderService;
        public int id { get; set; }
        public CheckoutForm()
        {
            InitializeComponent();
            orderService = new OrderService();
            accountService = new AccountService();
        }

        private void CheckoutFormcs_Load(object sender, EventArgs e)
        {
            txt_userID.Text = accountService.Get(this.id).Username.ToString();

            cbx_buyMethod.DataSource = orderService.GetMethod();
            cbx_buyMethod.DisplayMember = "Method";
            cbx_buyMethod.ValueMember = "Method";
            cbx_country.DataSource = orderService.country;

        }
        public List<OrderDetail> listCart;
        private void btn_Payment_Click(object sender, EventArgs e)
        {
            try
            {
                OrderInfo orderInfo = new OrderInfo();
                orderInfo.UserId = accountService.Get(this.id).UserId;
                orderInfo.Address = txt_address.Text.Trim();
                orderInfo.ExpectedDeliveryDate = DateTime.Now;
                orderInfo.OrderDate = DateTime.Parse(txt_OrderDate.Text.Trim());
                if (orderInfo.OrderDate > DateTime.Now)
                {
                    MessageBox.Show("Invalid Date");
                    throw new Exception();
                }
                orderInfo.Country = cbx_country.SelectedValue.ToString();
                orderInfo.Method = cbx_buyMethod.SelectedValue.ToString();
                orderInfo.OrderStatus = "Delivered";
                if (!orderInfo.Method.Equals("Direct"))
                {
                    orderInfo.ExpectedDeliveryDate = DateTime.Now.AddDays(3);
                }
                if (ckb_checkout.CheckState == CheckState.Checked)
                {
                    orderInfo.OrderStatus = "Processing";
                    PaymentGatewayForm form = new PaymentGatewayForm();
                    form.ShowDialog();
                    this.Hide();
                }
                orderService.AddOrder(orderInfo);
                foreach (OrderDetail detail in listCart)
                {
                    detail.OrderId = orderInfo.OrderId;
                    orderService.AddOderDetail(detail);
                }

                MessageBox.Show("Successfully create a Order");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            CartForm form = new CartForm();
            form.Show();
            this.Close();
        }
    }
}
