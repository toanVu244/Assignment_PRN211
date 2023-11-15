namespace BirdCageShopGUI
{
    partial class AddProductForm
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
            btn_loadimg = new Button();
            picbox = new PictureBox();
            nd_size = new NumericUpDown();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txt_cagetype = new TextBox();
            txt_material = new TextBox();
            txt_descrip = new TextBox();
            txt_price = new TextBox();
            txt_model = new TextBox();
            txt_birdtype = new TextBox();
            txt_name = new TextBox();
            btn_save = new Button();
            txt_PathPic = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picbox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nd_size).BeginInit();
            SuspendLayout();
            // 
            // btn_loadimg
            // 
            btn_loadimg.Location = new Point(973, 426);
            btn_loadimg.Name = "btn_loadimg";
            btn_loadimg.Size = new Size(159, 38);
            btn_loadimg.TabIndex = 55;
            btn_loadimg.Text = "Load Image";
            btn_loadimg.UseVisualStyleBackColor = true;
            btn_loadimg.Click += btn_loadimg_Click;
            // 
            // picbox
            // 
            picbox.Image = Properties.Resources.load;
            picbox.InitialImage = Properties.Resources.load;
            picbox.Location = new Point(577, 32);
            picbox.Name = "picbox";
            picbox.Size = new Size(555, 388);
            picbox.SizeMode = PictureBoxSizeMode.StretchImage;
            picbox.TabIndex = 54;
            picbox.TabStop = false;
            picbox.Click += picbox_Click;
            // 
            // nd_size
            // 
            nd_size.Location = new Point(148, 303);
            nd_size.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            nd_size.Name = "nd_size";
            nd_size.Size = new Size(374, 27);
            nd_size.TabIndex = 53;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(69, 415);
            label10.Name = "label10";
            label10.Size = new Size(40, 20);
            label10.TabIndex = 51;
            label10.Text = "Type";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(69, 366);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 50;
            label9.Text = "Material";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 310);
            label8.Name = "label8";
            label8.Size = new Size(34, 20);
            label8.TabIndex = 49;
            label8.Text = "size";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(69, 254);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 47;
            label6.Text = "Desciption";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(69, 193);
            label5.Name = "label5";
            label5.Size = new Size(41, 20);
            label5.TabIndex = 46;
            label5.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 148);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 45;
            label4.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 96);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 44;
            label3.Text = "Birth Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 39);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 43;
            label2.Text = "Name";
            // 
            // txt_cagetype
            // 
            txt_cagetype.Location = new Point(148, 408);
            txt_cagetype.Name = "txt_cagetype";
            txt_cagetype.Size = new Size(382, 27);
            txt_cagetype.TabIndex = 41;
            // 
            // txt_material
            // 
            txt_material.Location = new Point(148, 359);
            txt_material.Name = "txt_material";
            txt_material.Size = new Size(382, 27);
            txt_material.TabIndex = 40;
            // 
            // txt_descrip
            // 
            txt_descrip.Location = new Point(148, 219);
            txt_descrip.Multiline = true;
            txt_descrip.Name = "txt_descrip";
            txt_descrip.Size = new Size(382, 55);
            txt_descrip.TabIndex = 39;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(148, 186);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(382, 27);
            txt_price.TabIndex = 38;
            // 
            // txt_model
            // 
            txt_model.Location = new Point(148, 141);
            txt_model.Name = "txt_model";
            txt_model.Size = new Size(382, 27);
            txt_model.TabIndex = 37;
            // 
            // txt_birdtype
            // 
            txt_birdtype.Location = new Point(147, 89);
            txt_birdtype.Name = "txt_birdtype";
            txt_birdtype.Size = new Size(382, 27);
            txt_birdtype.TabIndex = 36;
            // 
            // txt_name
            // 
            txt_name.Location = new Point(147, 32);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(382, 27);
            txt_name.TabIndex = 35;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(498, 464);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(135, 37);
            btn_save.TabIndex = 56;
            btn_save.Text = "save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // txt_PathPic
            // 
            txt_PathPic.Location = new Point(683, 432);
            txt_PathPic.Name = "txt_PathPic";
            txt_PathPic.ReadOnly = true;
            txt_PathPic.Size = new Size(284, 27);
            txt_PathPic.TabIndex = 57;
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1162, 548);
            Controls.Add(txt_PathPic);
            Controls.Add(btn_save);
            Controls.Add(btn_loadimg);
            Controls.Add(picbox);
            Controls.Add(nd_size);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_cagetype);
            Controls.Add(txt_material);
            Controls.Add(txt_descrip);
            Controls.Add(txt_price);
            Controls.Add(txt_model);
            Controls.Add(txt_birdtype);
            Controls.Add(txt_name);
            Name = "AddProductForm";
            Text = "AddProductForm";
            ((System.ComponentModel.ISupportInitialize)picbox).EndInit();
            ((System.ComponentModel.ISupportInitialize)nd_size).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_loadimg;
        private PictureBox picbox;
        private NumericUpDown nd_size;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txt_cagetype;
        private TextBox txt_material;
        private TextBox txt_descrip;
        private TextBox txt_price;
        private TextBox txt_model;
        private TextBox txt_birdtype;
        private TextBox txt_name;
        private Button btn_save;
        private TextBox txt_PathPic;
    }
}