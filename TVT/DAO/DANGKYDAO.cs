using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class DANGKYDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        public bool themNV(QuanLyNhanVienDTO nv)
        {
            string Admin = ("AD" + (tvt.TAIKHOAN.Count() + 1)).ToString();
            string NV= ("NV" + (tvt.TAIKHOAN.Count() + 1)).ToString();
            try
            {
                NHANVIEN newNV = new NHANVIEN
                {
                    QUYEN = nv.Quyen,
                    MANV = nv.Quyen == true ? Admin : NV,
                    MATKHAU = nv.MATKHAU.Trim(),
                    HOTEN = nv.HOTEN,
                    DIACHI = nv.DIACHI,
                    DIENTHOAI = nv.DIENTHOAI.Trim(),
                    NGAYSINH = nv.NGAYSINH,
                    GIOITINH = nv.GIOITINH,
                    GHICHU = nv.GHICHU,
                    ANH = nv.ANH,
                    XOA = false
                };
                TAIKHOAN tkEF = new TAIKHOAN
                {
                    QUYEN = nv.Quyen,
                    TENDANGNHAP = nv.Quyen == true ? Admin : NV,
                    MATKHAU = nv.MATKHAU.Trim(),
                };
                tvt.TAIKHOAN.Add(tkEF);
                tvt.NHANVIEN.Add(newNV);
                tvt.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool IsExisted(QuanLyNhanVienDTO newNV)
        {
            var nvEF = tvt.NHANVIEN.SingleOrDefault(u => u.MANV == newNV.MANV);

            return nvEF != null;
        }
    }
}
