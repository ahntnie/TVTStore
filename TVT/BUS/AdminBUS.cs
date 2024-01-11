using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class AdminBUS
    {
        AdminDAO _adminDAO=new AdminDAO();
        public QuanLyNhanVienDTO layTen_Quyen(string maNV)
        {
            return _adminDAO.layTen_Quyen(maNV);
        }
    }
}
