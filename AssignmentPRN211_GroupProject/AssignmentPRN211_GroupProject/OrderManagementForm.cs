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
    }
}
