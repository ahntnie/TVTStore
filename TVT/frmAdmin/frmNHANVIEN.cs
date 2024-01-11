using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAdmin
{
    public partial class frmNHANVIEN : Form
    {
        LoginDTO LOGIN = new LoginDTO();
        NHANVIENBUS _nhanvienBUS= new NHANVIENBUS();
        public frmNHANVIEN(LoginDTO login)
        {
            InitializeComponent();
            LOGIN= login;
        }
        public string layTenTK()
        {
            return LOGIN.TENDANGNHAP;
        }

        private void btnDangxuat_Click(object sender, EventArgs e)
        {
            frmLOGIN frmLogin = new frmLOGIN();
            this.Hide();
            frmLogin.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Hàm mở các form con
        private Form frm = null;
        private void openFormChild(Form frmChild)
        {
            if (frm != null)
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

        private void btnBANHANG_Click(object sender, EventArgs e)
        {
            openFormChild(new frmBANHANG(_nhanvienBUS.layTen_Quyen(layTenTK()).HOTEN));
        }

        private void btnHOADON_Click(object sender, EventArgs e)
        {
            openFormChild(new frmHOADON());
        }

        private void frmNHANVIEN_Load(object sender, EventArgs e)
        {
            lbTen.Text = _nhanvienBUS.layTen_Quyen(layTenTK()).HOTEN;
            lbTenDN.Text = layTenTK();
            lbQuyen.Text = _nhanvienBUS.layTen_Quyen(layTenTK()).Quyen == true ? "Admin" : "Nhân viên";
        }
    }
}
