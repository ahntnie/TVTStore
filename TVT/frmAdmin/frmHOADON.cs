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
    public partial class frmHOADON : Form
    {
        CTHDBUS _cthdBUS = new CTHDBUS();
        BANHANGBUS _banhangBUS = new BANHANGBUS();
        CTHDBUS _ctBUS = new CTHDBUS();
        static int tienNhan = 0;
        static int tienThoi = 0;
        static int tongTien = 0;
        static int index = 0;
        public frmHOADON()
        {
            InitializeComponent();
            dgvHDBanHang.AutoGenerateColumns = false;
            if (tienNhan != 0)
            {
                lbTienThoi.Text = (tienNhan - tongTien).ToString();
                txtTienNhan.Text = tienNhan.ToString();
            }
        }
        private void frmHOADON_Load(object sender, EventArgs e)
        {
            dgvHDBanHang.DataSource = _cthdBUS.LayDSCTHD();
            int tong = 0;
            List<CTHoaDonDTO> cthd = _cthdBUS.LayDSCTHD();
            for (int i = 0; i < cthd.Count; i++)
            {
                tong = tong + cthd[i].THANHTIEN;
            }
            lbTongTien.Text = tong.ToString("c");
            tongTien = Convert.ToInt32(tong.ToString());
            if (tienNhan != 0)
                tienThoi = tienNhan - tongTien;
            lbTienThoi.Text = tienThoi.ToString("c");
        }
        private void loadDSCTHD()
        {
            dgvHDBanHang.DataSource = _ctBUS.LayDSCTHD();
            int tong = 0;
            List<CTHoaDonDTO> cthd = _ctBUS.LayDSCTHD();
            for (int i = 0; i < cthd.Count; i++)
            {
                tong = tong + cthd[i].THANHTIEN;
            }
            lbTongTien.Text = tong.ToString("c");
            tongTien = Convert.ToInt32(tong.ToString());
            if (tienNhan != 0)
            {
                tienThoi = tienNhan - tongTien;
                if (tienThoi < 0)
                {
                    lbTienThoi.ResetText();
                }
                lbTienThoi.Text = tienThoi.ToString("c");
            }
        }
        private bool KT_TienSua()
        {
            int tong = 0;
            List<CTHoaDonDTO> cthd = _ctBUS.LayDSCTHD();
            for (int i = 0; i < cthd.Count; i++)
            {
                if (cthd[i].TENSP == dgvHDBanHang.SelectedRows[0].Cells[1].Value.ToString())
                    tong = tong + (cthd[i].DONGIA * Convert.ToInt32(numupSoluong.Value.ToString()));
                else
                    tong = tong + cthd[i].THANHTIEN;
            }
            if (tong < tienNhan)
                return true;
            return false;
        }
        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTienNhan.Text) && dgvHDBanHang.SelectedRows.Count > 0)
            {
                CTHoaDonDTO hd = new CTHoaDonDTO
                {
                    TENSP = dgvHDBanHang.SelectedRows[0].Cells[1].Value.ToString(),
                    SOLUONG = Convert.ToInt32(numupSoluong.Value.ToString()),
                    DONGIA = Convert.ToInt32(dgvHDBanHang.SelectedRows[0].Cells[3].Value.ToString()),
                };
                if (_cthdBUS.SuaCTHD(hd))
                    MessageBox.Show("Sửa thành công");
                else
                    MessageBox.Show("Sửa thất bại");
                _ctBUS = new CTHDBUS();
                tienNhan = 0;
                loadDSCTHD();
            }
            else if (dgvHDBanHang.SelectedRows.Count > 0)
            {
                if (KT_TienSua() == true)
                {
                    CTHoaDonDTO hd = new CTHoaDonDTO
                    {
                        TENSP = dgvHDBanHang.SelectedRows[0].Cells[1].Value.ToString(),
                        SOLUONG = Convert.ToInt32(numupSoluong.Value.ToString()),
                        DONGIA = Convert.ToInt32(dgvHDBanHang.SelectedRows[0].Cells[3].Value.ToString()),
                    };
                    if (_cthdBUS.SuaCTHD(hd))
                        MessageBox.Show("Sửa thành công");
                    else
                        MessageBox.Show("Sửa thất bại");
                    _ctBUS = new CTHDBUS();
                    loadDSCTHD();
                }
                else
                {
                    MessageBox.Show("Số tiền nhận không đủ!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dòng nào để sửa");
            }
        }
        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                CTHoaDonDTO hd = new CTHoaDonDTO
                {
                    TENSP = dgvHDBanHang.SelectedRows[0].Cells[1].Value.ToString(),
                    SOLUONG = Convert.ToInt32(numupSoluong.Value.ToString()),
                    DONGIA = Convert.ToInt32(dgvHDBanHang.SelectedRows[0].Cells[3].Value.ToString()),
                };
                if (_cthdBUS.xoaCTHD(hd))
                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa thất bại");
                _ctBUS = new CTHDBUS();
                loadDSCTHD();
            }
            else
                return;
        }

        private void dgvHDBanHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            numupSoluong.Value = Convert.ToInt32(dgvHDBanHang.Rows[i].Cells[2].Value.ToString());
        }

        private void txtTienNhan_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTienNhan.Text))
                tienNhan = 0;
            else
            {
                tienNhan = Convert.ToInt32(txtTienNhan.Text);

                if (tienNhan > tongTien)
                {
                    tienThoi = (tienNhan - tongTien);
                    if (tienThoi < 0)
                    {
                        lbTienThoi.ResetText();    
                    }
                    lbTienThoi.Text = tienThoi.ToString("c");
                }
                else
                {
                    lbTienThoi.ResetText();
                }
            }
        }

        private void btnTHANHTOAN_Click(object sender, EventArgs e)
        {
            QuanLyKhachHangDTO kh = new QuanLyKhachHangDTO
            {
                HOTEN = txtTenKH.Text,
                DIACHI = txtDiachiKH.Text,
                GIOITINH = radNam.Checked == true ? true : false,
                DIENTHOAI = txtSDTKH.Text,
                GHICHU = txtGhiChuKH.Text,
            };
            HoaDonDTO hd = new HoaDonDTO
            {
                DIENTHOAI = txtSDTKH.Text,
                TONGTIEN = tongTien,
                GHICHU = txtGhiChuKH.Text
            };
            if (_cthdBUS.thanhToanHD(kh, hd))
            {
                MessageBox.Show("Thanh toán thành công");
                //dgvHDBanHang.DataSource = _ctBUS.inHoaDon();
                frmHoaDonThanhToan frm = new frmHoaDonThanhToan();
                frm.ThanhToan();
                frm.ShowDialog();
            }
            else
                MessageBox.Show("Thanh toán thất bại");
            ResetText();
            _ctBUS = new CTHDBUS();
            loadDSCTHD();

        }
        private void ResetText()
        {
            txtDiachiKH.ResetText();
            lbTongTien.ResetText();
            txtTenKH.ResetText();
            txtSDTKH.ResetText();
            txtTienNhan.ResetText();
            lbTienThoi.ResetText();
            txtGhiChuKH.ResetText();
            numupSoluong.ResetText();
            tienNhan = 0;
            tienThoi = 0;
            tongTien = 0;
        }
    }
}
