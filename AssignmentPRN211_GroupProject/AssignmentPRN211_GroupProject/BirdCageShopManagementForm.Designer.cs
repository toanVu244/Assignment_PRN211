namespace BirdCageShopGUI
{
    partial class BirdCageShopManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            listViewShow = new ListView();
            groupBox1 = new GroupBox();
            btn_addToCart = new Button();
            btn_viewCart = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            Search = new Button();
            txt_search = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewShow);
            groupBox2.Location = new Point(126, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1041, 663);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            // 
            // listViewShow
            // 
            listViewShow.FullRowSelect = true;
            listViewShow.GridLines = true;
            listViewShow.Location = new Point(6, 16);
            listViewShow.Name = "listViewShow";
            listViewShow.Size = new Size(1029, 647);
            listViewShow.TabIndex = 0;
            listViewShow.UseCompatibleStateImageBehavior = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_addToCart);
            groupBox1.Controls.Add(btn_viewCart);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(Search);
            groupBox1.Controls.Add(txt_search);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1255, 137);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // btn_addToCart
            // 
            btn_addToCart.Location = new Point(1031, 93);
            btn_addToCart.Name = "btn_addToCart";
            btn_addToCart.Size = new Size(103, 29);
            btn_addToCart.TabIndex = 6;
            btn_addToCart.Text = "Add to Cart";
            btn_addToCart.UseVisualStyleBackColor = true;
            btn_addToCart.Click += btn_addToCart_Click;
            // 
            // btn_viewCart
            // 
            btn_viewCart.Location = new Point(1138, 93);
            btn_viewCart.Name = "btn_viewCart";
            btn_viewCart.Size = new Size(103, 29);
            btn_viewCart.TabIndex = 5;
            btn_viewCart.Text = "View Cart";
            btn_viewCart.UseVisualStyleBackColor = true;
            btn_viewCart.Click += btn_viewCart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1039, 46);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 3;
            label3.Text = "033.746.5358";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(983, 46);
            label2.Name = "label2";
            label2.Size = new Size(42, 20);
            label2.TabIndex = 2;
            label2.Text = "SDT: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(983, 14);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 1;
            label1.Text = "Gmail:";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(1039, 14);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(202, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "thegioilongchim@gmail.com";
            // 
            // Search
            // 
            Search.Location = new Point(871, 13);
            Search.Name = "Search";
            Search.Size = new Size(78, 35);
            Search.TabIndex = 1;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            Search.Click += Search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(114, 11);
            txt_search.Multiline = true;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(740, 37);
            txt_search.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(6, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 80);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BirdCageShopManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1279, 830);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "BirdCageShopManagementForm";
            Text = "BirdCageShopManagement";
            Load += BirdCageShopManagementForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private ListView listViewShow;
        private GroupBox groupBox1;
        private Button btn_addToCart;
        private Button btn_viewCart;
        private Label label3;
        private Label label2;
        private Label label1;
        private LinkLabel linkLabel1;
        private Button Search;
        private TextBox txt_search;
        private PictureBox pictureBox1;
    }
}