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
    public partial class BirdCageShopManagementForm : Form
    {
        private ProductService productService = new ProductService();
        public List<OrderDetail> listCartDetail;
        ImageList imageListLarge;

        public BirdCageShopManagementForm()
        {
            InitializeComponent();
            productService = new ProductService();
            if (listCartDetail.IsNullOrEmpty())
            {
                listCartDetail = new List<OrderDetail>();
            }
        }



        private void BirdCageShopManagementForm_Load(object sender, EventArgs e)
        {
            LoadListView();

        }

        void LoadImgList()
        {
            imageListLarge = new ImageList() { ImageSize = new Size(280, 200) };
        }

        void LoadListView()
        {
            try
            {
                LoadImgList();

                List<Product> products = productService.GetAllProduct();
                listViewShow.LargeImageList = imageListLarge;
                int index = 0;
                foreach (var item in products)
                {
                    ListViewItem itemView = new ListViewItem();
                    itemView.Text = (item.ProductName + "-" + (item.Price).ToString());
                    itemView.Name = item.ProductId;
                    imageListLarge.Images.Add(new Bitmap(Application.StartupPath + "BirdCageResources\\" + item.ProductId + ".jpg"));
                    itemView.ImageIndex = index;
                    listViewShow.Items.Add(itemView);
                    index += 1;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btn_addToCart_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetail orderDetail = new OrderDetail();
                orderDetail.ProductId = listViewShow.SelectedItems[0].Name;
                orderDetail.Quantity = 1;
                txt_search.Text = listViewShow.SelectedItems[0].Name;
                if (listCartDetail.IsNullOrEmpty())
                {
                    listCartDetail.Add(orderDetail);
                }
                else
                {
                    OrderDetail exitItem = listCartDetail.Find(c => c.ProductId.Equals(orderDetail.ProductId));

                    if (exitItem != null)
                    {
                        exitItem.Quantity++;
                    }
                    else
                    {
                        listCartDetail.Add(orderDetail);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void btn_viewCart_Click(object sender, EventArgs e)
        {
            try
            {
                CartForm cartForm = new CartForm();
                cartForm.listCart = listCartDetail;
                cartForm.ShowDialog();
                this.Hide();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
