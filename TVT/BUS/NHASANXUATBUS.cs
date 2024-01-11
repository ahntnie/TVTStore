using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class NHASANXUATBUS
    {
        NHASANXUATDAO _nsxDAO= new NHASANXUATDAO();
        public List<NhaSanXuatDTO> LayDSNSX()
        {
            return _nsxDAO.LayDSNSX();  
        }
        public List<NhaSanXuatDTO> timNSX(string nsx)
        {
            return _nsxDAO.timKiemNSX(nsx);
        }
        public bool themNSX(NhaSanXuatDTO nsx)
        {
            return _nsxDAO.themNSX(nsx);
        }
        public bool suaNSX(NhaSanXuatDTO nsx)
        {
            return _nsxDAO.suaNSX(nsx);
        }
        public bool xoaNSX(NhaSanXuatDTO nsx)
        {
            return _nsxDAO.xoaNSX(nsx);
        }
    }
}
