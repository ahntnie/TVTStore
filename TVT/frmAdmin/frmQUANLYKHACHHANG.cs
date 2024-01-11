using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace frmAdmin
{
    public partial class frmQUANLYKHACHHANG : Form
    {
        QUANLYKHACHHANGBUS _qlKHBUS = new QUANLYKHACHHANGBUS();
        QUANLYHOADONBUS _qlHDBUS = new QUANLYHOADONBUS();
        public frmQUANLYKHACHHANG()
        {
            InitializeComponent();
            dgvQLKH.AutoGenerateColumns = false;
        }
        void loadDSKH()
        {
            dgvQLKH.DataSource = _qlKHBUS.LayDSKH();
        }

        private void dgvQLKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            {
                txtMaKH.Text = dgvQLKH.Rows[i].Cells[0].Value.ToString();
                txtTenKH.Text = dgvQLKH.Rows[i].Cells[1].Value.ToString();
                txtDiachiKH.Text = dgvQLKH.Rows[i].Cells[2].Value.ToString();
                txtSDTKH.Text = dgvQLKH.Rows[i].Cells[3].Value.ToString();
                if (dgvQLKH.Rows[i].Cells[4].Value.ToString().Equals("Nam"))
                    radNamKH.Checked = true;
                else
                    radNuKH.Checked = true;
                txtGhiChu.Text = dgvQLKH.Rows[i].Cells[5].Value.ToString();
            }
        }

        private void frmQUANLYKHACHHANG_Load(object sender, EventArgs e)
        {
            loadDSKH();
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            QuanLyKhachHangDTO upKH = new QuanLyKhachHangDTO()
            {
                MAKH = txtMaKH.Text,
                HOTEN = txtTenKH.Text,
                DIACHI = txtDiachiKH.Text,
                DIENTHOAI = txtSDTKH.Text,
                XOA = false,
                GIOITINH = radNamKH.Checked == true ? true : false,
                GHICHU = txtGhiChu.Text,
            };
            if (_qlKHBUS.suaKH(upKH))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            loadDSKH();
            ResetText();
        }
        private void btnTimkiemKH_Click_1(object sender, EventArgs e)
        {
            dgvQLKH.DataSource = _qlKHBUS.timKiemKH(txtTimkiemKH.Text);
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            bool flag = true;
            var lstHD = _qlHDBUS.LayDSHD();
            QuanLyKhachHangDTO delKH = new QuanLyKhachHangDTO()
            {
                MAKH = txtMaKH.Text,
                HOTEN = txtTenKH.Text,
                DIACHI = txtDiachiKH.Text,
                DIENTHOAI = txtSDTKH.Text,
                XOA = false,
                GIOITINH = radNamKH.Checked == true ? true : false,
                GHICHU = txtGhiChu.Text,
            };
            for (int i = 0; i < lstHD.Count; i++)
            {
                if (lstHD[i].MAKH == txtMaKH.Text)
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                if (_qlKHBUS.xoaKH(delKH))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa thất bại");
            }
            else
                MessageBox.Show("Có khách hàng tồn tại trong hóa đơn", "Không thể xóa");

        }

    }
}
