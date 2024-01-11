using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class NHASANXUATDAO
    {
        DOANTVTEntities tvt = new DOANTVTEntities();
        public List<NhaSanXuatDTO> LayDSNSX()
        {
            var lstNSX = tvt.NHASANXUAT.ToList();
            return lstNSX.Where(v => v.XOA == false).Select(u => new NhaSanXuatDTO
            {
              MANSX=u.MANSX,
              TEN=u.TEN,
              WEBSITE=u.WEBSITE,
              EMAIL=u.EMAIL,
              XOA=false,
              GHICHU=u.GHICHU,
            }).ToList();
        }
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

        public bool themNSX(NhaSanXuatDTO nsx)
        {
            var nsxTen= tvt.NHASANXUAT.SingleOrDefault(u => u.TEN == nsx.TEN);
            try
            {
                if (nsxTen == null)
                {
                    NHASANXUAT nsxEF = new NHASANXUAT
                    {
                        MANSX = ("NSX"+(tvt.NHASANXUAT.Count()+1)).ToString(),
                        TEN = nsx.TEN,
                        WEBSITE = nsx.WEBSITE,
                        GHICHU = nsx.GHICHU,
                        XOA = false,
                        EMAIL = nsx.EMAIL,
                    };
                    tvt.NHASANXUAT.Add(nsxEF);
                }
                else
                {
                    nsxTen.XOA = false;
                    nsxTen.WEBSITE= nsx.WEBSITE;
                    nsxTen.EMAIL= nsx.EMAIL;
                    nsxTen.GHICHU= nsx.GHICHU;
                }
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool suaNSX(NhaSanXuatDTO nsx)
        {
            try
            {
                NHASANXUAT editNSX = tvt.NHASANXUAT.SingleOrDefault(u => u.MANSX == nsx.MANSX);
                if (editNSX == null)
                    return false;
                editNSX.TEN= nsx.TEN;
                editNSX.MANSX= nsx.MANSX;
                editNSX.EMAIL= nsx.EMAIL;
                editNSX.WEBSITE= nsx.WEBSITE;
                editNSX.GHICHU= nsx.GHICHU;
                editNSX.XOA = nsx.XOA;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool xoaNSX(NhaSanXuatDTO nsx)
        {
            try
            {
                NHASANXUAT delnsx = tvt.NHASANXUAT.SingleOrDefault(u => u.MANSX == nsx.MANSX);
                if (delnsx == null)
                    return false;
                delnsx.XOA = true;
                tvt.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public List<NhaSanXuatDTO> timKiemNSX(string nsx)
        {
            var NSX = tvt.NHASANXUAT.ToList();

            return NSX.Where(v => v.TEN.ToLower().Contains(nsx.ToLower())).Select(u => new NhaSanXuatDTO
            {
                TEN = u.TEN,
                MANSX = u.MANSX,
                WEBSITE = u.WEBSITE,
                EMAIL = u.EMAIL,
                GHICHU = u.GHICHU,

            }).ToList();
        }
        public bool IsExisted(NhaSanXuatDTO newNSX)
        {
            var nsxEF = tvt.NHASANXUAT.SingleOrDefault(u => u.MANSX == newNSX.MANSX);

            return nsxEF != null;
        }
    }
}
