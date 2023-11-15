namespace BirdCageShopGUI
{
    partial class CheckoutForm
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
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txt_userID = new TextBox();
            txt_orderID = new TextBox();
            txt_address = new TextBox();
            txt_OrderDate = new DateTimePicker();
            cbx_country = new ComboBox();
            cbx_buyMethod = new ComboBox();
            btn_Payment = new Button();
            ckb_checkout = new CheckBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 20);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 0;
            label1.Text = "UserID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 63);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 2;
            label3.Text = "OrderID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 167);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 3;
            label4.Text = "OrderDate:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 113);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 4;
            label5.Text = "Address:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(428, 113);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 5;
            label6.Text = "Country:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(23, 218);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 6;
            label7.Text = "Method:";
            // 
            // txt_userID
            // 
            txt_userID.Location = new Point(105, 17);
            txt_userID.Name = "txt_userID";
            txt_userID.Size = new Size(124, 27);
            txt_userID.TabIndex = 7;
            // 
            // txt_orderID
            // 
            txt_orderID.Location = new Point(105, 59);
            txt_orderID.Name = "txt_orderID";
            txt_orderID.Size = new Size(124, 27);
            txt_orderID.TabIndex = 8;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(105, 110);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(317, 27);
            txt_address.TabIndex = 10;
            // 
            // txt_OrderDate
            // 
            txt_OrderDate.Location = new Point(105, 162);
            txt_OrderDate.Name = "txt_OrderDate";
            txt_OrderDate.Size = new Size(317, 27);
            txt_OrderDate.TabIndex = 11;
            // 
            // cbx_country
            // 
            cbx_country.FormattingEnabled = true;
            cbx_country.Location = new Point(497, 110);
            cbx_country.Name = "cbx_country";
            cbx_country.Size = new Size(91, 28);
            cbx_country.TabIndex = 12;
            // 
            // cbx_buyMethod
            // 
            cbx_buyMethod.FormattingEnabled = true;
            cbx_buyMethod.Location = new Point(105, 215);
            cbx_buyMethod.Name = "cbx_buyMethod";
            cbx_buyMethod.Size = new Size(317, 28);
            cbx_buyMethod.TabIndex = 13;
            // 
            // btn_Payment
            // 
            btn_Payment.Location = new Point(263, 357);
            btn_Payment.Name = "btn_Payment";
            btn_Payment.Size = new Size(247, 84);
            btn_Payment.TabIndex = 14;
            btn_Payment.Text = "Confirm Payment";
            btn_Payment.UseVisualStyleBackColor = true;
            btn_Payment.Click += btn_Payment_Click;
            // 
            // ckb_checkout
            // 
            ckb_checkout.AutoSize = true;
            ckb_checkout.Location = new Point(311, 327);
            ckb_checkout.Name = "ckb_checkout";
            ckb_checkout.Size = new Size(152, 24);
            ckb_checkout.TabIndex = 15;
            ckb_checkout.Text = "Thanh toán Online";
            ckb_checkout.UseVisualStyleBackColor = true;
            // 
            // CheckoutForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 501);
            Controls.Add(ckb_checkout);
            Controls.Add(btn_Payment);
            Controls.Add(cbx_buyMethod);
            Controls.Add(cbx_country);
            Controls.Add(txt_OrderDate);
            Controls.Add(txt_address);
            Controls.Add(txt_orderID);
            Controls.Add(txt_userID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "CheckoutForm";
            Text = "CheckoutFormcs";
            Load += CheckoutFormcs_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txt_userID;
        private TextBox txt_orderID;
        private TextBox txt_address;
        private DateTimePicker txt_OrderDate;
        private ComboBox cbx_country;
        private ComboBox cbx_buyMethod;
        private Button btn_Payment;
        private CheckBox ckb_checkout;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}