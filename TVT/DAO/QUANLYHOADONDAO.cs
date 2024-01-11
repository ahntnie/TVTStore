using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
    public class QUANLYHOADONDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        public List<QuanLyHoaDonDTO> LayDSHD()
        {
            var lstHOADON = tvt.HDBANHANG.ToList();
            return lstHOADON.Where(v => v.TRANGTHAI == true).Select(u => new QuanLyHoaDonDTO
            {
                MAHD = u.MAHD,
                MANV = u.MANV,
                MAKH = u.MAKH,
                GHICHU = u.GHICHU,
                TONGTIEN = u.TONGTIEN,
                NGAYBAN = u.NGAYBAN,
                TRANGTHAI = true
            }).ToList();
        }
        
    }
}
