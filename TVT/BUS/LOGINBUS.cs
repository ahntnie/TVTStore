using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LOGINBUS
    {
        LOGINDAO _loginDAO= new LOGINDAO();
        public List<LoginDTO> LAYDSTK()
        {
            return _loginDAO.LAYDSTK();
        }
        public bool KT_TK(string taiKhoan, string mk)
        {
            if(_loginDAO.KT_TK(taiKhoan,mk)) {
                return true;
            }
            return false;
        }
        public bool KT_Quyen(string taiKhoan)
        {
            return _loginDAO.KT_Quyen(taiKhoan);
        }
    }
}
