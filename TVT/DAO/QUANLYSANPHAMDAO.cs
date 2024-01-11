using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class QUANLYSANPHAMDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        public List<QuanLySanPhamDTO> LayDSSP()
        {
            var lstSP = tvt.SANPHAM.ToList();
            return lstSP.Where(v => v.XOA == false).Select(u => new QuanLySanPhamDTO
            {
                MASP=u.MASP,
                TEN = u.TEN,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                TENLOAISP = u.LOAISANPHAM.TEN,
                TENNSX= u.NHASANXUAT.TEN,
                MOTA = u.MOTA,   
                MALOAISP= u.MALOAISP,
                MANSX= u.MANSX,
                GHICHU=u.GHICHU,
                ANH = u.ANH,
                XOA=false
            }).ToList();
        }
        public List<QuanLySanPhamDTO> BaoCaoSP()
        {
            var lstSP = tvt.SANPHAM.ToList();
            return lstSP.Where(v => v.XOA == false).Select(u => new QuanLySanPhamDTO
            {
                MASP = u.MASP,
                TEN = u.TEN,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                TENLOAISP = u.LOAISANPHAM.TEN,
                TENNSX = u.NHASANXUAT.TEN,
                MOTA = u.MOTA,
                XOA = false
            }).ToList();
        }
        public bool themSP(QuanLySanPhamDTO sp)
        {
            try
            {
                SANPHAM spEF = new SANPHAM
                {
                    MASP = (sp.MALOAISP + (tvt.SANPHAM.Count() + 1)).ToString(),
                    TEN = sp.TEN,
                    MALOAISP = sp.MALOAISP,
                    MANSX = sp.MANSX,
                    SOLUONG = sp.SOLUONG,
                    DONGIA = sp.DONGIA,
                    MOTA = sp.MOTA,
                    XOA = false,
                    GHICHU = sp.GHICHU,
                    ANH = sp.ANH
                };
                tvt.SANPHAM.Add(spEF);
                tvt.SaveChanges();
                
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool suaSP(QuanLySanPhamDTO sp)
        {
            try
            {
                SANPHAM newsp = tvt.SANPHAM.SingleOrDefault(u => u.MASP == sp.MASP);
                if (newsp == null)
                    return false;
                newsp.TEN= sp.TEN;
                newsp.DONGIA=sp.DONGIA;
                newsp.MANSX= sp.MANSX;
                newsp.MALOAISP= sp.MALOAISP;
                newsp.MOTA= sp.MOTA;
                newsp.GHICHU= sp.GHICHU;
                newsp.SOLUONG= sp.SOLUONG;
                newsp.XOA = sp.XOA;
                newsp.ANH = sp.ANH;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoaSP(QuanLySanPhamDTO sp)
        {
            try
            {
                SANPHAM newsp = tvt.SANPHAM.SingleOrDefault(u => u.MASP == sp.MASP);
                if (newsp == null)
                    return false;
                newsp.XOA = true;
                tvt.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public List<QuanLySanPhamDTO> timKiemSP(string sp)
        {
            var SP = tvt.SANPHAM.ToList();

            return SP.Where(v => v.TEN.ToLower().Contains(sp.ToLower())).Select(u => new QuanLySanPhamDTO
            {
                MASP = u.MASP,
                TEN = u.TEN,
                DONGIA = u.DONGIA,
                SOLUONG = u.SOLUONG,
                TENLOAISP = u.LOAISANPHAM.TEN,
                TENNSX = u.NHASANXUAT.TEN,
                MOTA = u.MOTA,
                MALOAISP = u.MALOAISP,
                MANSX = u.MANSX,
                GHICHU = u.GHICHU,
                ANH = u.ANH
                
            }).ToList();
        }
        public bool IsExisted(QuanLySanPhamDTO newSP)
        {
            var spEF = tvt.SANPHAM.SingleOrDefault(u => u.MASP == newSP.MASP);

            return spEF != null;
        }

    }
}
