using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class QUANLYNHANVIENDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
 
        public List<QuanLyNhanVienDTO>LayDSNV() 
        {
            var lstNhanVien = tvt.NHANVIEN.ToList();
            return lstNhanVien.Where(v => v.XOA == false).Select(u => new QuanLyNhanVienDTO
            {
                MANV = u.MANV,
                MATKHAU = u.MATKHAU,
                HOTEN = u.HOTEN,
                DIACHI = u.DIACHI,
                DIENTHOAI = u.DIENTHOAI,
                NGAYSINH = u.NGAYSINH,
                gt = u.GIOITINH == true ? "Nam" : "Nữ",
                GHICHU = u.GHICHU,
                XOA = false,
                ANH=u.ANH,
            }).ToList();        
        }

        public bool suaNV(QuanLyNhanVienDTO nv)
        {
            try
            {
                NHANVIEN updateNV = tvt.NHANVIEN.SingleOrDefault(u => u.MANV == nv.MANV);
                if (updateNV == null)
                    return false;
                updateNV.HOTEN=nv.HOTEN;
                updateNV.DIACHI= nv.DIACHI;
                updateNV.DIENTHOAI= nv.DIENTHOAI;
                updateNV.NGAYSINH= nv.NGAYSINH;
                updateNV.XOA = nv.XOA;
                updateNV.GIOITINH=nv.GIOITINH;
                updateNV.GHICHU= nv.GHICHU;
                updateNV.ANH=nv.ANH;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoaNV(QuanLyNhanVienDTO nv)
        {
            try
            {
                NHANVIEN delNV = tvt.NHANVIEN.SingleOrDefault(u => u.MANV == nv.MANV);
                if (delNV == null)
                    return false;
                delNV.XOA = true;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<QuanLyNhanVienDTO> timKiemNV(string nv)
        {
            var NV = tvt.NHANVIEN.ToList();
            return NV.Where(v => v.HOTEN.ToLower().Contains(nv.ToLower())).Select(u => new QuanLyNhanVienDTO
            {
                MANV=u.MANV,
                MATKHAU=u.MATKHAU,
                HOTEN=u.HOTEN,
                DIACHI=u.DIACHI,
                DIENTHOAI=u.DIENTHOAI,
                NGAYSINH=u.NGAYSINH,
                GIOITINH=u.GIOITINH,
                GHICHU=u.GHICHU
            }).ToList();
        }
        public bool IsExisted(QuanLyNhanVienDTO newNV)
        {
            var nvEF = tvt.NHANVIEN.SingleOrDefault(u => u.MANV == newNV.MANV);

            return nvEF != null;
        }
        
    }
}
