using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class NHANVIENDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        public QuanLyNhanVienDTO layTen_Quyen(string maNV)
        {
            NHANVIEN nv = tvt.NHANVIEN.SingleOrDefault(u => u.MANV == maNV);
            QuanLyNhanVienDTO NV = new QuanLyNhanVienDTO
            {
                HOTEN = nv.HOTEN,
                Quyen = nv.QUYEN,
            };
            return NV;
        }
    }
}
