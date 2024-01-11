namespace frmAdmin
{
    partial class frmNhaSanXuat
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
            this.colTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.đồÁnDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ofdImage = new System.Windows.Forms.OpenFileDialog();
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.dgvQLNSX = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bthThemNSX = new System.Windows.Forms.Button();
            this.btnSuaNSX = new System.Windows.Forms.Button();
            this.btnXoaNSX = new System.Windows.Forms.Button();
            this.btnLamMoiNSX = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnNSX = new System.Windows.Forms.Panel();
            this.picLogoNSX = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pnDgvNSX = new System.Windows.Forms.Panel();
            this.btnTimkiemNSX = new System.Windows.Forms.Button();
            this.txtTimkiemNSX = new System.Windows.Forms.TextBox();
            this.txtMANSX = new System.Windows.Forms.TextBox();
            this.txtTenNSX = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGHICHU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWebsite = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.pnThongTinNSX = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.đồÁnDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNSX)).BeginInit();
            this.pnNSX.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoNSX)).BeginInit();
            this.pnDgvNSX.SuspendLayout();
            this.pnThongTinNSX.SuspendLayout();
            this.SuspendLayout();
            // 
            // colTenSP
            // 
            this.colTenSP.DataPropertyName = "Ten";
            this.colTenSP.HeaderText = "Tên sản phẩm";
            this.colTenSP.MinimumWidth = 6;
            this.colTenSP.Name = "colTenSP";
            this.colTenSP.Width = 125;
            // 
            // ofdImage
            // 
            this.ofdImage.FileName = "openFileDialog1";
            // 
            // dgvQLNSX
            // 
            this.dgvQLNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQLNSX.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQLNSX.BackgroundColor = System.Drawing.Color.White;
            this.dgvQLNSX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQLNSX.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvQLNSX.Location = new System.Drawing.Point(16, 64);
            this.dgvQLNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvQLNSX.Name = "dgvQLNSX";
            this.dgvQLNSX.RowHeadersWidth = 51;
            this.dgvQLNSX.Size = new System.Drawing.Size(804, 416);
            this.dgvQLNSX.TabIndex = 0;
            this.toolTip2.SetToolTip(this.dgvQLNSX, "DANH SÁCH SẢN PHẨM");
            this.dgvQLNSX.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQLLSP_CellClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MANSX";
            this.Column1.HeaderText = "Mã nhà sản xuất";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TEN";
            this.Column2.HeaderText = "Tên nhà sản xuất";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "WEBSITE";
            this.Column3.HeaderText = "Website";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "EMAIL";
            this.Column4.HeaderText = "Email";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GHICHU";
            this.Column5.HeaderText = "Ghi chú";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // bthThemNSX
            // 
            this.bthThemNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bthThemNSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bthThemNSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.bthThemNSX.Image = global::frmAdmin.Properties.Resources.addition;
            this.bthThemNSX.Location = new System.Drawing.Point(9, 522);
            this.bthThemNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bthThemNSX.Name = "bthThemNSX";
            this.bthThemNSX.Size = new System.Drawing.Size(109, 80);
            this.bthThemNSX.TabIndex = 6;
            this.toolTip2.SetToolTip(this.bthThemNSX, "Thêm");
            this.bthThemNSX.UseVisualStyleBackColor = true;
            this.bthThemNSX.Click += new System.EventHandler(this.bthThemNSX_Click);
            // 
            // btnSuaNSX
            // 
            this.btnSuaNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuaNSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaNSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnSuaNSX.Image = global::frmAdmin.Properties.Resources.edit;
            this.btnSuaNSX.Location = new System.Drawing.Point(148, 522);
            this.btnSuaNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSuaNSX.Name = "btnSuaNSX";
            this.btnSuaNSX.Size = new System.Drawing.Size(109, 80);
            this.btnSuaNSX.TabIndex = 7;
            this.toolTip2.SetToolTip(this.btnSuaNSX, "Sửa");
            this.btnSuaNSX.UseVisualStyleBackColor = true;
            this.btnSuaNSX.Click += new System.EventHandler(this.btnSuaNSX_Click);
            // 
            // btnXoaNSX
            // 
            this.btnXoaNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaNSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaNSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnXoaNSX.Image = global::frmAdmin.Properties.Resources.delete__1_;
            this.btnXoaNSX.Location = new System.Drawing.Point(275, 518);
            this.btnXoaNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoaNSX.Name = "btnXoaNSX";
            this.btnXoaNSX.Size = new System.Drawing.Size(109, 84);
            this.btnXoaNSX.TabIndex = 8;
            this.toolTip2.SetToolTip(this.btnXoaNSX, "Xóa");
            this.btnXoaNSX.UseVisualStyleBackColor = true;
            this.btnXoaNSX.Click += new System.EventHandler(this.btnXoaNSX_Click);
            // 
            // btnLamMoiNSX
            // 
            this.btnLamMoiNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLamMoiNSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoiNSX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnLamMoiNSX.Image = global::frmAdmin.Properties.Resources.refresh__2_;
            this.btnLamMoiNSX.Location = new System.Drawing.Point(409, 519);
            this.btnLamMoiNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLamMoiNSX.Name = "btnLamMoiNSX";
            this.btnLamMoiNSX.Size = new System.Drawing.Size(109, 84);
            this.btnLamMoiNSX.TabIndex = 9;
            this.toolTip2.SetToolTip(this.btnLamMoiNSX, "Làm mới");
            this.btnLamMoiNSX.UseVisualStyleBackColor = true;
            this.btnLamMoiNSX.Click += new System.EventHandler(this.btnLamMoiNSX_Click);
            // 
            // pnNSX
            // 
            this.pnNSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnNSX.Controls.Add(this.picLogoNSX);
            this.pnNSX.Controls.Add(this.label6);
            this.pnNSX.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNSX.Location = new System.Drawing.Point(0, 0);
            this.pnNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnNSX.Name = "pnNSX";
            this.pnNSX.Size = new System.Drawing.Size(845, 122);
            this.pnNSX.TabIndex = 14;
            // 
            // picLogoNSX
            // 
            this.picLogoNSX.Image = global::frmAdmin.Properties.Resources.industrial_robot1;
            this.picLogoNSX.Location = new System.Drawing.Point(52, 30);
            this.picLogoNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picLogoNSX.Name = "picLogoNSX";
            this.picLogoNSX.Size = new System.Drawing.Size(79, 62);
            this.picLogoNSX.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoNSX.TabIndex = 1;
            this.picLogoNSX.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(180, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(276, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "NHÀ SẢN XUẤT";
            // 
            // pnDgvNSX
            // 
            this.pnDgvNSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnDgvNSX.Controls.Add(this.btnTimkiemNSX);
            this.pnDgvNSX.Controls.Add(this.dgvQLNSX);
            this.pnDgvNSX.Controls.Add(this.txtTimkiemNSX);
            this.pnDgvNSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDgvNSX.Location = new System.Drawing.Point(0, 122);
            this.pnDgvNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnDgvNSX.Name = "pnDgvNSX";
            this.pnDgvNSX.Size = new System.Drawing.Size(845, 495);
            this.pnDgvNSX.TabIndex = 15;
            // 
            // btnTimkiemNSX
            // 
            this.btnTimkiemNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimkiemNSX.BackColor = System.Drawing.Color.White;
            this.btnTimkiemNSX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTimkiemNSX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimkiemNSX.ForeColor = System.Drawing.Color.White;
            this.btnTimkiemNSX.Image = global::frmAdmin.Properties.Resources.zoom__1_;
            this.btnTimkiemNSX.Location = new System.Drawing.Point(791, 21);
            this.btnTimkiemNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimkiemNSX.Name = "btnTimkiemNSX";
            this.btnTimkiemNSX.Size = new System.Drawing.Size(29, 28);
            this.btnTimkiemNSX.TabIndex = 7;
            this.btnTimkiemNSX.UseVisualStyleBackColor = false;
            this.btnTimkiemNSX.Click += new System.EventHandler(this.btnTimkiemNSX_Click);
            // 
            // txtTimkiemNSX
            // 
            this.txtTimkiemNSX.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimkiemNSX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimkiemNSX.Location = new System.Drawing.Point(524, 21);
            this.txtTimkiemNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTimkiemNSX.Name = "txtTimkiemNSX";
            this.txtTimkiemNSX.Size = new System.Drawing.Size(295, 35);
            this.txtTimkiemNSX.TabIndex = 6;
            // 
            // txtMANSX
            // 
            this.txtMANSX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMANSX.Location = new System.Drawing.Point(255, 30);
            this.txtMANSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMANSX.Name = "txtMANSX";
            this.txtMANSX.ReadOnly = true;
            this.txtMANSX.Size = new System.Drawing.Size(263, 35);
            this.txtMANSX.TabIndex = 1;
            // 
            // txtTenNSX
            // 
            this.txtTenNSX.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNSX.Location = new System.Drawing.Point(255, 95);
            this.txtTenNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNSX.Name = "txtTenNSX";
            this.txtTenNSX.Size = new System.Drawing.Size(263, 35);
            this.txtTenNSX.TabIndex = 2;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Transparent;
            this.label.Location = new System.Drawing.Point(20, 30);
            this.label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(182, 26);
            this.label.TabIndex = 10;
            this.label.Text = "Mã nhà sản xuất";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(20, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Tên nhà sản xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 335);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 26);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ghi chú";
            // 
            // txtGHICHU
            // 
            this.txtGHICHU.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGHICHU.Location = new System.Drawing.Point(169, 335);
            this.txtGHICHU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGHICHU.Multiline = true;
            this.txtGHICHU.Name = "txtGHICHU";
            this.txtGHICHU.Size = new System.Drawing.Size(348, 147);
            this.txtGHICHU.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 26);
            this.label5.TabIndex = 39;
            this.label5.Text = "Website";
            // 
            // txtWebsite
            // 
            this.txtWebsite.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWebsite.Location = new System.Drawing.Point(232, 164);
            this.txtWebsite.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtWebsite.Name = "txtWebsite";
            this.txtWebsite.Size = new System.Drawing.Size(285, 35);
            this.txtWebsite.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(19, 245);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 26);
            this.label8.TabIndex = 41;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(169, 245);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(348, 35);
            this.txtEmail.TabIndex = 4;
            // 
            // pnThongTinNSX
            // 
            this.pnThongTinNSX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnThongTinNSX.Controls.Add(this.txtEmail);
            this.pnThongTinNSX.Controls.Add(this.label8);
            this.pnThongTinNSX.Controls.Add(this.txtWebsite);
            this.pnThongTinNSX.Controls.Add(this.label5);
            this.pnThongTinNSX.Controls.Add(this.txtGHICHU);
            this.pnThongTinNSX.Controls.Add(this.label2);
            this.pnThongTinNSX.Controls.Add(this.btnLamMoiNSX);
            this.pnThongTinNSX.Controls.Add(this.label4);
            this.pnThongTinNSX.Controls.Add(this.label);
            this.pnThongTinNSX.Controls.Add(this.btnXoaNSX);
            this.pnThongTinNSX.Controls.Add(this.btnSuaNSX);
            this.pnThongTinNSX.Controls.Add(this.bthThemNSX);
            this.pnThongTinNSX.Controls.Add(this.txtTenNSX);
            this.pnThongTinNSX.Controls.Add(this.txtMANSX);
            this.pnThongTinNSX.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnThongTinNSX.Location = new System.Drawing.Point(845, 0);
            this.pnThongTinNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnThongTinNSX.Name = "pnThongTinNSX";
            this.pnThongTinNSX.Size = new System.Drawing.Size(535, 617);
            this.pnThongTinNSX.TabIndex = 13;
            // 
            // frmNhaSanXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 617);
            this.Controls.Add(this.pnDgvNSX);
            this.Controls.Add(this.pnNSX);
            this.Controls.Add(this.pnThongTinNSX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmNhaSanXuat";
            this.Text = "frmNhaSanXuat";
            this.Load += new System.EventHandler(this.frmNhaSanXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.đồÁnDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQLNSX)).EndInit();
            this.pnNSX.ResumeLayout(false);
            this.pnNSX.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoNSX)).EndInit();
            this.pnDgvNSX.ResumeLayout(false);
            this.pnDgvNSX.PerformLayout();
            this.pnThongTinNSX.ResumeLayout(false);
            this.pnThongTinNSX.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSP;
        private System.Windows.Forms.BindingSource đồÁnDataSetBindingSource;
        private System.Windows.Forms.OpenFileDialog ofdImage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pnNSX;
        private System.Windows.Forms.PictureBox picLogoNSX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnDgvNSX;
        private System.Windows.Forms.Button btnTimkiemNSX;
        private System.Windows.Forms.DataGridView dgvQLNSX;
        private System.Windows.Forms.TextBox txtTimkiemNSX;
        private System.Windows.Forms.TextBox txtMANSX;
        private System.Windows.Forms.TextBox txtTenNSX;
        private System.Windows.Forms.Button bthThemNSX;
        private System.Windows.Forms.Button btnSuaNSX;
        private System.Windows.Forms.Button btnXoaNSX;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLamMoiNSX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGHICHU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWebsite;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Panel pnThongTinNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}