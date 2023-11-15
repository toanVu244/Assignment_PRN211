namespace BirdCageShopGUI
{
    partial class CartForm
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
            btn_Checkout = new Button();
            btn_back = new Button();
            groupBox1 = new GroupBox();
            listViewCart = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            txt_totalPrice = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Checkout
            // 
            btn_Checkout.Location = new Point(495, 345);
            btn_Checkout.Name = "btn_Checkout";
            btn_Checkout.Size = new Size(102, 51);
            btn_Checkout.TabIndex = 5;
            btn_Checkout.Text = "Check out";
            btn_Checkout.UseVisualStyleBackColor = true;
            btn_Checkout.Click += btn_Checkout_Click;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(197, 345);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(102, 51);
            btn_back.TabIndex = 4;
            btn_back.Text = "HomePage";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(listViewCart);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 270);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            // 
            // listViewCart
            // 
            listViewCart.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewCart.Location = new Point(6, 16);
            listViewCart.Name = "listViewCart";
            listViewCart.Size = new Size(764, 248);
            listViewCart.TabIndex = 0;
            listViewCart.UseCompatibleStateImageBehavior = false;
            listViewCart.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "STT";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "ProductName";
            columnHeader2.Width = 550;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Amount";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Price";
            columnHeader4.Width = 80;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(505, 285);
            label1.Name = "label1";
            label1.Size = new Size(81, 20);
            label1.TabIndex = 6;
            label1.Text = "Total Price:";
            // 
            // txt_totalPrice
            // 
            txt_totalPrice.Location = new Point(592, 282);
            txt_totalPrice.Name = "txt_totalPrice";
            txt_totalPrice.Size = new Size(190, 27);
            txt_totalPrice.TabIndex = 7;
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_totalPrice);
            Controls.Add(label1);
            Controls.Add(btn_Checkout);
            Controls.Add(btn_back);
            Controls.Add(groupBox1);
            Name = "CartForm";
            Text = "CartForm";
            Load += CartForm_Load;
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Checkout;
        private Button btn_back;
        private GroupBox groupBox1;
        private ListView listViewCart;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
        private TextBox txt_totalPrice;
    }
}