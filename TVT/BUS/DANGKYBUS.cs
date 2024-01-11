using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class DANGKYBUS
    {
        DANGKYDAO _quanLyNVDAO = new DANGKYDAO();
        public bool themNV(QuanLyNhanVienDTO sp)
        {
            if (_quanLyNVDAO.IsExisted(sp))
                return false;
            return _quanLyNVDAO.themNV(sp);
        }
    }
}
