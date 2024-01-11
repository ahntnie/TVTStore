using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLySanPhamDTO
    {
        public string MASP { get; set; }
        public string TEN { get; set; }
        public string TENLOAISP { get; set; }
        public string TENNSX { get; set; }
        public int SOLUONG { get; set; }
        public int DONGIA { get; set; }
        public string MOTA { get; set; }
        public bool XOA { get; set; }
        public string GHICHU { get; set; }
        public string MALOAISP { get; set; }   
        public string MANSX { get; set; }
        public byte[] ANH { get; set; }

    }
}
