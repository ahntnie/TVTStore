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
using Microsoft.Reporting.WinForms;

namespace frmAdmin
{
    public partial class frmBaoCao : Form
    {   
        //DOANHTHUBUS _dtBUS=new DOANHTHUBUS();
        QUANLYSANPHAMBUS _qlSPBUS = new QUANLYSANPHAMBUS();
        CTHDBUS _ctHDBUS = new CTHDBUS();
        QUANLYHOADONBUS _qlHDBUS = new QUANLYHOADONBUS();
        public frmBaoCao()
        {
            InitializeComponent();
            radTatCaSanPham.Checked = true;
           
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

            radChon_CheckedChange(sender, e);
        }


        public void SanPhamConLai()
        {
            List<QuanLySanPhamDTO> lstSP = _qlSPBUS.BaoCaoSP();
            this.rpvTatCaSanPham.LocalReport.ReportEmbeddedResource = "frmAdmin.rptTatCaSanPham.rdlc";
            this.rpvTatCaSanPham.LocalReport.DataSources.Add(new ReportDataSource("DSSpham", lstSP));
            this.rpvTatCaSanPham.RefreshReport();

        }

        public void SanPhamBanChay()
        {
            List<CTHoaDonDTO> lstSPBC = _ctHDBUS.LayDSTheoSLBanRa();
            this.rpvTatCaSanPham.LocalReport.ReportEmbeddedResource = "frmAdmin.rptSanPhamBanChay.rdlc";
            this.rpvTatCaSanPham.LocalReport.DataSources.Add(new ReportDataSource("SanPhamBanChay", lstSPBC));
            this.rpvTatCaSanPham.RefreshReport();
        }
        private void rpvTatCaSanPham_Load(object sender, EventArgs e)
        {
            //SanPhamConLai();
        }
        public void DoanhThuTrongNgay()
        {
            List<CTHoaDonDTO> lstDT = _ctHDBUS.LayHDTheoNgay();
            List<CTHoaDonDTO> lstDTtrongngay = _ctHDBUS.LayDSCTHD();
            this.rpvTatCaSanPham.LocalReport.ReportEmbeddedResource = "frmAdmin.rptLayDoanhThuTrongNgay.rdlc";
            this.rpvTatCaSanPham.LocalReport.DataSources.Add(new ReportDataSource("DoanhThuTrongNgay", lstDT));

            this.rpvTatCaSanPham.LocalReport.DataSources.Add(new ReportDataSource("HoaDon", lstDT));
            this.rpvTatCaSanPham.RefreshReport();
        }
        private void radChon_CheckedChange(object sender, EventArgs e)
        {
            if (radTatCaSanPham.Checked)
            {
                SanPhamConLai();
            }
            else if (radSanPhamBanChay.Checked)
            {
                SanPhamBanChay();
            }
            else if (radDoanhThuTrongNgay.Checked)
            {
                DoanhThuTrongNgay();
            }
        }
    }
}
