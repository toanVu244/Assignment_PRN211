namespace BirdCageShopGUI
{
    partial class OrderManagementForm
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
            cbx_buyMethod = new ComboBox();
            cbx_country = new ComboBox();
            txt_OrderDate = new DateTimePicker();
            txt_address = new TextBox();
            txt_orderID = new TextBox();
            txt_userID = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dtg_orderList = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label2 = new Label();
            txt_Search = new TextBox();
            btn_search = new Button();
            ((System.ComponentModel.ISupportInitialize)dtg_orderList).BeginInit();
            SuspendLayout();
            // 
            // cbx_buyMethod
            // 
            cbx_buyMethod.FormattingEnabled = true;
            cbx_buyMethod.Location = new Point(94, 204);
            cbx_buyMethod.Name = "cbx_buyMethod";
            cbx_buyMethod.Size = new Size(317, 28);
            cbx_buyMethod.TabIndex = 25;
            // 
            // cbx_country
            // 
            cbx_country.FormattingEnabled = true;
            cbx_country.Location = new Point(486, 99);
            cbx_country.Name = "cbx_country";
            cbx_country.Size = new Size(91, 28);
            cbx_country.TabIndex = 24;
            // 
            // txt_OrderDate
            // 
            txt_OrderDate.Location = new Point(94, 151);
            txt_OrderDate.Name = "txt_OrderDate";
            txt_OrderDate.Size = new Size(317, 27);
            txt_OrderDate.TabIndex = 23;
            // 
            // txt_address
            // 
            txt_address.Location = new Point(94, 99);
            txt_address.Name = "txt_address";
            txt_address.Size = new Size(317, 27);
            txt_address.TabIndex = 22;
            // 
            // txt_orderID
            // 
            txt_orderID.Location = new Point(94, 48);
            txt_orderID.Name = "txt_orderID";
            txt_orderID.Size = new Size(124, 27);
            txt_orderID.TabIndex = 21;
            // 
            // txt_userID
            // 
            txt_userID.Location = new Point(94, 6);
            txt_userID.Name = "txt_userID";
            txt_userID.Size = new Size(124, 27);
            txt_userID.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 207);
            label7.Name = "label7";
            label7.Size = new Size(64, 20);
            label7.TabIndex = 19;
            label7.Text = "Method:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(417, 102);
            label6.Name = "label6";
            label6.Size = new Size(63, 20);
            label6.TabIndex = 18;
            label6.Text = "Country:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 102);
            label5.Name = "label5";
            label5.Size = new Size(65, 20);
            label5.TabIndex = 17;
            label5.Text = "Address:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 156);
            label4.Name = "label4";
            label4.Size = new Size(82, 20);
            label4.TabIndex = 16;
            label4.Text = "OrderDate:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 52);
            label3.Name = "label3";
            label3.Size = new Size(65, 20);
            label3.TabIndex = 15;
            label3.Text = "OrderID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(56, 20);
            label1.TabIndex = 14;
            label1.Text = "UserID:";
            // 
            // dtg_orderList
            // 
            dtg_orderList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_orderList.Location = new Point(12, 288);
            dtg_orderList.Name = "dtg_orderList";
            dtg_orderList.RowHeadersWidth = 51;
            dtg_orderList.RowTemplate.Height = 29;
            dtg_orderList.Size = new Size(1128, 320);
            dtg_orderList.TabIndex = 26;
            dtg_orderList.CellClick += dtg_Order_Cellclick;
            // 
            // button1
            // 
            button1.Location = new Point(273, 627);
            button1.Name = "button1";
            button1.Size = new Size(207, 42);
            button1.TabIndex = 27;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(684, 627);
            button2.Name = "button2";
            button2.Size = new Size(207, 42);
            button2.TabIndex = 28;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 254);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 29;
            // 
            // txt_Search
            // 
            txt_Search.Location = new Point(12, 247);
            txt_Search.Name = "txt_Search";
            txt_Search.Size = new Size(1051, 27);
            txt_Search.TabIndex = 30;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(1069, 246);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(65, 29);
            btn_search.TabIndex = 31;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_Search;
            // 
            // OrderManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 679);
            Controls.Add(btn_search);
            Controls.Add(txt_Search);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dtg_orderList);
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
            Name = "OrderManagementForm";
            Text = "OrderManagementForm";
            Load += OrderManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dtg_orderList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbx_buyMethod;
        private ComboBox cbx_country;
        private DateTimePicker txt_OrderDate;
        private TextBox txt_address;
        private TextBox txt_orderID;
        private TextBox txt_userID;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dtg_orderList;
        private Button button1;
        private Button button2;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label2;
        private TextBox txt_Search;
        private Button btn_search;
    }
}