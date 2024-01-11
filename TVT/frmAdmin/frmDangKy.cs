using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmAdmin
{
    public partial class frmDangKy : Form
    {
        QUANLYNHANVIENBUS _quanLyNhanVienBUS = new QUANLYNHANVIENBUS();
        DANGKYBUS _dangKyBus = new DANGKYBUS();
        public frmDangKy()
        {
            InitializeComponent();
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            
            this.Hide();
          
        }

        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (KT_Nhap() == false)
                return;
            MemoryStream ms = new MemoryStream();
            picAnhNV.Image.Save(ms, picAnhNV.Image.RawFormat);
            byte[] byteAnh = ms.GetBuffer();
            ms.Close();
            QuanLyNhanVienDTO newNV = new QuanLyNhanVienDTO
            {
                HOTEN = txtHoten.Text,
                DIENTHOAI = txtSDT.Text.Trim(),
                GIOITINH = (radNam.Checked ? true : false),
                MATKHAU = txtMK.Text.Trim(),
                Quyen = (cbbQuyen.SelectedItem.ToString() == "Admin" ? true : false),
                NGAYSINH = dtpNgaySinh.Value,
                DIACHI = txtDiachi.Text,
                GHICHU=txtGhiChu.Text,
                ANH=byteAnh,
                XOA = false
            };
            if (txtMK.Text != txtMK2.Text)
            {
                MessageBox.Show("Nhập sai mật khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (_dangKyBus.themNV(newNV))
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("Thêm thất bại");
            this.Hide();
        }
        public bool KT_Nhap()
        {
            if(string.IsNullOrEmpty(txtHoten.Text)|| string.IsNullOrEmpty(txtDiachi.Text) || string.IsNullOrEmpty(txtMK.Text) || string.IsNullOrEmpty(txtMK2.Text) || string.IsNullOrEmpty(txtSDT.Text))
                return false;
            return true;
        }

        private void btnTaiAnh_Click(object sender, EventArgs e)
        {
            if (ofdImageNV.ShowDialog() == DialogResult.OK)
            {
                picAnhNV.Image = new Bitmap(ofdImageNV.FileName);
            }

        }
    }
}
