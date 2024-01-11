namespace frmAdmin
{
    partial class frmLoaiSanPham
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnXoaLSP = new System.Windows.Forms.Button();
            this.btnSuaLSP = new System.Windows.Forms.Button();
            this.btnThemLSP = new System.Windows.Forms.Button();
            this.dgvQLLSP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGhiChuLSP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.picLogoQLSP = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenLSP = new System.Windows.Forms.TextBox();
            this.txtMaLSP = new System.Windows.Forms.TextBox();
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.pnLoaiSANPHAM = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnLOGOQLNV = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picQLNV = new System.Windows.Forms.PictureBox();
            this.loaiSanPhamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.đồÁnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnDgvTCLSP = new System.Windows.Forms.Panel();
            this.btnTimkiemLSP = new System.Windows.Forms.Button();
            this.txtTimkiemLSP = new System.Windows.Forms.TextBox();
            this.pnThongtinLSP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLSP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoQLSP)).BeginInit();
            this.pnLoaiSANPHAM.SuspendLayout();
            this.pnLOGOQLNV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQLNV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.đồÁnDataSetBindingSource)).BeginInit();
            this.pnDgvTCLSP.SuspendLayout();
            this.pnThongtinLSP.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLamMoi.Image = global::frmAdmin.Properties.Resources.refresh__2_;
            this.btnLamMoi.Location = new System.Drawing.Point(409, 521);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(109, 84);
            this.btnLamMoi.TabIndex = 7;
            this.toolTip2.SetToolTip(this.btnLamMoi, "Làm mới");
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnXoaLSP
            // 
            this.btnXoaLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnXoaLSP.Image = global::frmAdmin.Properties.Resources.delete__1_;
            this.btnXoaLSP.Location = new System.Drawing.Point(275, 519);
            this.btnXoaLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaLSP.Name = "btnXoaLSP";
            this.btnXoaLSP.Size = new System.Drawing.Size(109, 84);
            this.btnXoaLSP.TabIndex = 6;
            this.toolTip2.SetToolTip(this.btnXoaLSP, "Xóa");
            this.btnXoaLSP.UseVisualStyleBackColor = true;
            this.btnXoaLSP.Click += new System.EventHandler(this.btnXoaLSP_Click);
            // 
            // btnSuaLSP
            // 
            this.btnSuaLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSuaLSP.Image = global::frmAdmin.Properties.Resources.edit;
            this.btnSuaLSP.Location = new System.Drawing.Point(148, 523);
            this.btnSuaLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaLSP.Name = "btnSuaLSP";
            this.btnSuaLSP.Size = new System.Drawing.Size(109, 80);
            this.btnSuaLSP.TabIndex = 5;
            this.toolTip2.SetToolTip(this.btnSuaLSP, "Sửa");
            this.btnSuaLSP.UseVisualStyleBackColor = true;
            this.btnSuaLSP.Click += new System.EventHandler(this.btnSuaLSP_Click);
            // 
            // btnThemLSP
            // 
            this.btnThemLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThemLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemLSP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnThemLSP.Image = global::frmAdmin.Properties.Resources.addition;
            this.btnThemLSP.Location = new System.Drawing.Point(9, 523);
            this.btnThemLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemLSP.Name = "btnThemLSP";
            this.btnThemLSP.Size = new System.Drawing.Size(109, 80);
            this.btnThemLSP.TabIndex = 4;
            this.toolTip2.SetToolTip(this.btnThemLSP, "Thêm");
            this.btnThemLSP.UseVisualStyleBackColor = true;
            this.btnThemLSP.Click += new System.EventHandler(this.btnThemLSP_Click);
            // 
            // dgvQLLSP
            // 
            this.dgvQLLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLLSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLLSP.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLLSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLLSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvQLLSP.Location = new System.Drawing.Point(52, 199);
            this.dgvQLLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQLLSP.Name = "dgvQLLSP";
            this.dgvQLLSP.RowHeadersWidth = 51;
            this.dgvQLLSP.Size = new System.Drawing.Size(771, 434);
            this.dgvQLLSP.TabIndex = 0;
            this.toolTip2.SetToolTip(this.dgvQLLSP, "DANH SÁCH SẢN PHẨM");
            this.dgvQLLSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLLSP_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MALOAISP";
            this.Column1.HeaderText = "Mã loại sản phẩm";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN";
            this.Column2.HeaderText = "Tên loại sản phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GHICHU";
            this.Column3.HeaderText = "Ghi chú";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // txtGhiChuLSP
            // 
            this.txtGhiChuLSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChuLSP.Location = new System.Drawing.Point(148, 172);
            this.txtGhiChuLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGhiChuLSP.Multiline = true;
            this.txtGhiChuLSP.Name = "txtGhiChuLSP";
            this.txtGhiChuLSP.Size = new System.Drawing.Size(348, 262);
            this.txtGhiChuLSP.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(20, 172);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 26);
            this.label10.TabIndex = 38;
            this.label10.Text = "Ghi chú";
            // 
            // picLogoQLSP
            // 
            this.picLogoQLSP.Image = global::frmAdmin.Properties.Resources.new_product;
            this.picLogoQLSP.Location = new System.Drawing.Point(52, 30);
            this.picLogoQLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogoQLSP.Name = "picLogoQLSP";
            this.picLogoQLSP.Size = new System.Drawing.Size(79, 62);
            this.picLogoQLSP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoQLSP.TabIndex = 1;
            this.picLogoQLSP.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(20, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "Mã loại sản phẩm";
            // 
            // txtTenLSP
            // 
            this.txtTenLSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLSP.Location = new System.Drawing.Point(255, 95);
            this.txtTenLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenLSP.Name = "txtTenLSP";
            this.txtTenLSP.Size = new System.Drawing.Size(241, 35);
            this.txtTenLSP.TabIndex = 2;
            // 
            // txtMaLSP
            // 
            this.txtMaLSP.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLSP.Location = new System.Drawing.Point(255, 27);
            this.txtMaLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaLSP.Name = "txtMaLSP";
            this.txtMaLSP.ReadOnly = true;
            this.txtMaLSP.Size = new System.Drawing.Size(185, 35);
            this.txtMaLSP.TabIndex = 1;
            this.txtMaLSP.TextChanged += new System.EventHandler(this.txtMaLSP_TextChanged);
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // pnLoaiSANPHAM
            // 
            this.pnLoaiSANPHAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnLoaiSANPHAM.Controls.Add(this.picLogoQLSP);
            this.pnLoaiSANPHAM.Controls.Add(this.label2);
            this.pnLoaiSANPHAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLoaiSANPHAM.Location = new System.Drawing.Point(0, 0);
            this.pnLoaiSANPHAM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLoaiSANPHAM.Name = "pnLoaiSANPHAM";
            this.pnLoaiSANPHAM.Size = new System.Drawing.Size(866, 122);
            this.pnLoaiSANPHAM.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(180, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "LOẠI SẢN PHẨM";
            // 
            // pnLOGOQLNV
            // 
            this.pnLOGOQLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnLOGOQLNV.Controls.Add(this.label1);
            this.pnLOGOQLNV.Controls.Add(this.picQLNV);
            this.pnLOGOQLNV.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnLOGOQLNV.Location = new System.Drawing.Point(0, 0);
            this.pnLOGOQLNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnLOGOQLNV.Name = "pnLOGOQLNV";
            this.pnLOGOQLNV.Size = new System.Drawing.Size(866, 0);
            this.pnLOGOQLNV.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 38);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // picQLNV
            // 
            this.picQLNV.Image = global::frmAdmin.Properties.Resources.teamwork1;
            this.picQLNV.Location = new System.Drawing.Point(33, 30);
            this.picQLNV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picQLNV.Name = "picQLNV";
            this.picQLNV.Size = new System.Drawing.Size(79, 62);
            this.picQLNV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picQLNV.TabIndex = 10;
            this.picQLNV.TabStop = false;
            // 
            // loaiSanPhamBindingSource
            // 
            this.loaiSanPhamBindingSource.DataMember = "LoaiSanPham";
            this.loaiSanPhamBindingSource.DataSource = this.đồÁnDataSetBindingSource;
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "Ten";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 125;
            // 
            // pnDgvTCLSP
            // 
            this.pnDgvTCLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnDgvTCLSP.Controls.Add(this.btnTimkiemLSP);
            this.pnDgvTCLSP.Controls.Add(this.dgvQLLSP);
            this.pnDgvTCLSP.Controls.Add(this.txtTimkiemLSP);
            this.pnDgvTCLSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDgvTCLSP.Location = new System.Drawing.Point(0, 0);
            this.pnDgvTCLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnDgvTCLSP.Name = "pnDgvTCLSP";
            this.pnDgvTCLSP.Size = new System.Drawing.Size(866, 665);
            this.pnDgvTCLSP.TabIndex = 11;
            // 
            // btnTimkiemLSP
            // 
            this.btnTimkiemLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiemLSP.BackColor = System.Drawing.Color.White;
            this.btnTimkiemLSP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimkiemLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiemLSP.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemLSP.Image = global::frmAdmin.Properties.Resources.zoom__1_;
            this.btnTimkiemLSP.Location = new System.Drawing.Point(792, 144);
            this.btnTimkiemLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiemLSP.Name = "btnTimkiemLSP";
            this.btnTimkiemLSP.Size = new System.Drawing.Size(29, 28);
            this.btnTimkiemLSP.TabIndex = 7;
            this.btnTimkiemLSP.UseVisualStyleBackColor = false;
            this.btnTimkiemLSP.Click += new System.EventHandler(this.btnTimkiemLSP_Click);
            // 
            // txtTimkiemLSP
            // 
            this.txtTimkiemLSP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimkiemLSP.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemLSP.Location = new System.Drawing.Point(528, 144);
            this.txtTimkiemLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemLSP.Name = "txtTimkiemLSP";
            this.txtTimkiemLSP.Size = new System.Drawing.Size(295, 38);
            this.txtTimkiemLSP.TabIndex = 6;
            // 
            // pnThongtinLSP
            // 
            this.pnThongtinLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnThongtinLSP.Controls.Add(this.txtGhiChuLSP);
            this.pnThongtinLSP.Controls.Add(this.label10);
            this.pnThongtinLSP.Controls.Add(this.btnLamMoi);
            this.pnThongtinLSP.Controls.Add(this.label3);
            this.pnThongtinLSP.Controls.Add(this.label7);
            this.pnThongtinLSP.Controls.Add(this.btnXoaLSP);
            this.pnThongtinLSP.Controls.Add(this.btnSuaLSP);
            this.pnThongtinLSP.Controls.Add(this.btnThemLSP);
            this.pnThongtinLSP.Controls.Add(this.txtTenLSP);
            this.pnThongtinLSP.Controls.Add(this.txtMaLSP);
            this.pnThongtinLSP.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnThongtinLSP.Location = new System.Drawing.Point(866, 0);
            this.pnThongtinLSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnThongtinLSP.Name = "pnThongtinLSP";
            this.pnThongtinLSP.Size = new System.Drawing.Size(535, 665);
            this.pnThongtinLSP.TabIndex = 9;
            // 
            // frmLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 665);
            this.Controls.Add(this.pnLoaiSANPHAM);
            this.Controls.Add(this.pnLOGOQLNV);
            this.Controls.Add(this.pnDgvTCLSP);
            this.Controls.Add(this.pnThongtinLSP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLoaiSanPham";
            this.Text = "Loại sản phẩm";
            this.Load += new System.EventHandler(this.frmLoaiSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLLSP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoQLSP)).EndInit();
            this.pnLoaiSANPHAM.ResumeLayout(false);
            this.pnLoaiSANPHAM.PerformLayout();
            this.pnLOGOQLNV.ResumeLayout(false);
            this.pnLOGOQLNV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picQLNV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiSanPhamBindingSource)).EndInit();
            this.pnDgvTCLSP.ResumeLayout(false);
            this.pnDgvTCLSP.PerformLayout();
            this.pnThongtinLSP.ResumeLayout(false);
            this.pnThongtinLSP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnXoaLSP;
        private System.Windows.Forms.Button btnSuaLSP;
        private System.Windows.Forms.Button btnThemLSP;
        private System.Windows.Forms.DataGridView dgvQLLSP;
        private System.Windows.Forms.TextBox txtGhiChuLSP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picLogoQLSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenLSP;
        private System.Windows.Forms.TextBox txtMaLSP;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.Panel pnLoaiSANPHAM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnLOGOQLNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picQLNV;
        private System.Windows.Forms.BindingSource loaiSanPhamBindingSource;
        private System.Windows.Forms.BindingSource đồÁnDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.Panel pnDgvTCLSP;
        private System.Windows.Forms.Button btnTimkiemLSP;
        private System.Windows.Forms.TextBox txtTimkiemLSP;
        private System.Windows.Forms.Panel pnThongtinLSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}