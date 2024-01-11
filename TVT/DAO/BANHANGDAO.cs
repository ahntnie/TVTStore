using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{

    public class BANHANGDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();

        public List<QuanLySanPhamDTO> LayDSSP()
        {
            var lstSP = tvt.SANPHAM.ToList();
            return lstSP.Where(v => v.XOA == false).Select(u => new QuanLySanPhamDTO
            {
                ANH = u.ANH,
                TEN = u.TEN,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                MOTA = u.MOTA,
            }).ToList();
        }
        public List<CTHoaDonDTO> LayDSCTHD()
        {
            var lstCTHD = tvt.CTHDBANHANG.ToList();
            return lstCTHD.Where(v => v.TRANGTHAI == false).Select(u => new CTHoaDonDTO
            {
                TRANGTHAI = u.TRANGTHAI,
                MAHD = u.MAHD,
                MASP = u.MASP,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                THANHTIEN = u.THANHTIEN,

            }).ToList();
        }
        public bool themVaoCTHD(CTHoaDonDTO hd)
        {
            try
            {
                SANPHAM sp = tvt.SANPHAM.SingleOrDefault(u => u.TEN == hd.TENSP);
                NHANVIEN nv = tvt.NHANVIEN.SingleOrDefault(v => v.HOTEN == hd.TENNV);
                HDBANHANG hoaDon = tvt.HDBANHANG.SingleOrDefault(v => v.TRANGTHAI == false);
                //SANPHAM sanpham = tvt.SANPHAM.SingleOrDefault(u => u.MASP == sp.MASP);
                List<CTHDBANHANG> hoadonMoi = new List<CTHDBANHANG>();

                if (hoaDon == null)
                {
                    CTHDBANHANG cthd = new CTHDBANHANG
                    {
                        MAHD = "HD" + tvt.HDBANHANG.Count(),
                        MASP = sp.MASP,
                        
                        DONGIA = hd.DONGIA,
                        SOLUONG = hd.SOLUONG,
                        THANHTIEN = hd.THANHTIEN,
                        TRANGTHAI = hd.TRANGTHAI
                    };
                    int ma = tvt.CTHDBANHANG.Count();
                    HDBANHANG hdbh = new HDBANHANG
                    {
                        MAHD = cthd.MAHD,
                        NGAYBAN = hd.NGAYBAN,
                        MANV = nv.MANV,
                        TRANGTHAI = false
                    };
                    sp.SOLUONG = sp.SOLUONG - hd.SOLUONG;
                    cthd.THANHTIEN = cthd.SOLUONG * cthd.DONGIA;
                    if (sp.SOLUONG == 0)
                        sp.XOA = true;
                    tvt.CTHDBANHANG.Add(cthd);
                    tvt.HDBANHANG.Add(hdbh);
                    tvt.SaveChanges();
                    return true;
                }
                else
                {
                    CTHDBANHANG ct = tvt.CTHDBANHANG.Where(v => v.MAHD == hoaDon.MAHD).SingleOrDefault(u => u.MASP == sp.MASP);

                    if (ct != null)
                    {
                        ct.MAHD = hoaDon.MAHD;
                        ct.MASP = sp.MASP;
                        ct.DONGIA = hd.DONGIA;
                        ct.SOLUONG = hd.SOLUONG + ct.SOLUONG;
                        ct.THANHTIEN = ct.SOLUONG * ct.DONGIA;
                        ct.TRANGTHAI = hd.TRANGTHAI;
                        sp.SOLUONG = sp.SOLUONG - hd.SOLUONG;
                        if (sp.SOLUONG == 0)
                            sp.XOA = true;
                        tvt.SaveChanges();
                        return true;
                    }
                    else
                    {
                        CTHDBANHANG cthd = new CTHDBANHANG
                        {
                            MAHD = hoaDon.MAHD,
                            MASP = sp.MASP,
                            DONGIA = hd.DONGIA,
                            SOLUONG = hd.SOLUONG,
                            THANHTIEN = hd.THANHTIEN,
                            TRANGTHAI = hd.TRANGTHAI
                        };
                        sp.SOLUONG = sp.SOLUONG - hd.SOLUONG;
                        cthd.THANHTIEN = cthd.SOLUONG * cthd.DONGIA;
                        tvt.CTHDBANHANG.Add(cthd);
                        if (sp.SOLUONG == 0)
                            sp.XOA = true;
                    }
                    tvt.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<QuanLySanPhamDTO> timKiem(string tenSP)
        {
            var lstSP = tvt.SANPHAM.Where(v=>v.XOA==false).ToList();
            return lstSP.Where(v => v.TEN.ToLower().Contains(tenSP.ToLower())).Select(u => new QuanLySanPhamDTO
            {
                ANH = u.ANH,
                TEN = u.TEN,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                MOTA = u.MOTA,
            }).ToList();
        }

    }
}
