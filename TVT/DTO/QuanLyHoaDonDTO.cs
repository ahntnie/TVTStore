using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyHoaDonDTO
    {
        public string MAHD { get; set; }
        public DateTime NGAYBAN { get; set; }
        public string MANV { get; set; }
        public string TENNV { get; set; }
        public string MAKH { get; set; }
        public int? TONGTIEN { get; set; }
        public string GHICHU { get; set; }
        public bool TRANGTHAI { get; set; }
    }
}
