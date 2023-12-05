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
    public partial class OrderManagementForm : Form
    {
        private OrderService orderService;
        public OrderManagementForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void OrderManagementForm_Load(object sender, EventArgs e)
        {
            dtg_orderList.DataSource = orderService.GetAllOrder();
            cbx_buyMethod.DataSource = orderService.GetMethod();
            cbx_buyMethod.DisplayMember = "Method";
            cbx_buyMethod.ValueMember = "Method";
            cbx_country.DataSource = orderService.country;
        }

        private void btn_Search(object sender, EventArgs e)
        {
            try
            {
                String keyword = txt_Search.Text.Trim();
                List<OrderInfo> list = new List<OrderInfo>();
                List<OrderInfo> listData = orderService.GetAllOrder();
                foreach (OrderInfo info in listData)
                {
                    if (info.OrderStatus.ToUpper().Contains(keyword.ToUpper()))
                    {
                        list.Add(info);

                    }
                    else if (info.Country.ToUpper().Contains(keyword.ToUpper()))
                    {
                        list.Add(info);
                    }
                    else if (info.Method.ToUpper().Contains(keyword.ToUpper()))
                    {
                        list.Add(info);
                    }
                }
                dtg_orderList.DataSource = list;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }

        private void dtg_Order_Cellclick(object sender, DataGridViewCellEventArgs e)
        {
            txt_orderID.Text = dtg_orderList.CurrentRow.Cells["OrderID"].Value.ToString();
            txt_userID.Text = dtg_orderList.CurrentRow.Cells["UserID"].Value.ToString();
            txt_address.Text = dtg_orderList.CurrentRow.Cells["Address"].Value.ToString();
            /*cbx_country.SelectedValue = dtg_orderList.CurrentRow.Cells["Country"].Value.ToString();*/
            cbx_buyMethod.SelectedValue = dtg_orderList.CurrentRow.Cells["Method"].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Int32.Parse(txt_orderID.Text);
                orderService.DeleteOrderDetail(id);
                orderService.DeleteOrder(id);
                MessageBox.Show("suscess!!");
                dtg_orderList.DataSource = orderService.GetAllOrder();
            }
            catch
            {
                MessageBox.Show("invalid infor!!");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                OrderInfo orderInfo = new OrderInfo();
                orderInfo.OrderId = Int32.Parse(txt_orderID.Text);
                orderInfo = orderService.GetOrderInfoById(orderInfo.OrderId);
                orderInfo.UserId = Int32.Parse(txt_userID.Text);
                orderInfo.Address = txt_address.Text;
                orderInfo.Country = cbx_country.SelectedValue.ToString();
                orderInfo.OrderDate = DateTime.Parse(txt_OrderDate.Text);
                orderInfo.Method = cbx_buyMethod.SelectedValue.ToString();
                orderService.UpdateOrder(orderInfo);
                MessageBox.Show("suscess!!");
            }
            catch { MessageBox.Show("invalid infor!!"); }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            frmAdminDashboard frmAdminDashboard = new frmAdminDashboard();
            frmAdminDashboard.Show();
            this.Close();
        }
    }
}
