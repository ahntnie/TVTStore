namespace frmAdmin
{
    partial class frmADMIN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmADMIN));
            this.pnSide = new System.Windows.Forms.Panel();
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pnNenduoi = new System.Windows.Forms.Panel();
            this.lbQuyen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbTenDN = new System.Windows.Forms.Label();
            this.lbTen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnHienfrm = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.picLogo1 = new System.Windows.Forms.PictureBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDangxuat = new System.Windows.Forms.Button();
            this.btnDoanhthu = new System.Windows.Forms.Button();
            this.btnNSX = new System.Windows.Forms.Button();
            this.btnLoaiSP = new System.Windows.Forms.Button();
            this.btnQLHD = new System.Windows.Forms.Button();
            this.btnQLKH = new System.Windows.Forms.Button();
            this.btnQLNV = new System.Windows.Forms.Button();
            this.btnQLSP = new System.Windows.Forms.Button();
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.pnSide.SuspendLayout();
            this.pnLogo.SuspendLayout();
            this.pnNenduoi.SuspendLayout();
            this.pnHienfrm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // pnSide
            // 
            this.pnSide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(5)))), ((int)(((byte)(13)))));
            this.pnSide.Controls.Add(this.btnThoat);
            this.pnSide.Controls.Add(this.btnDangxuat);
            this.pnSide.Controls.Add(this.btnDoanhthu);
            this.pnSide.Controls.Add(this.btnNSX);
            this.pnSide.Controls.Add(this.btnLoaiSP);
            this.pnSide.Controls.Add(this.btnQLHD);
            this.pnSide.Controls.Add(this.btnQLKH);
            this.pnSide.Controls.Add(this.btnQLNV);
            this.pnSide.Controls.Add(this.btnQLSP);
            this.pnSide.Controls.Add(this.pnLogo);
            resources.ApplyResources(this.pnSide, "pnSide");
            this.pnSide.Name = "pnSide";
            // 
            // pnLogo
            // 
            resources.ApplyResources(this.pnLogo, "pnLogo");
            this.pnLogo.Controls.Add(this.picAnh);
            this.pnLogo.Name = "pnLogo";
            // 
            // pnNenduoi
            // 
            this.pnNenduoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(21)))), ((int)(((byte)(32)))));
            this.pnNenduoi.Controls.Add(this.lbQuyen);
            this.pnNenduoi.Controls.Add(this.label5);
            this.pnNenduoi.Controls.Add(this.lbTenDN);
            this.pnNenduoi.Controls.Add(this.lbTen);
            this.pnNenduoi.Controls.Add(this.label2);
            this.pnNenduoi.Controls.Add(this.label1);
            resources.ApplyResources(this.pnNenduoi, "pnNenduoi");
            this.pnNenduoi.Name = "pnNenduoi";
            // 
            // lbQuyen
            // 
            resources.ApplyResources(this.lbQuyen, "lbQuyen");
            this.lbQuyen.ForeColor = System.Drawing.Color.Transparent;
            this.lbQuyen.Name = "lbQuyen";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Name = "label5";
            // 
            // lbTenDN
            // 
            resources.ApplyResources(this.lbTenDN, "lbTenDN");
            this.lbTenDN.ForeColor = System.Drawing.Color.Transparent;
            this.lbTenDN.Name = "lbTenDN";
            // 
            // lbTen
            // 
            resources.ApplyResources(this.lbTen, "lbTen");
            this.lbTen.ForeColor = System.Drawing.Color.Transparent;
            this.lbTen.Name = "lbTen";
            this.lbTen.Click += new System.EventHandler(this.lbTen_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Name = "label1";
            // 
            // pnHienfrm
            // 
            this.pnHienfrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.pnHienfrm.Controls.Add(this.picLogo1);
            resources.ApplyResources(this.pnHienfrm, "pnHienfrm");
            this.pnHienfrm.Name = "pnHienfrm";
            // 
            // picLogo1
            // 
            resources.ApplyResources(this.picLogo1, "picLogo1");
            this.picLogo1.Image = global::frmAdmin.Properties.Resources.logo1;
            this.picLogo1.Name = "picLogo1";
            this.picLogo1.TabStop = false;
            this.picLogo1.Click += new System.EventHandler(this.picLogo1_Click);
            // 
            // btnThoat
            // 
            resources.ApplyResources(this.btnThoat, "btnThoat");
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnThoat.Image = global::frmAdmin.Properties.Resources.shutdown;
            this.btnThoat.Name = "btnThoat";
            this.toolTip1.SetToolTip(this.btnThoat, resources.GetString("btnThoat.ToolTip"));
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // btnDangxuat
            // 
            resources.ApplyResources(this.btnDangxuat, "btnDangxuat");
            this.btnDangxuat.FlatAppearance.BorderSize = 0;
            this.btnDangxuat.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnDangxuat.Image = global::frmAdmin.Properties.Resources.logout;
            this.btnDangxuat.Name = "btnDangxuat";
            this.toolTip1.SetToolTip(this.btnDangxuat, resources.GetString("btnDangxuat.ToolTip"));
            this.btnDangxuat.UseVisualStyleBackColor = true;
            this.btnDangxuat.Click += new System.EventHandler(this.btnDangxuat_Click);
            // 
            // btnDoanhthu
            // 
            resources.ApplyResources(this.btnDoanhthu, "btnDoanhthu");
            this.btnDoanhthu.FlatAppearance.BorderSize = 0;
            this.btnDoanhthu.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnDoanhthu.Image = global::frmAdmin.Properties.Resources.money;
            this.btnDoanhthu.Name = "btnDoanhthu";
            this.toolTip1.SetToolTip(this.btnDoanhthu, resources.GetString("btnDoanhthu.ToolTip"));
            this.btnDoanhthu.UseVisualStyleBackColor = true;
            this.btnDoanhthu.Click += new System.EventHandler(this.btnDoanhthu_Click_1);
            // 
            // btnNSX
            // 
            resources.ApplyResources(this.btnNSX, "btnNSX");
            this.btnNSX.FlatAppearance.BorderSize = 0;
            this.btnNSX.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnNSX.Image = global::frmAdmin.Properties.Resources.industrial_robot;
            this.btnNSX.Name = "btnNSX";
            this.toolTip1.SetToolTip(this.btnNSX, resources.GetString("btnNSX.ToolTip"));
            this.btnNSX.UseVisualStyleBackColor = true;
            this.btnNSX.Click += new System.EventHandler(this.btnNSX_Click);
            // 
            // btnLoaiSP
            // 
            resources.ApplyResources(this.btnLoaiSP, "btnLoaiSP");
            this.btnLoaiSP.FlatAppearance.BorderSize = 0;
            this.btnLoaiSP.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnLoaiSP.Image = global::frmAdmin.Properties.Resources.box;
            this.btnLoaiSP.Name = "btnLoaiSP";
            this.toolTip1.SetToolTip(this.btnLoaiSP, resources.GetString("btnLoaiSP.ToolTip"));
            this.btnLoaiSP.UseVisualStyleBackColor = true;
            this.btnLoaiSP.Click += new System.EventHandler(this.btnLoaiSP_Click);
            // 
            // btnQLHD
            // 
            resources.ApplyResources(this.btnQLHD, "btnQLHD");
            this.btnQLHD.FlatAppearance.BorderSize = 0;
            this.btnQLHD.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnQLHD.Image = global::frmAdmin.Properties.Resources.invoice;
            this.btnQLHD.Name = "btnQLHD";
            this.toolTip1.SetToolTip(this.btnQLHD, resources.GetString("btnQLHD.ToolTip"));
            this.btnQLHD.UseVisualStyleBackColor = true;
            this.btnQLHD.Click += new System.EventHandler(this.btnQLHD_Click);
            // 
            // btnQLKH
            // 
            resources.ApplyResources(this.btnQLKH, "btnQLKH");
            this.btnQLKH.FlatAppearance.BorderSize = 0;
            this.btnQLKH.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnQLKH.Image = global::frmAdmin.Properties.Resources.customer;
            this.btnQLKH.Name = "btnQLKH";
            this.toolTip1.SetToolTip(this.btnQLKH, resources.GetString("btnQLKH.ToolTip"));
            this.btnQLKH.UseVisualStyleBackColor = true;
            this.btnQLKH.Click += new System.EventHandler(this.btnQLKH_Click);
            // 
            // btnQLNV
            // 
            resources.ApplyResources(this.btnQLNV, "btnQLNV");
            this.btnQLNV.FlatAppearance.BorderSize = 0;
            this.btnQLNV.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnQLNV.Image = global::frmAdmin.Properties.Resources.teamwork;
            this.btnQLNV.Name = "btnQLNV";
            this.toolTip1.SetToolTip(this.btnQLNV, resources.GetString("btnQLNV.ToolTip"));
            this.btnQLNV.UseVisualStyleBackColor = true;
            this.btnQLNV.Click += new System.EventHandler(this.btnQLNV_Click);
            // 
            // btnQLSP
            // 
            resources.ApplyResources(this.btnQLSP, "btnQLSP");
            this.btnQLSP.FlatAppearance.BorderSize = 0;
            this.btnQLSP.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnQLSP.Image = global::frmAdmin.Properties.Resources.inventory_management;
            this.btnQLSP.Name = "btnQLSP";
            this.toolTip1.SetToolTip(this.btnQLSP, resources.GetString("btnQLSP.ToolTip"));
            this.btnQLSP.UseVisualStyleBackColor = true;
            this.btnQLSP.Click += new System.EventHandler(this.btnQLSP_Click);
            // 
            // picAnh
            // 
            this.picAnh.Image = global::frmAdmin.Properties.Resources.logo;
            resources.ApplyResources(this.picAnh, "picAnh");
            this.picAnh.Name = "picAnh";
            this.picAnh.TabStop = false;
            // 
            // frmADMIN
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnHienfrm);
            this.Controls.Add(this.pnNenduoi);
            this.Controls.Add(this.pnSide);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmADMIN";
            this.ShowIcon = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmADMIN_FormClosing);
            this.Load += new System.EventHandler(this.frmADMIN_Load);
            this.pnSide.ResumeLayout(false);
            this.pnLogo.ResumeLayout(false);
            this.pnNenduoi.ResumeLayout(false);
            this.pnNenduoi.PerformLayout();
            this.pnHienfrm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSide;
        private System.Windows.Forms.Button btnQLSP;
        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.Button btnQLNV;
        private System.Windows.Forms.Button btnQLKH;
        private System.Windows.Forms.Button btnQLHD;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.Panel pnNenduoi;
        private System.Windows.Forms.Panel pnHienfrm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTenDN;
        private System.Windows.Forms.Label lbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbQuyen;
        private System.Windows.Forms.PictureBox picLogo1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnDangxuat;
        private System.Windows.Forms.Button btnDoanhthu;
        private System.Windows.Forms.Button btnNSX;
        private System.Windows.Forms.Button btnLoaiSP;
    }
}

