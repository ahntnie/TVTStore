using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
namespace BUS
{
    public class BANHANGBUS
    {
        BANHANGDAO _banHangDAO = new BANHANGDAO();
        public List<QuanLySanPhamDTO> LayDSSP()
        {
            return _banHangDAO.LayDSSP();
        }
        public bool themVaoCTHD(CTHoaDonDTO hd)
        {
            return _banHangDAO.themVaoCTHD(hd);
        }
        public List<CTHoaDonDTO> LayDSCTHD()
        {
            return _banHangDAO.LayDSCTHD();
        }
        public List<QuanLySanPhamDTO> timKiem(string tenSP)
        {
            return _banHangDAO.timKiem(tenSP);
        }
    }
}
