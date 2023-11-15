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
    public partial class AdminForm : Form
    {
        private IProductService productService;
        public List<OrderDetail> listCartDetail;
        ImageList imageListLarge;

        String[] a = { "còn hàng", "hết hàng" };
        public AdminForm()
        {
            InitializeComponent();
            productService = new ProductService();
            if (listCartDetail.IsNullOrEmpty())
            {
                listCartDetail = new List<OrderDetail>();
            }
        }

        private void AdminForm_Load(object sender, EventArgs e)
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

        private void listViewShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbb_status.DataSource = a;
            if (listViewShow.SelectedItems.Count > 0)
            {
                string select = listViewShow.SelectedItems[0].Name;
                Product product = productService.GetProductById(select);
                if (product != null)
                {
                    txt_id.Text = product.ProductId;
                    txt_name.Text = product.ProductName;
                    txt_birdtype.Text = product.BirdType;
                    txt_model.Text = product.Model;
                    txt_price.Text = product.Price.ToString();
                    txt_descrip.Text = product.Description;

                    if (product.Status == 1)
                    {
                        cbb_status.Text = "còn hàng";
                    }
                    else
                    {
                        cbb_status.Text = "hết hàng";
                    }
                    picbox.Image = new Bitmap(Application.StartupPath + "BirdCageResources\\" + product.ProductId + ".jpg");
                    nd_size.Text = product.Size.ToString();
                    txt_material.Text = product.ProductMaterial;
                    txt_cagetype.Text = product.BirdCageType;
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_loadimg_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddProductForm addProductForm = new AddProductForm();
            addProductForm.ShowDialog();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            product.ProductId = txt_id.Text;
            product.ProductMaterial = txt_material.Text;
            product.ProductName = txt_name.Text;
            product.BirdType = txt_birdtype.Text;
            product.Model = txt_model.Text;
            product.Price = Decimal.Parse(txt_price.Text.Trim());
            product.Description = txt_descrip.Text;
            product.Size = Decimal.ToInt32(nd_size.Value);
            product.BirdCageType = txt_cagetype.Text;
            if (cbb_status.Text.Equals("còn hàng"))
            {
                product.Status = 1;
            }
            else
            {
                product.Status = 0;
            }
            productService.UpdateProduct(product);

            MessageBox.Show("update success!!!");
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            listViewShow.Items.Clear();
            LoadListView();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                String id = txt_id.Text;
                if (!string.IsNullOrEmpty(id))
                {
                    MessageBox.Show("xóa sản phẩm ???");
                }
                productService.DeleteProduct(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show("xóa thất bại");
            }

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            
                listViewShow.Items.Clear();

                
                String key = txt_search.Text;
                List<Product> products = productService.SearchProduct(key);

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
    }
}
