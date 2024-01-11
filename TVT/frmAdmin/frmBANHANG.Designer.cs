namespace frmAdmin
{
    partial class frmBANHANG
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
            this.components = new System.ComponentModel.Container();
            this.txtTimkiemSP = new System.Windows.Forms.TextBox();
            this.pnDgvBANHANG = new System.Windows.Forms.Panel();
            this.lstDSSP = new System.Windows.Forms.ListView();
            this.colTenSP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDonGia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSoLuong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMoTa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imgSP = new System.Windows.Forms.ImageList(this.components);
            this.btnTimkiemSP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlogoBANHANG = new System.Windows.Forms.Panel();
            this.picLogoBANHANG = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numupSoluong = new System.Windows.Forms.NumericUpDown();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.pnTHONGTINBANHANG = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.picAnhSP = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnDgvBANHANG.SuspendLayout();
            this.pnlogoBANHANG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBANHANG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupSoluong)).BeginInit();
            this.pnTHONGTINBANHANG.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimkiemSP
            // 
            this.txtTimkiemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimkiemSP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemSP.Location = new System.Drawing.Point(662, 27);
            this.txtTimkiemSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimkiemSP.Name = "txtTimkiemSP";
            this.txtTimkiemSP.Size = new System.Drawing.Size(336, 38);
            this.txtTimkiemSP.TabIndex = 6;
            this.toolTip1.SetToolTip(this.txtTimkiemSP, "TÌM KIẾM SẢN PHẨM");
            this.txtTimkiemSP.TextChanged += new System.EventHandler(this.txtTimkiemSP_TextChanged);
            // 
            // pnDgvBANHANG
            // 
            this.pnDgvBANHANG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnDgvBANHANG.Controls.Add(this.lstDSSP);
            this.pnDgvBANHANG.Controls.Add(this.btnTimkiemSP);
            this.pnDgvBANHANG.Controls.Add(this.txtTimkiemSP);
            this.pnDgvBANHANG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDgvBANHANG.Location = new System.Drawing.Point(0, 122);
            this.pnDgvBANHANG.Margin = new System.Windows.Forms.Padding(4);
            this.pnDgvBANHANG.Name = "pnDgvBANHANG";
            this.pnDgvBANHANG.Size = new System.Drawing.Size(1038, 625);
            this.pnDgvBANHANG.TabIndex = 6;
            // 
            // lstDSSP
            // 
            this.lstDSSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstDSSP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colTenSP,
            this.colDonGia,
            this.colSoLuong,
            this.colMoTa});
            this.lstDSSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstDSSP.FullRowSelect = true;
            this.lstDSSP.HideSelection = false;
            this.lstDSSP.LargeImageList = this.imgSP;
            this.lstDSSP.Location = new System.Drawing.Point(31, 80);
            this.lstDSSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstDSSP.Name = "lstDSSP";
            this.lstDSSP.Size = new System.Drawing.Size(968, 518);
            this.lstDSSP.SmallImageList = this.imgSP;
            this.lstDSSP.TabIndex = 1;
            this.toolTip1.SetToolTip(this.lstDSSP, "DANH SÁCH SẢN PHẨM");
            this.lstDSSP.UseCompatibleStateImageBehavior = false;
            this.lstDSSP.View = System.Windows.Forms.View.Details;
            this.lstDSSP.SelectedIndexChanged += new System.EventHandler(this.lstDSSP_SelectedIndexChanged);
            // 
            // colTenSP
            // 
            this.colTenSP.Text = "Tên";
            this.colTenSP.Width = 424;
            // 
            // colDonGia
            // 
            this.colDonGia.Text = "Đơn giá";
            this.colDonGia.Width = 167;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Text = "Số lượng";
            this.colSoLuong.Width = 168;
            // 
            // colMoTa
            // 
            this.colMoTa.Text = "Mô tả";
            this.colMoTa.Width = 174;
            // 
            // imgSP
            // 
            this.imgSP.ColorDepth = System.Windows.Forms.ColorDepth.Depth24Bit;
            this.imgSP.ImageSize = new System.Drawing.Size(120, 120);
            this.imgSP.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnTimkiemSP
            // 
            this.btnTimkiemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiemSP.BackColor = System.Drawing.Color.White;
            this.btnTimkiemSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimkiemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiemSP.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemSP.Image = global::frmAdmin.Properties.Resources.zoom__1_;
            this.btnTimkiemSP.Location = new System.Drawing.Point(939, 27);
            this.btnTimkiemSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimkiemSP.Name = "btnTimkiemSP";
            this.btnTimkiemSP.Size = new System.Drawing.Size(48, 28);
            this.btnTimkiemSP.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnTimkiemSP, "TÌM KIẾM SẢN PHẨN");
            this.btnTimkiemSP.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(180, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÁN HÀNG";
            // 
            // pnlogoBANHANG
            // 
            this.pnlogoBANHANG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnlogoBANHANG.Controls.Add(this.picLogoBANHANG);
            this.pnlogoBANHANG.Controls.Add(this.label1);
            this.pnlogoBANHANG.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlogoBANHANG.Location = new System.Drawing.Point(0, 0);
            this.pnlogoBANHANG.Margin = new System.Windows.Forms.Padding(4);
            this.pnlogoBANHANG.Name = "pnlogoBANHANG";
            this.pnlogoBANHANG.Size = new System.Drawing.Size(1038, 122);
            this.pnlogoBANHANG.TabIndex = 5;
            // 
            // picLogoBANHANG
            // 
            this.picLogoBANHANG.Image = global::frmAdmin.Properties.Resources.buy__1_;
            this.picLogoBANHANG.Location = new System.Drawing.Point(52, 30);
            this.picLogoBANHANG.Margin = new System.Windows.Forms.Padding(4);
            this.picLogoBANHANG.Name = "picLogoBANHANG";
            this.picLogoBANHANG.Size = new System.Drawing.Size(79, 62);
            this.picLogoBANHANG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoBANHANG.TabIndex = 1;
            this.picLogoBANHANG.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(58, 525);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(63, 413);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "Đơn giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(58, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên sản phẩm";
            // 
            // numupSoluong
            // 
            this.numupSoluong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numupSoluong.Location = new System.Drawing.Point(256, 525);
            this.numupSoluong.Margin = new System.Windows.Forms.Padding(4);
            this.numupSoluong.Name = "numupSoluong";
            this.numupSoluong.Size = new System.Drawing.Size(76, 35);
            this.numupSoluong.TabIndex = 4;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(63, 463);
            this.txtGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtGia.Name = "txtGia";
            this.txtGia.ReadOnly = true;
            this.txtGia.Size = new System.Drawing.Size(269, 35);
            this.txtGia.TabIndex = 3;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(63, 350);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.ReadOnly = true;
            this.txtTenSP.Size = new System.Drawing.Size(273, 35);
            this.txtTenSP.TabIndex = 2;
            // 
            // pnTHONGTINBANHANG
            // 
            this.pnTHONGTINBANHANG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnTHONGTINBANHANG.Controls.Add(this.label6);
            this.pnTHONGTINBANHANG.Controls.Add(this.label5);
            this.pnTHONGTINBANHANG.Controls.Add(this.label4);
            this.pnTHONGTINBANHANG.Controls.Add(this.label3);
            this.pnTHONGTINBANHANG.Controls.Add(this.btnThemSP);
            this.pnTHONGTINBANHANG.Controls.Add(this.numupSoluong);
            this.pnTHONGTINBANHANG.Controls.Add(this.txtGia);
            this.pnTHONGTINBANHANG.Controls.Add(this.txtTenSP);
            this.pnTHONGTINBANHANG.Controls.Add(this.picAnhSP);
            this.pnTHONGTINBANHANG.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnTHONGTINBANHANG.Location = new System.Drawing.Point(1038, 0);
            this.pnTHONGTINBANHANG.Margin = new System.Windows.Forms.Padding(4);
            this.pnTHONGTINBANHANG.Name = "pnTHONGTINBANHANG";
            this.pnTHONGTINBANHANG.Size = new System.Drawing.Size(483, 747);
            this.pnTHONGTINBANHANG.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(355, 472);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 26);
            this.label6.TabIndex = 14;
            this.label6.Text = "VNĐ";
            // 
            // btnThemSP
            // 
            this.btnThemSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnThemSP.Image = global::frmAdmin.Properties.Resources.addition;
            this.btnThemSP.Location = new System.Drawing.Point(199, 617);
            this.btnThemSP.Margin = new System.Windows.Forms.Padding(4);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(107, 94);
            this.btnThemSP.TabIndex = 5;
            this.toolTip1.SetToolTip(this.btnThemSP, "THÊM SẢN PHẨM VÀO GIỎ HÀNG");
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // picAnhSP
            // 
            this.picAnhSP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAnhSP.Location = new System.Drawing.Point(93, 14);
            this.picAnhSP.Margin = new System.Windows.Forms.Padding(4);
            this.picAnhSP.Name = "picAnhSP";
            this.picAnhSP.Size = new System.Drawing.Size(286, 235);
            this.picAnhSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnhSP.TabIndex = 2;
            this.picAnhSP.TabStop = false;
            this.toolTip1.SetToolTip(this.picAnhSP, "ẢNH SẢN PHẨM");
            // 
            // frmBANHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1521, 747);
            this.Controls.Add(this.pnDgvBANHANG);
            this.Controls.Add(this.pnlogoBANHANG);
            this.Controls.Add(this.pnTHONGTINBANHANG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmBANHANG";
            this.Text = "frmBANHANG";
            this.Load += new System.EventHandler(this.frmBANHANG_Load);
            this.pnDgvBANHANG.ResumeLayout(false);
            this.pnDgvBANHANG.PerformLayout();
            this.pnlogoBANHANG.ResumeLayout(false);
            this.pnlogoBANHANG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoBANHANG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupSoluong)).EndInit();
            this.pnTHONGTINBANHANG.ResumeLayout(false);
            this.pnTHONGTINBANHANG.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picAnhSP;
        private System.Windows.Forms.PictureBox picLogoBANHANG;
        private System.Windows.Forms.Button btnTimkiemSP;
        private System.Windows.Forms.TextBox txtTimkiemSP;
        private System.Windows.Forms.Panel pnDgvBANHANG;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlogoBANHANG;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.NumericUpDown numupSoluong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Panel pnTHONGTINBANHANG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imgSP;
        private System.Windows.Forms.ListView lstDSSP;
        private System.Windows.Forms.ColumnHeader colTenSP;
        private System.Windows.Forms.ColumnHeader colDonGia;
        private System.Windows.Forms.ColumnHeader colSoLuong;
        private System.Windows.Forms.ColumnHeader colMoTa;
    }
}