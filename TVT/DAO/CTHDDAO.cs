using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
    public class CTHDDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();

        public List<CTHoaDonDTO> LayDSCTHD()
        {
            var lstCTHD = tvt.CTHDBANHANG.ToList();
            return lstCTHD.Where(v => v.TRANGTHAI == false).Select(u => new CTHoaDonDTO
            {
                TRANGTHAI = u.TRANGTHAI,
                MAHD = u.MAHD,
                TENSP = u.SANPHAM.TEN,
                MASP = u.MASP,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                THANHTIEN = u.THANHTIEN,
            }).ToList();
        }
        public List<CTHoaDonDTO> LayDSTheoSLBanRa()
        {
            var lstCTHD = tvt.CTHDBANHANG.ToList();
            return lstCTHD.Where(v => v.TRANGTHAI == true).Select(u => new CTHoaDonDTO
            {
                TRANGTHAI = u.TRANGTHAI,
                MAHD = u.MAHD,
                TENSP = u.SANPHAM.TEN,
                MASP = u.MASP,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                THANHTIEN = u.THANHTIEN,
            }).ToList();
        }
        public List<CTHoaDonDTO> LayHDTheoNgay()
        {
            var lstCTHD = tvt.CTHDBANHANG.ToList();
            return lstCTHD.Where(v=>v.TRANGTHAI==true && tvt.HDBANHANG.SingleOrDefault(u=>u.MAHD==v.MAHD).NGAYBAN==DateTime.Now).Select(u => new CTHoaDonDTO
            {
                TRANGTHAI = u.TRANGTHAI,
                MAHD = u.MAHD,
                TENSP = u.SANPHAM.TEN,
                MASP = u.MASP,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                THANHTIEN = u.THANHTIEN,
            }).ToList();
        }

        public List<CTHoaDonDTO> LayDSCTHDVuaThanhToan()
        {
            var lstCTHD = tvt.CTHDBANHANG.ToList();
            return lstCTHD.Where(v => v.MAHD==layMaHD()).Select(u => new CTHoaDonDTO
            {
                TRANGTHAI = u.TRANGTHAI,
                MAHD = u.MAHD,
                TENSP = u.SANPHAM.TEN,
                TENNV = tvt.NHANVIEN.SingleOrDefault(v => u.HDBANHANG.MANV == v.MANV).HOTEN,
                NGAYBAN = DateTime.Now,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                THANHTIEN = u.THANHTIEN,
            }).ToList();
        }

        public bool suaCTHD(CTHoaDonDTO hd)
        {
            try
            {
                SANPHAM sp = tvt.SANPHAM.SingleOrDefault(u => u.TEN == hd.TENSP);
                CTHDBANHANG cthd = tvt.CTHDBANHANG.Where(u => u.TRANGTHAI == false).SingleOrDefault(u => u.MASP == sp.MASP);
                if (hd.SOLUONG != 0)
                {
                    if (hd.SOLUONG < cthd.SOLUONG)
                    {
                        sp.SOLUONG = sp.SOLUONG + (cthd.SOLUONG - hd.SOLUONG);
                        cthd.SOLUONG = hd.SOLUONG;
                        cthd.THANHTIEN = hd.SOLUONG * hd.DONGIA;
                        tvt.SaveChanges();
                    }
                    else if (hd.SOLUONG > cthd.SOLUONG)
                    {
                        sp.SOLUONG = sp.SOLUONG - (hd.SOLUONG - cthd.SOLUONG);
                        cthd.SOLUONG = hd.SOLUONG;
                        cthd.THANHTIEN = hd.SOLUONG * hd.DONGIA;
                        tvt.SaveChanges();
                    }
                }
                else
                {
                    sp.SOLUONG = sp.SOLUONG + cthd.SOLUONG;
                    cthd.TRANGTHAI = true;
                    cthd.SOLUONG = 0;
                    cthd.THANHTIEN = 0;
                    tvt.SaveChanges();
                }
                if (sp.SOLUONG == 0)
                    sp.XOA = true;
                else
                    sp.XOA = false;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoaCTHD(CTHoaDonDTO hd)
        {
            try
            {
                SANPHAM sp = tvt.SANPHAM.SingleOrDefault(u => u.TEN == hd.TENSP);
                CTHDBANHANG cthd = tvt.CTHDBANHANG.Where(u => u.TRANGTHAI == false).SingleOrDefault(u => u.MASP == sp.MASP);
                sp.SOLUONG = cthd.SOLUONG + sp.SOLUONG;
                cthd.TRANGTHAI = true;
                cthd.SOLUONG = 0;
                cthd.THANHTIEN = 0;
                if (sp.SOLUONG == 0)
                    sp.XOA = true;
                else
                    sp.XOA = false;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public string layMaHD()
        {
            HDBANHANG hoaDon = tvt.HDBANHANG.SingleOrDefault(u => u.TRANGTHAI == false);
            return hoaDon.MAHD;
        }
        public bool thanhToanHD(QuanLyKhachHangDTO kh, HoaDonDTO hd)
        {
            try
            {
                HDBANHANG hoaDon = tvt.HDBANHANG.SingleOrDefault(u => u.TRANGTHAI == false);
                hoaDon.TONGTIEN = hd.TONGTIEN;
                hoaDon.GHICHU = hd.GHICHU;
                KHACHHANG khachHang = tvt.KHACHHANG.SingleOrDefault(u => u.DIENTHOAI == kh.DIENTHOAI);
                if (khachHang == null)
                {
                    KHACHHANG khEF = new KHACHHANG
                    {
                        MAKH = "KH" + (tvt.KHACHHANG.Count() + 1),
                        HOTEN = kh.HOTEN,
                        DIACHI = kh.DIACHI,
                        DIENTHOAI = kh.DIENTHOAI,
                        GIOITINH = kh.GIOITINH,
                        GHICHU = kh.GHICHU,
                        XOA = false,
                    };
                    hoaDon.MAKH = khEF.MAKH;
                    tvt.KHACHHANG.Add(khEF);
                }
                else
                {
                    hoaDon.MAKH = khachHang.MAKH;
                }
                var lstCTHD = tvt.CTHDBANHANG.ToList();
                lstCTHD.Where(v => v.MAHD == hoaDon.MAHD).Select(u => new CTHoaDonDTO
                {
                    TRANGTHAI = true,
                    MAHD = u.MAHD,
                    TENSP = u.SANPHAM.TEN,
                    DONGIA = u.DONGIA,
                    SOLUONG = u.SOLUONG,
                    THANHTIEN = u.THANHTIEN,
                }).ToList();
                for (int i = 0; i < lstCTHD.Count; i++)
                {
                    if (lstCTHD[i].TRANGTHAI == false)
                        lstCTHD[i].TRANGTHAI = true;
                }
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool AnCTHD()
        {
            try
            {
                HDBANHANG hoaDon = tvt.HDBANHANG.SingleOrDefault(u => u.TRANGTHAI == false);
                var lstCTHD = tvt.CTHDBANHANG.ToList();
                lstCTHD.Where(v => v.MAHD == hoaDon.MAHD).Select(u => new CTHoaDonDTO
                {
                    TRANGTHAI = true,
                    MAHD = u.MAHD,
                    TENSP = u.SANPHAM.TEN,
                    DONGIA = u.DONGIA,
                    SOLUONG = u.SOLUONG,
                    THANHTIEN = u.THANHTIEN,
                }).ToList();
                for (int i = 0; i < lstCTHD.Count; i++)
                {
                    if (lstCTHD[i].TRANGTHAI == false)
                        lstCTHD[i].TRANGTHAI = true;
                }
                hoaDon.TRANGTHAI = true;
                tvt.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<CTHoaDonDTO> inHOADON()
        {
            var lstCTHD = tvt.CTHDBANHANG.ToList();
            return lstCTHD.Where(v => v.TRANGTHAI == true).Select(u => new CTHoaDonDTO
            {
                TRANGTHAI = u.TRANGTHAI,
                MAHD = u.MAHD,
                TENSP = u.SANPHAM.TEN,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                THANHTIEN = u.THANHTIEN,
            }).ToList();
        }
    }
}
