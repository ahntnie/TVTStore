using BUS;
using DTO;
using Microsoft.Reporting.WinForms;
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
    public partial class frmHoaDonThanhToan : Form
    {
        CTHDBUS _ctBUS = new CTHDBUS();
        QUANLYHOADONBUS _hdBUS = new QUANLYHOADONBUS();
        public frmHoaDonThanhToan()
        {
            InitializeComponent();
        }

        private void frmHoaDonThanhToan_Load(object sender, EventArgs e)
        {
            ThanhToan();
        }
        public void ThanhToan()
        {
            List<CTHoaDonDTO> lstHDTT = _ctBUS.LayDSCTHDVuaThanhToan();
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmAdmin.rptHoaDonThanhToan.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("HoaDonThanhToan", lstHDTT));
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paNguoiLap", "<Tên người lập>"));
            //this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paNgayLap", DateTime.Now.ToString()));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            //List<CTHoaDonDTO> lstHDTT = _ctBUS.LayDSCTHD();
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "frmAdmin.rptHoaDonThanhToan.rdlc";
            //this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("HoaDonThanhToan", lstHDTT));
            ////this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paNguoiLap", "<Tên người lập>"));
            ////this.reportViewer1.LocalReport.SetParameters(new ReportParameter("paNgayLap", DateTime.Now.ToString()));
            //this.reportViewer1.RefreshReport();
        }

        private void frmHoaDonThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            _ctBUS.AnCTHD();
        }
    }
}
