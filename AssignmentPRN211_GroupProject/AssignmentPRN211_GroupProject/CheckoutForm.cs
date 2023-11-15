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
        private OrderService orderService;

        public CheckoutForm()
        {
            InitializeComponent();
            orderService = new OrderService();
        }

        private void CheckoutFormcs_Load(object sender, EventArgs e)
        {
            cbx_buyMethod.DataSource = orderService.GetMethod();
            cbx_buyMethod.DisplayMember = "Method";
            cbx_buyMethod.ValueMember = "Method";
            cbx_country.DataSource = orderService.country;
        }

        private void btn_Payment_Click(object sender, EventArgs e)
        {
            try
            {
                OrderInfo orderInfo = new OrderInfo();
                orderInfo.UserId = 1;
                orderInfo.Address = txt_address.Text.Trim();
                orderInfo.ExpectedDeliveryDate = DateTime.Now;
                orderInfo.OrderDate = DateTime.Parse(txt_OrderDate.Text.Trim());
                orderInfo.Country = cbx_country.SelectedValue.ToString();
                orderInfo.Method = cbx_buyMethod.SelectedValue.ToString();
                orderInfo.OrderStatus = "Delivered";
                if (!orderInfo.Method.Equals("Direct")){
                    orderInfo.ExpectedDeliveryDate = DateTime.Now.AddDays(3);
                }
                if(ckb_checkout.CheckState == CheckState.Checked)
                {
                    orderInfo.OrderStatus = "Processing";
                    PaymentGatewayForm form = new PaymentGatewayForm();
                    form.ShowDialog();
                    this.Hide();
                }
                orderService.AddOrder(orderInfo);
                MessageBox.Show("Successfully create a Order" + orderInfo.OrderId.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);
            }
        }
    }
}
