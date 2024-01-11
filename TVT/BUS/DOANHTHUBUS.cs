using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class DOANHTHUBUS
    {
        DOANHTHUDAO _doanhthuDAO= new DOANHTHUDAO();
        public DoanhThuDTO layDoanhThu()
        {
            return _doanhthuDAO.layDoanhThu();
        }

    }
}
