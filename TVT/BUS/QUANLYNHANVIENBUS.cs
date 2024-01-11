using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
        public class QUANLYNHANVIENBUS
        {
            QUANLYNHANVIENDAO _quanLyNVDAO = new QUANLYNHANVIENDAO();
            public List<QuanLyNhanVienDTO> LayDSNV()
            {
                return _quanLyNVDAO.LayDSNV();
            }
            public List<QuanLyNhanVienDTO> timKiemNV(string sp)
            {
                return _quanLyNVDAO.timKiemNV(sp);
            }
            //public bool themNV(QuanLyNhanVienDTO sp)
            //{
            //    if (_quanLyNVDAO.IsExisted(sp))
            //        return false;
            //    return _quanLyNVDAO.themNV(sp);
            //}
            public bool suaNV(QuanLyNhanVienDTO sp)
            {
                return _quanLyNVDAO.suaNV(sp);
            }
            public bool xoaNV(QuanLyNhanVienDTO sp)
            {
                return _quanLyNVDAO.xoaNV(sp);
            }

    }
}
