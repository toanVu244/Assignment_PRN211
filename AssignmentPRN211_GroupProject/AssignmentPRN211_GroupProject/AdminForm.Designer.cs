namespace BirdCageShopGUI
{
    partial class AdminForm
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
            btn_load = new Button();
            btn_search = new Button();
            txt_search = new TextBox();
            pictureBox1 = new PictureBox();
            txt_id = new TextBox();
            txt_name = new TextBox();
            txt_birdtype = new TextBox();
            txt_model = new TextBox();
            txt_price = new TextBox();
            txt_descrip = new TextBox();
            txt_material = new TextBox();
            txt_cagetype = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            groupBox3 = new GroupBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            cbb_status = new ComboBox();
            nd_size = new NumericUpDown();
            picbox = new PictureBox();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nd_size).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listViewShow);
            groupBox2.Location = new Point(3, 122);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1051, 700);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // listViewShow
            // 
            listViewShow.FullRowSelect = true;
            listViewShow.GridLines = true;
            listViewShow.Location = new Point(5, 26);
            listViewShow.Name = "listViewShow";
            listViewShow.Size = new Size(1040, 647);
            listViewShow.TabIndex = 0;
            listViewShow.UseCompatibleStateImageBehavior = false;
            listViewShow.SelectedIndexChanged += listViewShow_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btn_load);
            groupBox1.Controls.Add(btn_search);
            groupBox1.Controls.Add(txt_search);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(3, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1275, 100);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            // 
            // btn_load
            // 
            btn_load.Location = new Point(114, 62);
            btn_load.Name = "btn_load";
            btn_load.Size = new Size(94, 29);
            btn_load.TabIndex = 2;
            btn_load.Text = "load";
            btn_load.UseVisualStyleBackColor = true;
            btn_load.Click += btn_load_Click;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(1128, 13);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(141, 35);
            btn_search.TabIndex = 1;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // txt_search
            // 
            txt_search.Location = new Point(114, 11);
            txt_search.Multiline = true;
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(1008, 37);
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
            // txt_id
            // 
            txt_id.Location = new Point(1143, 122);
            txt_id.Name = "txt_id";
            txt_id.ReadOnly = true;
            txt_id.Size = new Size(158, 27);
            txt_id.TabIndex = 6;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(1143, 155);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(158, 27);
            txt_name.TabIndex = 7;
            // 
            // txt_birdtype
            // 
            txt_birdtype.Location = new Point(1143, 188);
            txt_birdtype.Name = "txt_birdtype";
            txt_birdtype.Size = new Size(158, 27);
            txt_birdtype.TabIndex = 8;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(1143, 221);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(158, 27);
            txt_model.TabIndex = 9;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(1143, 254);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(158, 27);
            txt_price.TabIndex = 10;
            // 
            // txt_descrip
            // 
            txt_descrip.Location = new Point(1143, 287);
            txt_descrip.Multiline = true;
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(158, 55);
            txt_descrip.TabIndex = 11;
            // 
            // txt_material
            // 
            txt_material.Location = new Point(1143, 417);
            txt_material.Name = "txt_material";
            txt_material.Size = new Size(158, 27);
            txt_material.TabIndex = 14;
            // 
            // txt_cagetype
            // 
            txt_cagetype.Location = new Point(1143, 450);
            txt_cagetype.Name = "txt_cagetype";
            txt_cagetype.Size = new Size(158, 27);
            txt_cagetype.TabIndex = 15;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(6, 26);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(158, 29);
            btn_add.TabIndex = 16;
            btn_add.Text = "ADD";
            btn_add.UseVisualStyleBackColor = true;
            btn_add.Click += btn_add_Click;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(6, 61);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(155, 29);
            btn_update.TabIndex = 17;
            btn_update.Text = "UPDATE";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(9, 96);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(155, 29);
            btn_delete.TabIndex = 18;
            btn_delete.Text = "DELETE";
            btn_delete.UseVisualStyleBackColor = true;
            btn_delete.Click += btn_delete_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_add);
            groupBox3.Controls.Add(btn_delete);
            groupBox3.Controls.Add(btn_update);
            groupBox3.Location = new Point(1064, 676);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(237, 136);
            groupBox3.TabIndex = 19;
            groupBox3.TabStop = false;
            groupBox3.Text = "Action";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1064, 129);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 20;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1064, 162);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 21;
            label2.Text = "Name";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1060, 195);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 22;
            label3.Text = "Birth Type";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1064, 228);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 23;
            label4.Text = "Model";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(1064, 261);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 24;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1064, 322);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 25;
            label6.Text = "Desciption";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(1064, 355);
            label7.Name = "label7";
            label7.Size = new Size(47, 20);
            label7.TabIndex = 26;
            label7.Text = "status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(1064, 391);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 27;
            label8.Text = "size";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(1064, 424);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 28;
            label9.Text = "Material";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1064, 457);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 29;
            label10.Text = "Type";
            // 
            // cbb_status
            // 
            cbb_status.FormattingEnabled = true;
            cbb_status.Location = new Point(1143, 347);
            cbb_status.Name = "cbb_status";
            cbb_status.Size = new Size(151, 28);
            cbb_status.TabIndex = 30;
            // 
            // nd_size
            // 
            nd_size.Location = new Point(1143, 384);
            nd_size.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nd_size.Name = "nd_size";
            nd_size.Size = new Size(150, 27);
            nd_size.TabIndex = 31;
            // 
            // picbox
            // 
            picbox.Location = new Point(1073, 483);
            picbox.Name = "picbox";
            picbox.Size = new Size(227, 187);
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 32;
            picbox.TabStop = false;
            // 
            // AdminForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1313, 824);
            Controls.Add(picbox);
            Controls.Add(nd_size);
            Controls.Add(cbb_status);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(groupBox3);
            Controls.Add(txt_cagetype);
            Controls.Add(txt_material);
            Controls.Add(txt_descrip);
            Controls.Add(txt_price);
            Controls.Add(txt_model);
            Controls.Add(txt_birdtype);
            Controls.Add(txt_name);
            Controls.Add(txt_id);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "AdminForm";
            Text = "AdminForm";
            Load += AdminForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nd_size).EndInit();
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox2;
        private ListView listViewShow;
        private GroupBox groupBox1;
        private Button btn_search;
        private TextBox txt_search;
        private PictureBox pictureBox1;
        private TextBox txt_id;
        private TextBox txt_name;
        private TextBox txt_birdtype;
        private TextBox txt_model;
        private TextBox txt_price;
        private TextBox txt_descrip;
        private TextBox txt_material;
        private TextBox txt_cagetype;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private GroupBox groupBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private ComboBox cbb_status;
        private NumericUpDown nd_size;
        private PictureBox picbox;
        private Button btn_load;
    }
}