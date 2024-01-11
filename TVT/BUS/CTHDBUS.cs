using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class CTHDBUS
    {
        CTHDDAO _cthdDAO = new CTHDDAO();
        public List<CTHoaDonDTO> LayDSCTHD()
        {
            return _cthdDAO.LayDSCTHD();
        }
        public bool SuaCTHD(CTHoaDonDTO hd)
        {
            return _cthdDAO.suaCTHD(hd);
        }
        public bool xoaCTHD(CTHoaDonDTO hd)
        {
            return _cthdDAO.xoaCTHD(hd);
        }
        public bool thanhToanHD(QuanLyKhachHangDTO kh, HoaDonDTO hd)
        {
            return _cthdDAO.thanhToanHD(kh, hd);
        }
        public List<CTHoaDonDTO> inHoaDon()
        {
            return _cthdDAO.inHOADON();
        }
        public List<CTHoaDonDTO> LayDSCTHDVuaThanhToan()
        {
            return _cthdDAO.LayDSCTHDVuaThanhToan();
        }
        public List<CTHoaDonDTO> LayDSTheoSLBanRa()
        {
            return _cthdDAO.LayDSTheoSLBanRa();
        }
        public string layMaHD()
        {
            return _cthdDAO.layMaHD();
        }
        public bool AnCTHD()
        {
            return _cthdDAO.AnCTHD();
        }
        public List<CTHoaDonDTO> LayHDTheoNgay()
        {
            return _cthdDAO.LayHDTheoNgay();
        }
    }
}
