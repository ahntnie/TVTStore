namespace frmAdmin
{
    partial class frmDangKy
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
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangKy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCnDangNhap = new System.Windows.Forms.Panel();
            this.picDangky = new System.Windows.Forms.PictureBox();
            this.pnDangKy = new System.Windows.Forms.Panel();
            this.btnTaiAnh = new System.Windows.Forms.Button();
            this.picAnhNV = new System.Windows.Forms.PictureBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.radNu = new System.Windows.Forms.RadioButton();
            this.radNam = new System.Windows.Forms.RadioButton();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMK2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ofdImageNV = new System.Windows.Forms.OpenFileDialog();
            this.pnCnDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangky)).BeginInit();
            this.pnDangKy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnThoat.Image = global::frmAdmin.Properties.Resources.exit__1_;
            this.btnThoat.Location = new System.Drawing.Point(34, 553);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(113, 49);
            this.btnThoat.TabIndex = 13;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát đăng ký");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDangKy
            // 
            this.btnDangKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDangKy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDangKy.Image = global::frmAdmin.Properties.Resources.add_friend;
            this.btnDangKy.Location = new System.Drawing.Point(290, 545);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(82, 65);
            this.btnDangKy.TabIndex = 12;
            this.toolTip1.SetToolTip(this.btnDangKy, "Đăng ký");
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(163, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Ký";
            // 
            // pnCnDangNhap
            // 
            this.pnCnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnCnDangNhap.Controls.Add(this.picDangky);
            this.pnCnDangNhap.Controls.Add(this.label1);
            this.pnCnDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCnDangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnCnDangNhap.Name = "pnCnDangNhap";
            this.pnCnDangNhap.Size = new System.Drawing.Size(442, 96);
            this.pnCnDangNhap.TabIndex = 5;
            // 
            // picDangky
            // 
            this.picDangky.Image = global::frmAdmin.Properties.Resources.add_friend;
            this.picDangky.Location = new System.Drawing.Point(12, 12);
            this.picDangky.Name = "picDangky";
            this.picDangky.Size = new System.Drawing.Size(112, 67);
            this.picDangky.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDangky.TabIndex = 1;
            this.picDangky.TabStop = false;
            // 
            // pnDangKy
            // 
            this.pnDangKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnDangKy.Controls.Add(this.btnTaiAnh);
            this.pnDangKy.Controls.Add(this.picAnhNV);
            this.pnDangKy.Controls.Add(this.txtGhiChu);
            this.pnDangKy.Controls.Add(this.label7);
            this.pnDangKy.Controls.Add(this.radNu);
            this.pnDangKy.Controls.Add(this.radNam);
            this.pnDangKy.Controls.Add(this.cbbQuyen);
            this.pnDangKy.Controls.Add(this.label10);
            this.pnDangKy.Controls.Add(this.btnDangKy);
            this.pnDangKy.Controls.Add(this.btnThoat);
            this.pnDangKy.Controls.Add(this.label9);
            this.pnDangKy.Controls.Add(this.txtMK2);
            this.pnDangKy.Controls.Add(this.label8);
            this.pnDangKy.Controls.Add(this.txtMK);
            this.pnDangKy.Controls.Add(this.label6);
            this.pnDangKy.Controls.Add(this.txtDiachi);
            this.pnDangKy.Controls.Add(this.label5);
            this.pnDangKy.Controls.Add(this.label4);
            this.pnDangKy.Controls.Add(this.txtSDT);
            this.pnDangKy.Controls.Add(this.label3);
            this.pnDangKy.Controls.Add(this.dtpNgaySinh);
            this.pnDangKy.Controls.Add(this.txtHoten);
            this.pnDangKy.Controls.Add(this.label2);
            this.pnDangKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnDangKy.Location = new System.Drawing.Point(0, 96);
            this.pnDangKy.Name = "pnDangKy";
            this.pnDangKy.Size = new System.Drawing.Size(442, 621);
            this.pnDangKy.TabIndex = 6;
            // 
            // btnTaiAnh
            // 
            this.btnTaiAnh.Location = new System.Drawing.Point(196, 98);
            this.btnTaiAnh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTaiAnh.Name = "btnTaiAnh";
            this.btnTaiAnh.Size = new System.Drawing.Size(56, 19);
            this.btnTaiAnh.TabIndex = 11;
            this.btnTaiAnh.Text = "Tải ảnh";
            this.btnTaiAnh.UseVisualStyleBackColor = true;
            this.btnTaiAnh.Click += new System.EventHandler(this.btnTaiAnh_Click);
            // 
            // picAnhNV
            // 
            this.picAnhNV.Location = new System.Drawing.Point(168, 2);
            this.picAnhNV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picAnhNV.Name = "picAnhNV";
            this.picAnhNV.Size = new System.Drawing.Size(110, 82);
            this.picAnhNV.TabIndex = 52;
            this.picAnhNV.TabStop = false;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGhiChu.Location = new System.Drawing.Point(175, 393);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(237, 36);
            this.txtGhiChu.TabIndex = 8;
            this.toolTip1.SetToolTip(this.txtGhiChu, "MÔ TẢ VỀ BẢN THÂN");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 393);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 22);
            this.label7.TabIndex = 50;
            this.label7.Text = "Ghi chú";
            // 
            // radNu
            // 
            this.radNu.AutoSize = true;
            this.radNu.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radNu.Location = new System.Drawing.Point(334, 233);
            this.radNu.Name = "radNu";
            this.radNu.Size = new System.Drawing.Size(53, 26);
            this.radNu.TabIndex = 4;
            this.radNu.TabStop = true;
            this.radNu.Text = "Nữ";
            this.radNu.UseVisualStyleBackColor = true;
            // 
            // radNam
            // 
            this.radNam.AutoSize = true;
            this.radNam.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radNam.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.radNam.Location = new System.Drawing.Point(214, 233);
            this.radNam.Name = "radNam";
            this.radNam.Size = new System.Drawing.Size(67, 26);
            this.radNam.TabIndex = 3;
            this.radNam.TabStop = true;
            this.radNam.Text = "Nam";
            this.radNam.UseVisualStyleBackColor = true;
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Items.AddRange(new object[] {
            "Admin",
            "Nhân viên"});
            this.cbbQuyen.Location = new System.Drawing.Point(280, 264);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(132, 30);
            this.cbbQuyen.TabIndex = 5;
            this.toolTip1.SetToolTip(this.cbbQuyen, "QUYỀN");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 22);
            this.label10.TabIndex = 46;
            this.label10.Text = "Quyền";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(31, 507);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(161, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Nhập lại mật khẩu";
            // 
            // txtMK2
            // 
            this.txtMK2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK2.Location = new System.Drawing.Point(207, 504);
            this.txtMK2.Name = "txtMK2";
            this.txtMK2.Size = new System.Drawing.Size(205, 29);
            this.txtMK2.TabIndex = 10;
            this.toolTip1.SetToolTip(this.txtMK2, "NHẬP CHÍNH XÁC MẬT KHẨU");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 448);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Mật khẩu";
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(207, 448);
            this.txtMK.Name = "txtMK";
            this.txtMK.Size = new System.Drawing.Size(205, 29);
            this.txtMK.TabIndex = 9;
            this.toolTip1.SetToolTip(this.txtMK, "NHẬP MẬT KHẨU");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 22);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ngày sinh";
            // 
            // txtDiachi
            // 
            this.txtDiachi.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiachi.Location = new System.Drawing.Point(175, 345);
            this.txtDiachi.Multiline = true;
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(237, 36);
            this.txtDiachi.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txtDiachi, "NHẬP ĐỊA CHỈ");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(31, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(32, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Giới tính";
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(214, 189);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(199, 29);
            this.txtSDT.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtSDT, "NHẬP SỐ ĐIỆN THOẠI");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(32, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Số điện thoại";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(213, 306);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(199, 29);
            this.dtpNgaySinh.TabIndex = 6;
            this.toolTip1.SetToolTip(this.dtpNgaySinh, "NHẬP NGÀY SINH");
            // 
            // txtHoten
            // 
            this.txtHoten.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHoten.Location = new System.Drawing.Point(188, 140);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(226, 29);
            this.txtHoten.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtHoten, "NHẬP HỌ TÊN");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // ofdImageNV
            // 
            this.ofdImageNV.FileName = "ofdImageNV";
            // 
            // frmDangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 717);
            this.Controls.Add(this.pnDangKy);
            this.Controls.Add(this.pnCnDangNhap);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDangKy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDangKy";
            this.pnCnDangNhap.ResumeLayout(false);
            this.pnCnDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangky)).EndInit();
            this.pnDangKy.ResumeLayout(false);
            this.pnDangKy.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAnhNV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox picDangky;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnCnDangNhap;
        private System.Windows.Forms.Panel pnDangKy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMK2;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RadioButton radNu;
        private System.Windows.Forms.RadioButton radNam;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnTaiAnh;
        private System.Windows.Forms.PictureBox picAnhNV;
        private System.Windows.Forms.OpenFileDialog ofdImageNV;
    }
}