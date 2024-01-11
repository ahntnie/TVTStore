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
    public partial class frmLoaiSanPham : Form
    {
        LOAISANPHAMBUS _loaiSPBUS = new LOAISANPHAMBUS();
        QUANLYSANPHAMBUS _qlspBUS= new QUANLYSANPHAMBUS();
        public frmLoaiSanPham()
        {
            InitializeComponent();
            dgvQLLSP.AutoGenerateColumns=false;
        }

        void loadDSLSP()
        {
            dgvQLLSP.DataSource = _loaiSPBUS.LayDSLoaiSP();
        }
        private void dgvQLLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            txtMaLSP.Text= dgvQLLSP.Rows[i].Cells[0].Value.ToString();
            txtTenLSP.Text= dgvQLLSP.Rows[i].Cells[1].Value.ToString();
            txtGhiChuLSP.Text = dgvQLLSP.Rows[i].Cells[2].Value.ToString();

        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            loadDSLSP();
        }

        public void reset_text()
        {
            txtGhiChuLSP.ResetText();
            txtMaLSP.ResetText();
            txtTenLSP.ResetText();
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            reset_text();
        }
        private static readonly string[] VietnameseSigns = new string[]

{

        "aAeEoOuUiIdDyY",

        "áàạảãâấầậẩẫăắằặẳẵ",

        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

        "éèẹẻẽêếềệểễ",

        "ÉÈẸẺẼÊẾỀỆỂỄ",

        "óòọỏõôốồộổỗơớờợởỡ",

        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

        "úùụủũưứừựửữ",

        "ÚÙỤỦŨƯỨỪỰỬỮ",

        "íìịỉĩ",

        "ÍÌỊỈĨ",

        "đ",

        "Đ",

        "ýỳỵỷỹ",

        "ÝỲỴỶỸ"

};



        public static string BoDauChuoi(string str)

        {
            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi
            for (int i = 1; i < VietnameseSigns.Length; i++)

            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }
        private void btnThemLSP_Click(object sender, EventArgs e)
        {
            if (KT_Nhap() == false) return;
            bool flag = true;
            List<LoaiSanPhamDTO> lstLoaiSP = _loaiSPBUS.LayDSLoaiSP();
            for (int i = 0; i < lstLoaiSP.Count; i++)
            {
                if (lstLoaiSP[i].TEN.ToLower().Equals(txtTenLSP.Text.ToLower()))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                LoaiSanPhamDTO newLSP = new LoaiSanPhamDTO()
                {
                    TEN = txtTenLSP.Text,
                    GHICHU = txtGhiChuLSP.Text
                };
                if (_loaiSPBUS.themLSP(newLSP))

                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
                loadDSLSP();
            }
            else
            {
                MessageBox.Show("Đã có tên sản phẩm hiện tại","Thông báo");
            }
            reset_text();
        }

        private void btnSuaLSP_Click(object sender, EventArgs e)
        {
            if(dgvQLLSP.SelectedRows.Count == 0) return;
            LoaiSanPhamDTO editLSP = new LoaiSanPhamDTO()
            {
                TEN = txtTenLSP.Text,
                GHICHU = txtGhiChuLSP.Text
            };
            if (_loaiSPBUS.suaLSP(editLSP))

                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            loadDSLSP();
            reset_text();
        }

        private void btnXoaLSP_Click(object sender, EventArgs e)
        {
            if (dgvQLLSP.SelectedRows.Count == 0) return;
            var lstSP = _qlspBUS.LayDSSP();
            bool flag = true;
            foreach(var item in lstSP)
            {
                if(item.MALOAISP==txtMaLSP.Text)
                {
                    flag = false;
                    break;
                }   
            }
            if (flag)
            {
                LoaiSanPhamDTO delLSP = new LoaiSanPhamDTO()
                {
                    TEN = txtTenLSP.Text,
                    MALOAISP = txtMaLSP.Text,
                    GHICHU = txtGhiChuLSP.Text,
                    XOA = false
                };
                if (_loaiSPBUS.xoaLSP(delLSP))

                    MessageBox.Show("Xóa thành công");
                else
                    MessageBox.Show("Xóa thất bại");
                loadDSLSP();
                reset_text();
            }
            else
            {
               MessageBox.Show("Không thể xóa do có sản phẩm có MALOAISP tương tự");
            }
        }
        bool KT_Nhap()
        {
            if (string.IsNullOrEmpty(txtTenLSP.Text))              
                return false;
            return true;
        }
        private void txtMaLSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimkiemLSP_Click(object sender, EventArgs e)
        {
            dgvQLLSP.DataSource = _loaiSPBUS.timKiemLSP(txtTimkiemLSP.Text);
        }
    }
}
