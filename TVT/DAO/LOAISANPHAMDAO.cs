using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAO
{
    public class LOAISANPHAMDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        public List<LoaiSanPhamDTO> LayDSLoaiSP()
        {
            var lstLoaiSP = tvt.LOAISANPHAM.ToList();
            return lstLoaiSP.Where(v => v.XOA == false).Select(u => new LoaiSanPhamDTO
            {
                MALOAISP = u.MALOAISP,
                TEN = u.TEN,
                XOA = false,
                GHICHU = u.GHICHU
            }).ToList();
        }
        //public int layMaSP(string tenLoaiSP)
        //{

        //    var lstLoaiSP = tvt.LOAISANPHAM.ToList();
        //    string maSP = lstLoaiSP.Where(v => v.TEN == tenLoaiSP);
        //}
        private static readonly string[] VietnameseSigns = new string[]

{

        "aAeEoOuUiIdDyY",

        "áàạảãâấầậẩẫăắằặẳẵ",

        "ÁÀẠẢÃÂẤẦẬẨẪĂẮẰẶẲẴ",

        "éèẹẻẽêếềệểễ",

        "ÉÈẸẺẼÊẾỀỆỂỄ",

        "óòọỏõôốồộổỗơớờợởỡ",

        "ÓÒỌỎÕÔỐỒỘỔỖƠỚỜỢỞỠ",

        "úùụủũưứừựửữ",

        "ÚÙỤỦŨƯỨỪỰỬỮ",

        "íìịỉĩ",

        "ÍÌỊỈĨ",

        "đ",

        "Đ",

        "ýỳỵỷỹ",

        "ÝỲỴỶỸ"

};



        public static string BoDauChuoi(string str)

        {
            //Tiến hành thay thế , lọc bỏ dấu cho chuỗi
            for (int i = 1; i < VietnameseSigns.Length; i++)

            {
                for (int j = 0; j < VietnameseSigns[i].Length; j++)

                    str = str.Replace(VietnameseSigns[i][j], VietnameseSigns[0][i - 1]);
            }
            return str;
        }

        public bool themLSP(LoaiSanPhamDTO lsp)
        {
            string[] tenTach = BoDauChuoi(lsp.TEN).Split(' ');
            string ma = "";
            for (int i = 0; i < tenTach.Length; i++)
            {
                ma += tenTach[i].Substring(0, 1).ToUpper();
            }
            var lstLSP = tvt.LOAISANPHAM.Where(u => u.MALOAISP.Substring(0, ma.Length).Equals(ma)).ToList();
            var lspMa = tvt.LOAISANPHAM.SingleOrDefault(u => u.TEN.Equals(lsp.TEN));
            var lspTrue = tvt.LOAISANPHAM.SingleOrDefault(v => v.MALOAISP == ma);
            try
            {
                if(lspMa != null)
                {
                    lspMa.XOA = false;
                    lspMa.GHICHU = lsp.GHICHU;
                }
                else if(lspTrue != null)
                {
                       LOAISANPHAM lspEF = new LOAISANPHAM
                    {
                        MALOAISP = (ma + lstLSP.Count()).ToString(),
                        TEN = lsp.TEN,
                        XOA = false,
                        GHICHU = lsp.GHICHU,
                    };
                        tvt.LOAISANPHAM.Add(lspEF);
                }
                else
                {
                    LOAISANPHAM lspEF = new LOAISANPHAM
                    {
                        MALOAISP = ma,
                        TEN = lsp.TEN,
                        XOA = false,
                        GHICHU = lsp.GHICHU,
                    };
                    tvt.LOAISANPHAM.Add(lspEF);
                }
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool suaLSP(LoaiSanPhamDTO lsp)
        {
            try
            {
                LOAISANPHAM editLsp = tvt.LOAISANPHAM.SingleOrDefault(u => u.MALOAISP == lsp.MALOAISP);
                editLsp.TEN= lsp.TEN;
                editLsp.GHICHU= lsp.GHICHU;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoaLSP(LoaiSanPhamDTO sp)
        {
            try
            {
                LOAISANPHAM dellsp = tvt.LOAISANPHAM.SingleOrDefault(u => u.MALOAISP == sp.MALOAISP);
                if (dellsp == null)
                    return false;
                dellsp.XOA = true;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<LoaiSanPhamDTO> timKiemLSP(string lsp)
        {
            var LSP = tvt.LOAISANPHAM.ToList();

            return LSP.Where(v => v.TEN.ToLower().Contains(lsp.ToLower())).Select(u => new LoaiSanPhamDTO
            {
                TEN = u.TEN,
                MALOAISP = u.MALOAISP,
                GHICHU = u.GHICHU,

            }).ToList();
        }
        public bool IsExisted(LoaiSanPhamDTO newLSP)
        {
            var lspEF = tvt.LOAISANPHAM.SingleOrDefault(u => u.MALOAISP == newLSP.MALOAISP);

            return lspEF != null;
        }
    }
}
