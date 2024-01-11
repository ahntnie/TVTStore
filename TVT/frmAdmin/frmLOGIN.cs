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
    public partial class frmLOGIN : Form
    {
        LOGINBUS _loginBUS = new LOGINBUS();
        public frmLOGIN()
        {
            InitializeComponent();
        }

        private void btnAnMK_Click(object sender, EventArgs e)
        {
            if (txtMK.PasswordChar=='\0')
            {
                btnHienMK.BringToFront();
                txtMK.PasswordChar = '*';
            }
        }

        private void btnHienMK_Click(object sender, EventArgs e)
        {
            if (txtMK.PasswordChar=='*')
            {
                btnAnMK.BringToFront();
                txtMK.PasswordChar = '\0';
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();               
            }
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            LoginDTO loginDTO = new LoginDTO
            { 
                TENDANGNHAP=txtTenTK.Text,
            };

            if (_loginBUS.KT_TK(txtTenTK.Text, txtMK.Text))
            {
                if (_loginBUS.KT_Quyen(txtTenTK.Text))
                {

                    frmADMIN frmADMIN = new frmADMIN(loginDTO);
                    frmADMIN.ShowDialog();
                    this.Close();
                }
                else
                {
                    frmNHANVIEN frmNHANVIEN = new frmNHANVIEN(loginDTO);
                    frmNHANVIEN.ShowDialog();
                    this.Close();
                }
            }
            else 
            {
                DialogResult result = MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void txtTenTK_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            this.Hide();
            frmDangKy.ShowDialog();
        }
    }
}
