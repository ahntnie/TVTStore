using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuanLyNhanVienDTO
    {
        public string MANV { get; set; }
        public string MATKHAU { get; set; }
        public string HOTEN { get; set; }
        public string DIACHI { get; set; }
        public string DIENTHOAI { get; set; }
        public DateTime NGAYSINH { get; set; }
        public bool GIOITINH { get; set; }
        public bool XOA { get; set; }
        public string GHICHU { get; set; }
        public bool Quyen { get; set; }
        public byte[] ANH { get; set; }
        public string gt { get; set; }
    }
}
