using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class QUANLYSANPHAMBUS
    {
        QUANLYSANPHAMDAO _quanLySPDAO = new QUANLYSANPHAMDAO();
        public List<QuanLySanPhamDTO> LayDSSP()
        {
            return _quanLySPDAO.LayDSSP();
        }
        public List<QuanLySanPhamDTO> BaoCaoSP()
        {
            return _quanLySPDAO.BaoCaoSP();
        }
        public List<QuanLySanPhamDTO> timKiemSP(string sp)
        {
            return _quanLySPDAO.timKiemSP(sp);
        }
        public bool themSP(QuanLySanPhamDTO sp)
        {
            if (_quanLySPDAO.IsExisted(sp))
                return false;
            return _quanLySPDAO.themSP(sp);
        }
        public bool suaSP(QuanLySanPhamDTO sp)
        {
            return _quanLySPDAO.suaSP(sp);
        }
        public bool xoaSP(QuanLySanPhamDTO sp)
        {
            return _quanLySPDAO.xoaSP(sp);
        }

    }
}
