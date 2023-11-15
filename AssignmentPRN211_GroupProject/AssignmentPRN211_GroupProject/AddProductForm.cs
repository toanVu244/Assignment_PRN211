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
    public partial class AddProductForm : Form
    {
        private IProductService _productService;
        public AddProductForm()
        {
            _productService = new ProductService();
            InitializeComponent();
        }

        private void btn_loadimg_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                txt_PathPic.Text = open.FileName;
                picbox.Image = new Bitmap(open.FileName);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            try
            {
                Product product = new Product();

                product.ProductId = _productService.GetProductIdvalid();
                product.ProductMaterial = txt_material.Text;
                product.ProductName = txt_name.Text;
                product.BirdType = txt_birdtype.Text;
                product.Model = txt_model.Text;
                product.Price = decimal.Parse(txt_price.Text);
                product.Description = txt_descrip.Text;
                product.Size = decimal.ToInt32(nd_size.Value);
                product.BirdCageType = txt_cagetype.Text;
                product.Status = 1;
                _productService.AddProduct(product);
                File.Copy(txt_PathPic.Text, Path.Combine(Application.StartupPath + "BirdCageResources\\", Path.GetFileName(product.ProductId + ".jpg")), true);
                MessageBox.Show("update success!!!");
            }
            catch
            {
                MessageBox.Show("Error!!!");
            }



        }

        private void picbox_Click(object sender, EventArgs e)
        {

        }
    }
}
