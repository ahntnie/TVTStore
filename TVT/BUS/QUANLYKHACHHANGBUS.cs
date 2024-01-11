using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class QUANLYKHACHHANGBUS
    {
        QUANLYKHACHHANGDAO _qlKHDAO = new QUANLYKHACHHANGDAO();
        public List<QuanLyKhachHangDTO> LayDSKH()
        {
            return _qlKHDAO.LayDSKH();
        }
        public List<QuanLyKhachHangDTO> timKiemKH(string kh)
        {
            return _qlKHDAO.timKiemKH(kh);
        }
        public bool suaKH(QuanLyKhachHangDTO kh)
        {
            return _qlKHDAO.suaKH(kh);
        }
        public bool xoaKH(QuanLyKhachHangDTO kh)
        {
            return _qlKHDAO.xoaKH(kh);
        }
    }
}
