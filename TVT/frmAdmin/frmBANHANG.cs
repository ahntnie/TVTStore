using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmAdmin
{
    public partial class frmBANHANG : Form
    {
        QUANLYSANPHAMBUS _banHangBUS=new QUANLYSANPHAMBUS();
        //HOADONBUS _hoadonBUS= new HOADONBUS();
        BANHANGBUS _banhangBUS= new BANHANGBUS();
        BANHANGBUS _bhBUS= new BANHANGBUS();
        string tenNhanVien = "";
        public frmBANHANG(string tenNV)
        {
            InitializeComponent();
            tenNhanVien= tenNV;

        }

        private void frmBANHANG_Load(object sender, EventArgs e)
        {
            lstDSSP.Items.Clear();
            List<QuanLySanPhamDTO> sp = _banHangBUS.LayDSSP();
            for (int i = 0; i < sp.Count; i++)
            {
                imgSP.Images.Add(byteArrayToImage(sp[i].ANH));
                ListViewItem item = new ListViewItem(sp[i].TEN);
                item.SubItems.Add(sp[i].DONGIA.ToString());
                item.ImageIndex = i;
                item.SubItems.Add(sp[i].SOLUONG.ToString());
                item.SubItems.Add(sp[i].MOTA.ToString());
                lstDSSP.Items.Add(item);
            }
        }
        private Image byteArrayToImage(byte[] data)
        {
            MemoryStream ms = new MemoryStream(data,0,data.Length);
            ms.Write(data,0,data.Length);
            return Image.FromStream(ms,true);
        }

        private void lstDSSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<QuanLySanPhamDTO> sp = _banHangBUS.LayDSSP();
            if (lstDSSP.SelectedItems.Count > 0)
            {
                for (int i = 0; i < sp.Count; i++)
                {
                    if (sp[i].TEN == lstDSSP.SelectedItems[0].Text)
                    {
                        picAnhSP.Image = byteArrayToImage(sp[i].ANH);
                        break;
                    }
                }
                txtTenSP.Text = lstDSSP.SelectedItems[0].Text;
                txtGia.Text = lstDSSP.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            if (lstDSSP.SelectedItems.Count == 0)
            {
                return;
            }
            CTHoaDonDTO hoaDonDTO = new CTHoaDonDTO()
            {
                SOLUONG = Convert.ToInt32(numupSoluong.Value),
                DONGIA = Convert.ToInt32(txtGia.Text),
                THANHTIEN = Convert.ToInt32(numupSoluong.Value) * Convert.ToInt32(txtGia.Text),
                TRANGTHAI = false,
                TENSP=txtTenSP.Text,
                NGAYBAN=DateTime.Now,
                TENNV=tenNhanVien,
            };
            if (_banhangBUS.themVaoCTHD(hoaDonDTO))
                MessageBox.Show("Thêm thành công");
            else
                MessageBox.Show("Thêm thất bại");
            _bhBUS=new BANHANGBUS();
            LoadDSSP2();

        }
        private void LoadDSSP2()
        {
            lstDSSP.Items.Clear();
            List<QuanLySanPhamDTO> sp = _bhBUS.LayDSSP();
            for (int i = 0; i < sp.Count; i++)
            {
                imgSP.Images.Add(byteArrayToImage(sp[i].ANH));
                ListViewItem item = new ListViewItem(sp[i].TEN);
                item.SubItems.Add(sp[i].DONGIA.ToString());
                item.ImageIndex = i;
                item.SubItems.Add(sp[i].SOLUONG.ToString());
                item.SubItems.Add(sp[i].MOTA.ToString());
                lstDSSP.Items.Add(item);
            }
        }

        private void txtTimkiemSP_TextChanged(object sender, EventArgs e)
        {
            lstDSSP.Items.Clear();
            List<QuanLySanPhamDTO> sp = _bhBUS.timKiem(txtTimkiemSP.Text);
            for (int i = 0; i < sp.Count; i++)
            {
                imgSP.Images.Add(byteArrayToImage(sp[i].ANH));
                ListViewItem item = new ListViewItem(sp[i].TEN);
                item.SubItems.Add(sp[i].DONGIA.ToString());
                item.ImageIndex = i;
                item.SubItems.Add(sp[i].SOLUONG.ToString());
                item.SubItems.Add(sp[i].MOTA.ToString());
                lstDSSP.Items.Add(item);
            }
        }
    }
}
