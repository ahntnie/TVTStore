using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTHoaDonDTO
    {
        public string MAHD { get; set; }
        public int STT { get; set; }
        public string MASP { get; set; }
        public int SOLUONG { get; set; }
        public int DONGIA { get; set; }
        public int THANHTIEN { get; set; }
        public Nullable<bool> TRANGTHAI { get; set; }
        public string TENSP { get; set; }
        public DateTime NGAYBAN { get; set; }
        public string  TENNV  {get; set; }

    }
}
