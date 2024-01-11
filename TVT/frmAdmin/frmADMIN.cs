using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace frmAdmin
{
    public partial class frmADMIN : Form
    {
        
        LoginDTO LOGIN = new LoginDTO();
        AdminBUS _adminBUS= new AdminBUS();
        public frmADMIN(LoginDTO loginDTO)
        {
            
            InitializeComponent();
            LOGIN = loginDTO;
                
        }
     
        private void btnQLSP_Click(object sender, EventArgs e)
        {
            openFormChild(new frmQUANLYSANPHAM());
        }


        private void btnTatcaSP_Click_1(object sender, EventArgs e)
        {
            openFormChild(new frmQUANLYSANPHAM());
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            openFormChild(new frmQUANLYNHANVIEN());
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            openFormChild(new frmQUANLYKHACHHANG());
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            openFormChild(new frmQUANLYHOADON());
        }

        private void btnDoanhthu_Click_1(object sender, EventArgs e)
        {
            openFormChild(new frmBaoCao());
        }
        //Nút đăng xuất
        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmLOGIN frmLogin = new frmLOGIN();
                this.Hide();
                frmLogin.ShowDialog();
            }
        }
        //Nút thoát
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
            
        }

        private void frmADMIN_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Close();
        }
        public string layTenTK()
        {
            return LOGIN.TENDANGNHAP;
        }

        //Hàm mở các form con
        private Form frm = null;
        private void openFormChild(Form frmChild)
        {
            if(frm != null)
                frm.Close();
            frm = frmChild;
            frmChild.TopLevel = false;
            frmChild.FormBorderStyle = FormBorderStyle.None;
            //Đổ đầy giao diện
            frmChild.Dock=DockStyle.Fill;
            pnHienfrm.Controls.Add(frmChild);
            pnHienfrm.Tag=frmChild;
            frmChild.BringToFront();
            frmChild.Show();    
        }

        private void picLogo1_Click(object sender, EventArgs e)
        {

        }

        private void lbTen_Click(object sender, EventArgs e)
        {
            
        }

        private void frmADMIN_Load(object sender, EventArgs e)
        {
            lbTenDN.Text = layTenTK();
            lbTen.Text=_adminBUS.layTen_Quyen(layTenTK()).HOTEN;
            lbQuyen.Text = _adminBUS.layTen_Quyen(layTenTK()).Quyen == true ? "Admin" : "Nhân viên";
        }

        private void btnLoaiSP_Click(object sender, EventArgs e)
        {
            openFormChild(new frmLoaiSanPham());
        }

        private void btnNSX_Click(object sender, EventArgs e)
        {
            openFormChild(new frmNhaSanXuat());
        }

    }
}
