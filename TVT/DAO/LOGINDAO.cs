using DTO;
using System.Collections.Generic;
using System.Linq;

namespace DAO
{
    public class LOGINDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        public List<LoginDTO> LAYDSTK()
        {
            var lstTaiKhoan = tvt.TAIKHOAN.ToList();
            return lstTaiKhoan.Select(u => new LoginDTO
            {
                TENDANGNHAP = u.TENDANGNHAP,
                MATKHAU = u.MATKHAU,
                QUYEN = u.QUYEN
            }).ToList();
        }
        public bool KT_TK(string taiKhoan, string mk)
        {
            TAIKHOAN newTK= tvt.TAIKHOAN.SingleOrDefault(u=>u.TENDANGNHAP == taiKhoan);
            if(newTK==null) 
                return false;
            if(newTK.MATKHAU.Equals(mk) )
                return true;
            return false;
        }
        public bool KT_Quyen(string taiKhoan)
        {
            TAIKHOAN newTK = tvt.TAIKHOAN.SingleOrDefault(u => u.TENDANGNHAP == taiKhoan);
            if (newTK == null)
                return false;
            if (newTK.QUYEN==true)
                return true;
            return false;
        }
        //public List<QuanLyNhanVienDTO> layTK()
        //{
        //    var tk=tvt.TAIKHOAN.ToList();
            
        //}
    }
}
