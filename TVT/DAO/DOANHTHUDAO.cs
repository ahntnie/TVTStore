using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   
    public class DOANHTHUDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        QUANLYHOADONDAO _qlhdDAO =new QUANLYHOADONDAO();
        CTHDDAO _cthdDAO=new CTHDDAO();
        public DoanhThuDTO layDoanhThu()
        {
            DoanhThuDTO dTO = new DoanhThuDTO
            {
                HD = _qlhdDAO.LayDSHD(),
                CTHD=_cthdDAO.LayDSCTHD(),
            };
            return dTO;
        }
    }
}
