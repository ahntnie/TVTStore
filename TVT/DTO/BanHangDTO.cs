using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BanHangDTO
    {
        public int MASP { get; set; }
        public string TEN { get; set; }
        public int MALOAISP { get; set; }
        public int MANSX { get; set; }
        public int SOLUONG { get; set; }
        public int DONGIA { get; set; }
        public string MOTA { get; set; }
        public bool XOA { get; set; }
        public string GHICHU { get; set; }
        public byte[] ANH { get; set; }
    }
}
