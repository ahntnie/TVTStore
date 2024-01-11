using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DTO;
namespace BUS
{
    public class LOAISANPHAMBUS
    {
        LOAISANPHAMDAO _LSPDao= new LOAISANPHAMDAO();

        public List<LoaiSanPhamDTO> LayDSLoaiSP()
        {
            return _LSPDao.LayDSLoaiSP();
        }
        public List<LoaiSanPhamDTO> timKiemLSP(string lsp)
        {
            return _LSPDao.timKiemLSP(lsp);
        }
        public bool themLSP(LoaiSanPhamDTO lsp)
        {
            return _LSPDao.themLSP(lsp);
        }
        public bool suaLSP(LoaiSanPhamDTO lsp)
        {
            return _LSPDao.suaLSP(lsp);
        }
        public bool xoaLSP(LoaiSanPhamDTO lsp)
        {
            return _LSPDao.xoaLSP(lsp);
        }


    }
}
