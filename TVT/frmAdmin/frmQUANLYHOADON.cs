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
    public partial class frmQUANLYHOADON : Form
    {
        QUANLYHOADONBUS _qlHDBUS = new QUANLYHOADONBUS();
        public frmQUANLYHOADON()
        {
            InitializeComponent();
            dgvQLHD.AutoGenerateColumns= false;
        }
        void loadDSHD()
        {
            dgvQLHD.DataSource = _qlHDBUS.LayDSHD();
        }
        private void dgvQLHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i =e.RowIndex;
            if (i == -1)
                return;
            txtMaHD.Text=dgvQLHD.Rows[i].Cells[0].Value.ToString();
            dtpNgayLapHD.Text=dgvQLHD.Rows[i].Cells[1].Value.ToString();
            txtTenNV.Text=dgvQLHD.Rows[i].Cells[2].Value.ToString();
            txtSDTKH.Text=dgvQLHD.Rows[i].Cells[3].Value.ToString();
            txtThanhTienHD.Text=dgvQLHD.Rows[i].Cells[4].Value.ToString();
            txtGhichuHD.Text=dgvQLHD.Rows[i].Cells[5].Value.ToString();

        }

        private void frmQUANLYHOADON_Load(object sender, EventArgs e)
        {
            loadDSHD();
        }
    }
}
