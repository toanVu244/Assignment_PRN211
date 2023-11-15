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
    public partial class CartForm : Form
    {
        private ProductService productService;

        public CartForm()
        {
            InitializeComponent();
            productService = new ProductService();
        }

        public List<OrderDetail> listCart;

        private void CartForm_Load(object sender, EventArgs e)
        {

            listViewCart.View = View.Details;
            listViewCart.FullRowSelect = true;
            listViewCart.GridLines = true;

            List<Product> listProduct = productService.GetAllProduct();
            int index = 0;
            decimal totalprice = 0;

            foreach (var item in listCart)
            {
                ListViewItem itemView = new ListViewItem();
                Product product = listProduct.Find(c => c.ProductId.Equals(item.ProductId));
                if (product != null)
                {
                    itemView.Text = (index + 1).ToString();
                    itemView.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = product.ProductName });
                    itemView.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Quantity.ToString() });
                    itemView.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = (product.Price * item.Quantity).ToString() });
                    totalprice = (decimal)(totalprice + (product.Price * item.Quantity));
                    itemView.ImageIndex = index;
                    listViewCart.Items.Add(itemView);
                    index += 1;
                }
            }

            txt_totalPrice.Text = totalprice.ToString();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            BirdCageShopManagementForm home = new BirdCageShopManagementForm();
            home.Show();
            home.listCartDetail = listCart;
            this.Hide();

        }

        private void btn_Checkout_Click(object sender, EventArgs e)
        {
            CheckoutForm checkoutForm = new CheckoutForm();
            checkoutForm.Show();
            this.Hide();
        }
    }
}
