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
    public partial class frmNhaSanXuat : Form
    {
        NHASANXUATBUS _nhaSXBUS = new NHASANXUATBUS();
        public frmNhaSanXuat()
        {
            InitializeComponent();
            dgvQLNSX.AutoGenerateColumns = false;
        }
        public void loadDSNSX()
        {
            dgvQLNSX.DataSource = _nhaSXBUS.LayDSNSX();
        }
        private void dgvQLLSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if (i == -1)
                return;
            txtMANSX.Text = dgvQLNSX.Rows[i].Cells[0].Value.ToString();
            txtTenNSX.Text = dgvQLNSX.Rows[i].Cells[1].Value.ToString();
            txtWebsite.Text = dgvQLNSX.Rows[i].Cells[2].Value.ToString();
            txtEmail.Text = dgvQLNSX.Rows[i].Cells[3].Value.ToString();
            txtGHICHU.Text = dgvQLNSX.Rows[i].Cells[4].Value.ToString();
        }
        public void reset_test()
        {
            txtMANSX.ResetText();
            txtTenNSX.ResetText();
            txtWebsite.ResetText();
            txtEmail.ResetText();
            txtGHICHU.ResetText();
        }
        private void frmNhaSanXuat_Load(object sender, EventArgs e)
        {
            loadDSNSX();
        }
        bool KT_Nhap()
        {
            if (string.IsNullOrEmpty(txtTenNSX.Text) ||  string.IsNullOrEmpty(txtWebsite.Text)
                || string.IsNullOrEmpty(txtEmail.Text))
                return false;
            return true;
        }
        private void btnTimkiemNSX_Click(object sender, EventArgs e)
        {
            dgvQLNSX.DataSource = _nhaSXBUS.timNSX(txtTimkiemNSX.Text);
        }

        private void bthThemNSX_Click(object sender, EventArgs e)
        {
            if (KT_Nhap() == false) return;
            bool flag = true;
            List<NhaSanXuatDTO> lstNSX = _nhaSXBUS.LayDSNSX();
            for (int i = 0; i < lstNSX.Count; i++)
            {
                if (lstNSX[i].TEN.ToLower().Equals(txtTenNSX.Text.ToLower()))
                {
                    flag = false;
                    break;
                }
            }
            if (flag == true)
            {
                NhaSanXuatDTO newNSX = new NhaSanXuatDTO()
                {
                    TEN = txtTenNSX.Text,
                    GHICHU = txtGHICHU.Text,
                    WEBSITE = txtWebsite.Text,
                    EMAIL = txtEmail.Text,
                    XOA = false
                };
                if (_nhaSXBUS.themNSX(newNSX))

                    MessageBox.Show("Thêm thành công");
                else
                    MessageBox.Show("Thêm thất bại");
                loadDSNSX();
                reset_test();
            }
            else
            {
                MessageBox.Show("Đã có nhà sản xuất hiện tại", "Thông báo");
            }

        }

        private void btnSuaNSX_Click(object sender, EventArgs e)
        {
            if(dgvQLNSX.Rows.Count == 0) return;
            NhaSanXuatDTO editNSX = new NhaSanXuatDTO()
            {
                TEN = txtTenNSX.Text,
                GHICHU = txtGHICHU.Text,
                WEBSITE = txtWebsite.Text,
                EMAIL = txtEmail.Text,
            };
            if (_nhaSXBUS.suaNSX(editNSX))

                MessageBox.Show("Sửa thành công");
            else
                MessageBox.Show("Sửa thất bại");
            loadDSNSX();
            reset_test();
        }

        private void btnXoaNSX_Click(object sender, EventArgs e)
        {
            if (dgvQLNSX.Rows.Count == 0) return;
            NhaSanXuatDTO delNSX = new NhaSanXuatDTO()
            {
                TEN = txtTenNSX.Text,
                MANSX = txtMANSX.Text,
                GHICHU = txtGHICHU.Text,
                WEBSITE = txtWebsite.Text,
                EMAIL = txtEmail.Text,
                XOA = false
            };
            if (_nhaSXBUS.xoaNSX(delNSX))

                MessageBox.Show("Xóa thành công");
            else
                MessageBox.Show("Xóa thất bại");
            loadDSNSX();
            reset_test();
        }

        private void btnLamMoiNSX_Click(object sender, EventArgs e)
        {
            reset_test();
        }
    }
}
