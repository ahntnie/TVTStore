using BUS;
using DTO;
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
namespace frmAdmin
{
    public partial class frmQUANLYNHANVIEN : Form
    {

        QUANLYNHANVIENBUS _quanlyNhanVienBus = new QUANLYNHANVIENBUS();
        LOGINBUS _LOGINBUS = new LOGINBUS();
        public frmQUANLYNHANVIEN()
        {
            InitializeComponent();
            dgvQLNV.AutoGenerateColumns = false;

        }
        void loadQLNV()
        {
            //dgvQLNV.DataSource = _quanlyNhanVienBus.LayDSNV();
            dgvQLNV.DataSource = _quanlyNhanVienBus.LayDSNV();

        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            frmDangKy frmDangKy = new frmDangKy();
            frmDangKy.ShowDialog();
        }
        private void frmQUANLYNHANVIEN_Load(object sender, EventArgs e)
        {
            loadQLNV();
        }
        private void dgvQLNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            //.Text = dgvQLSP.Rows[i].Cells[1].Value.ToString();
            txtMaNV.Text = dgvQLNV.Rows[i].Cells[0].Value.ToString();
            txtTenNV.Text = dgvQLNV.Rows[i].Cells[2].Value.ToString();
            dtpNgaySinhNV.Text = dgvQLNV.Rows[i].Cells[4].Value.ToString();
            txtSDTNV.Text = dgvQLNV.Rows[i].Cells[3].Value.ToString();
            txtDiachiNV.Text = dgvQLNV.Rows[i].Cells[6].Value.ToString();
            if (dgvQLNV.Rows[i].Cells[5].Value.ToString().Equals("Nam"))
                radNam.Checked = true;
            else
                radNu.Checked = true;
            txtGhiChu.Text = dgvQLNV.Rows[i].Cells[7].Value.ToString();
            if ((byte[])dgvQLNV.Rows[i].Cells[8].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])dgvQLNV.Rows[i].Cells[8].Value);
                picAnhNV.Image = Image.FromStream(ms);
            }
        }
        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picAnhNV.Image.Save(ms, picAnhNV.Image.RawFormat);
            byte[] byteAnh = ms.GetBuffer();
            ms.Close();
            QuanLyNhanVienDTO upNV = new QuanLyNhanVienDTO()
            {
                MANV = txtMaNV.Text,
                HOTEN = txtTenNV.Text,
                NGAYSINH = dtpNgaySinhNV.Value,
                DIACHI = txtDiachiNV.Text,
                DIENTHOAI = txtSDTNV.Text,
                XOA = false,
                GIOITINH = radNam.Checked == true ? true : false,
                GHICHU = txtGhiChu.Text,
                ANH = byteAnh
            };
            if (_quanlyNhanVienBus.suaNV(upNV))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            loadQLNV();
            ResetText();

        }

        private void frmQUANLYNHANVIEN_Load_1(object sender, EventArgs e)
        {
            loadQLNV();
        }

        private void frmQUANLYNHANVIEN_Load_2(object sender, EventArgs e)
        {
            loadQLNV();

        }

        private void btnTimkiemNV_Click(object sender, EventArgs e)
        {
            dgvQLNV.DataSource = _quanlyNhanVienBus.timKiemNV(txtTimkiemNV.Text);
        }
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
                return;
            QuanLyNhanVienDTO delNV = new QuanLyNhanVienDTO
            {
                MANV = txtMaNV.Text,
                XOA = false

            };
            if (_quanlyNhanVienBus.xoaNV(delNV))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            loadQLNV();
            ResetText();
        }

        private void picAnhNV_Click(object sender, EventArgs e)
        {
            {
                if (ofdImage.ShowDialog() == DialogResult.OK)
                {
                    picAnhNV.Image = new Bitmap(ofdImage.FileName);
                }
            }
        }

        private void txtTimkiemNV_TextChanged(object sender, EventArgs e)
        {
            dgvQLNV.DataSource = _quanlyNhanVienBus.timKiemNV(txtTimkiemNV.Text);
        }
    }
}