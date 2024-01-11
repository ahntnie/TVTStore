namespace frmAdmin
{
    partial class frmLOGIN
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
            this.btnHienMK = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnAnMK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnCnDangNhap = new System.Windows.Forms.Panel();
            this.picDangnhap = new System.Windows.Forms.PictureBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.pnFormlogin = new System.Windows.Forms.Panel();
            this.pcMK = new System.Windows.Forms.PictureBox();
            this.picTenTK = new System.Windows.Forms.PictureBox();
            this.pnCnDangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangnhap)).BeginInit();
            this.pnFormlogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenTK)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHienMK
            // 
            this.btnHienMK.BackColor = System.Drawing.Color.White;
            this.btnHienMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienMK.ForeColor = System.Drawing.Color.White;
            this.btnHienMK.Image = global::frmAdmin.Properties.Resources.view;
            this.btnHienMK.Location = new System.Drawing.Point(311, 178);
            this.btnHienMK.Name = "btnHienMK";
            this.btnHienMK.Size = new System.Drawing.Size(29, 19);
            this.btnHienMK.TabIndex = 7;
            this.toolTip1.SetToolTip(this.btnHienMK, "Hiện mật khẩu");
            this.btnHienMK.UseVisualStyleBackColor = false;
            this.btnHienMK.Click += new System.EventHandler(this.btnHienMK_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnThoat.Image = global::frmAdmin.Properties.Resources.exit;
            this.btnThoat.Location = new System.Drawing.Point(12, 246);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(112, 79);
            this.btnThoat.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnThoat, "Thoát");
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.btnDangNhap.Image = global::frmAdmin.Properties.Resources.login_;
            this.btnDangNhap.Location = new System.Drawing.Point(229, 246);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(112, 79);
            this.btnDangNhap.TabIndex = 2;
            this.toolTip1.SetToolTip(this.btnDangNhap, "Đăng nhập");
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnAnMK
            // 
            this.btnAnMK.BackColor = System.Drawing.Color.White;
            this.btnAnMK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAnMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnMK.ForeColor = System.Drawing.Color.White;
            this.btnAnMK.Image = global::frmAdmin.Properties.Resources.hide;
            this.btnAnMK.Location = new System.Drawing.Point(311, 178);
            this.btnAnMK.Name = "btnAnMK";
            this.btnAnMK.Size = new System.Drawing.Size(29, 19);
            this.btnAnMK.TabIndex = 8;
            this.toolTip1.SetToolTip(this.btnAnMK, "Ẩn mật khẩu");
            this.btnAnMK.UseVisualStyleBackColor = false;
            this.btnAnMK.Click += new System.EventHandler(this.btnAnMK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đăng Nhập";
            // 
            // pnCnDangNhap
            // 
            this.pnCnDangNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnCnDangNhap.Controls.Add(this.picDangnhap);
            this.pnCnDangNhap.Controls.Add(this.label1);
            this.pnCnDangNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCnDangNhap.Location = new System.Drawing.Point(0, 0);
            this.pnCnDangNhap.Name = "pnCnDangNhap";
            this.pnCnDangNhap.Size = new System.Drawing.Size(396, 96);
            this.pnCnDangNhap.TabIndex = 0;
            // 
            // picDangnhap
            // 
            this.picDangnhap.Image = global::frmAdmin.Properties.Resources.login;
            this.picDangnhap.Location = new System.Drawing.Point(12, 12);
            this.picDangnhap.Name = "picDangnhap";
            this.picDangnhap.Size = new System.Drawing.Size(112, 61);
            this.picDangnhap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDangnhap.TabIndex = 1;
            this.picDangnhap.TabStop = false;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenTK.Location = new System.Drawing.Point(116, 102);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(225, 29);
            this.txtTenTK.TabIndex = 0;
            this.txtTenTK.TextChanged += new System.EventHandler(this.txtTenTK_TextChanged);
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(116, 171);
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(225, 29);
            this.txtMK.TabIndex = 1;
            // 
            // pnFormlogin
            // 
            this.pnFormlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnFormlogin.Controls.Add(this.btnHienMK);
            this.pnFormlogin.Controls.Add(this.txtMK);
            this.pnFormlogin.Controls.Add(this.btnThoat);
            this.pnFormlogin.Controls.Add(this.btnDangNhap);
            this.pnFormlogin.Controls.Add(this.txtTenTK);
            this.pnFormlogin.Controls.Add(this.pcMK);
            this.pnFormlogin.Controls.Add(this.picTenTK);
            this.pnFormlogin.Controls.Add(this.btnAnMK);
            this.pnFormlogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFormlogin.Location = new System.Drawing.Point(0, 96);
            this.pnFormlogin.Name = "pnFormlogin";
            this.pnFormlogin.Size = new System.Drawing.Size(396, 389);
            this.pnFormlogin.TabIndex = 4;
            // 
            // pcMK
            // 
            this.pcMK.Image = global::frmAdmin.Properties.Resources.password;
            this.pcMK.Location = new System.Drawing.Point(35, 164);
            this.pcMK.Name = "pcMK";
            this.pcMK.Size = new System.Drawing.Size(60, 41);
            this.pcMK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMK.TabIndex = 1;
            this.pcMK.TabStop = false;
            // 
            // picTenTK
            // 
            this.picTenTK.Image = global::frmAdmin.Properties.Resources.user;
            this.picTenTK.Location = new System.Drawing.Point(35, 90);
            this.picTenTK.Name = "picTenTK";
            this.picTenTK.Size = new System.Drawing.Size(60, 41);
            this.picTenTK.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTenTK.TabIndex = 0;
            this.picTenTK.TabStop = false;
            // 
            // frmLOGIN
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 485);
            this.Controls.Add(this.pnFormlogin);
            this.Controls.Add(this.pnCnDangNhap);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLOGIN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.pnCnDangNhap.ResumeLayout(false);
            this.pnCnDangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picDangnhap)).EndInit();
            this.pnFormlogin.ResumeLayout(false);
            this.pnFormlogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTenTK)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDangnhap;
        private System.Windows.Forms.Panel pnCnDangNhap;
        private System.Windows.Forms.Button btnAnMK;
        private System.Windows.Forms.PictureBox picTenTK;
        private System.Windows.Forms.PictureBox pcMK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.Button btnHienMK;
        private System.Windows.Forms.Panel pnFormlogin;
    }
}