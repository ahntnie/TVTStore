using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAdmin
{
    public partial class frmQUANLYSANPHAM : Form
    {
        QUANLYSANPHAMBUS _quanLySPBUS = new QUANLYSANPHAMBUS();
        LOAISANPHAMBUS _loaiSPBUS=new LOAISANPHAMBUS();
        NHASANXUATBUS _nsxBUS= new NHASANXUATBUS();
        public frmQUANLYSANPHAM()
        {
            InitializeComponent();
            dgvQLSP.AutoGenerateColumns= false;
        }
        void loadQLSP()
        {
            dgvQLSP.DataSource = _quanLySPBUS.LayDSSP();        
            cbbLoaiSP.DataSource = _loaiSPBUS.LayDSLoaiSP();
            cbbLoaiSP.DisplayMember = "TEN";
            cbbLoaiSP.ValueMember = "MALOAISP";
            cbbNhaSanXuat.DataSource = _nsxBUS.LayDSNSX();
            cbbNhaSanXuat.DisplayMember = "TEN";
            cbbNhaSanXuat.ValueMember = "MANSX";

        }
        private void frmQUANLYSANPHAM_Load(object sender, EventArgs e)
        {
            loadQLSP();
        }


        private void dgvQLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            txtMaSP.Text = dgvQLSP.Rows[i].Cells[0].Value.ToString();
            txtTenSP.Text = dgvQLSP.Rows[i].Cells[1].Value.ToString();
            txtGia.Text= dgvQLSP.Rows[i].Cells[2].Value.ToString();
            numupSoluong.Value = Convert.ToInt32(dgvQLSP.Rows[i].Cells[3].Value.ToString());
            cbbLoaiSP.SelectedValue = dgvQLSP.Rows[i].Cells[8].Value;
            cbbNhaSanXuat.SelectedValue = dgvQLSP.Rows[i].Cells[9].Value;
            txtMoTaSP.Text = dgvQLSP.Rows[i].Cells[6].Value.ToString();
            txtGhiChu.Text= dgvQLSP.Rows[i].Cells[7].Value.ToString();
            if (dgvQLSP.Rows[i].Cells[10].Value != null)
            {
                MemoryStream ms = new MemoryStream((byte[])dgvQLSP.Rows[i].Cells[10].Value);
                picAnhSP.Image = Image.FromStream(ms);
            }
        }

        private void dgvQLSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        bool KT_Nhap()
        {
            if(string.IsNullOrEmpty(txtGia.Text) || string.IsNullOrEmpty(txtMoTaSP.Text) || numupSoluong.Value==0)
                return false;
            return true;
        }
        void ResetText()
        {
            txtMaSP.ResetText();
            txtGia.ResetText();
            txtMoTaSP.ResetText();
            txtTenSP.ResetText();
            txtGhiChu.ResetText();
            numupSoluong.ResetText();
            picAnhSP.Image.Dispose();
        }
        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if(KT_Nhap() == false) return;
            MemoryStream ms = new MemoryStream();
            picAnhSP.Image.Save(ms, picAnhSP.Image.RawFormat);
            byte[] byteAnh = ms.GetBuffer();
            ms.Close();
            QuanLySanPhamDTO newSP = new QuanLySanPhamDTO
            {
                TEN = txtTenSP.Text,
                MALOAISP = cbbLoaiSP.SelectedValue.ToString(),
                MANSX = cbbNhaSanXuat.SelectedValue.ToString(),
                SOLUONG = Convert.ToInt32(numupSoluong.Value),
                MOTA = txtMoTaSP.Text,
                GHICHU = txtGhiChu.Text,
                DONGIA = Convert.ToInt32(txtGia.Text),
                ANH = byteAnh,
                XOA = false
            };
            if (_quanLySPBUS.themSP(newSP))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            loadQLSP();
            ResetText();
        }

        private void btnSuaSP_Click(object sender, EventArgs e)
        {
            MemoryStream ms = new MemoryStream();
            picAnhSP.Image.Save(ms, picAnhSP.Image.RawFormat);
            byte[] byteAnh = ms.GetBuffer();
            ms.Close();
            QuanLySanPhamDTO SP = new QuanLySanPhamDTO
            {
                MASP = txtMaSP.Text,
                TEN = txtTenSP.Text,
                MALOAISP = cbbLoaiSP.SelectedValue.ToString(),
                MANSX = cbbNhaSanXuat.SelectedValue.ToString(),
                SOLUONG = Convert.ToInt32(numupSoluong.Value),
                MOTA = txtMoTaSP.Text,
                GHICHU = txtGhiChu.Text,
                DONGIA = Convert.ToInt32(txtGia.Text),
                XOA = false,
                ANH = byteAnh
            };
            if (_quanLySPBUS.suaSP(SP))
                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            loadQLSP();
            ResetText();
        }

        private void btnXoaSP_Click(object sender, EventArgs e)
        {
            QuanLySanPhamDTO SP = new QuanLySanPhamDTO
            {
                MASP = txtMaSP.Text,
                TEN = txtTenSP.Text,
                MALOAISP = cbbLoaiSP.SelectedValue.ToString(),
                MANSX = cbbNhaSanXuat.SelectedValue.ToString(),
                SOLUONG = Convert.ToInt32(numupSoluong.Value),
                MOTA = txtMoTaSP.Text,
                GHICHU = txtGhiChu.Text,
                DONGIA = Convert.ToInt32(txtGia.Text),
                XOA = false
               
            };
            if (_quanLySPBUS.xoaSP(SP))
                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            loadQLSP();
            ResetText();
        }

        private void btnTimkiemSP_Click(object sender, EventArgs e)
        {
            dgvQLSP.DataSource=_quanLySPBUS.timKiemSP(txtTimkiemSP.Text);
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            ResetText();
        }

        private void pnDgvTCSP_Paint(object sender, PaintEventArgs e)
        { 

        }

        private void picAnhSP_Click(object sender, EventArgs e)
        {
            if(ofdImage.ShowDialog()== DialogResult.OK)
            {
                picAnhSP.Image = new Bitmap(ofdImage.FileName);
            }
            
        }

        private void txtTimkiemSP_TextChanged(object sender, EventArgs e)
        {
            dgvQLSP.DataSource = _quanLySPBUS.timKiemSP(txtTimkiemSP.Text);
        }
    }
}
