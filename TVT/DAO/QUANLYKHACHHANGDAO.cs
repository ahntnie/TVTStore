using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class QUANLYKHACHHANGDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();

        public List<QuanLyKhachHangDTO> LayDSKH()
        {
            var lstKhachHang = tvt.KHACHHANG.ToList();
            return lstKhachHang.Where(v => v.XOA == false).Select(u => new QuanLyKhachHangDTO
            {
                MAKH = u.MAKH,
                HOTEN = u.HOTEN,
                DIACHI = u.DIACHI,
                DIENTHOAI = u.DIENTHOAI,
                _gtKH = u.GIOITINH == true ? "Nam" : "Nữ",
                GHICHU = u.GHICHU,
                XOA = false,
            }).ToList();
        }
        public bool suaKH(QuanLyKhachHangDTO kh)
        {
            try
            {
                KHACHHANG editKH = tvt.KHACHHANG.SingleOrDefault(u => u.MAKH == kh.MAKH);
                if (editKH == null)
                    return false;
                editKH.DIENTHOAI = kh.DIENTHOAI;
                editKH.HOTEN = kh.HOTEN;
                editKH.DIACHI = kh.DIACHI;
                editKH.GIOITINH = kh.GIOITINH;
                editKH.GHICHU = kh.GHICHU;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoaKH(QuanLyKhachHangDTO nv)
        {
            try
            {
                KHACHHANG delKH = tvt.KHACHHANG.SingleOrDefault(u => u.MAKH == nv.MAKH);
                if (delKH == null)
                    return false;
                delKH.XOA = true;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<QuanLyKhachHangDTO> timKiemKH(string nv)
        {
            var KH = tvt.KHACHHANG.ToList();
            return KH.Where(v => v.HOTEN.ToLower().Contains(nv.ToLower())).Select(u => new QuanLyKhachHangDTO
            {
                HOTEN = u.HOTEN,
                DIACHI = u.DIACHI,
                DIENTHOAI = u.DIENTHOAI,
                _gtKH = u.GIOITINH == true ? "Nam" : "Nữ",
                GHICHU = u.GHICHU,
                XOA = false
            }).ToList();
        }
        public bool IsExisted(QuanLyNhanVienDTO newNV)
        {
            var nvEF = tvt.NHANVIEN.SingleOrDefault(u => u.MANV == newNV.MANV);

            return nvEF != null;
        }
    }
}
