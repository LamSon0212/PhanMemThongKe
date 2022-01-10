using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhanMemThongKe
{
    class Temp
    {
        public static string Version = "2.0";
        public static string Server { get; set; }
        public static bool IsLogOut = false;
        public static bool admin = false;
        public static string VNW { get; set; }
        public static string TEN { get; set; }
        public static string MABOPHAN { get; set; }
        public static string PTN { get; set; }

        public static bool Upload = true;

        public static bool Xoa = true;
        public static bool Sua = true;
        public static bool Iso = true;




        //public static string fodel_HopDong = @"D:\CSharp\TEST DATA\HOPDONG\";

        //public static string fodel_BaoGia = @"D:\CSharp\TEST DATA\BAOGIA\";    

        public static string fodel_HopDong = @"\\htfhs216139\Share\8.技術標準\文件管理\TEST\HOPDONG\";

        public static string fodel_BaoGia = @"\\htfhs216139\Share\8.技術標準\文件管理\TEST\BAOGIA\";

        public static string fodel_vkIso = @"D:\CSharp\TEST DATA\VANKIENISO\";

        public static string fodel_BieuDonISo = @"D:\CSharp\TEST DATA\BIEU_DON_ISO\";

        public static string fodel_TieuChuanQuocTe = @"D:\CSharp\TEST DATA\TIEUCHUANQUOCTE\";

        public static string fodel_PhanTichBaoCaoChinh = @"D:\CSharp\TEST DATA\BAOCAOPHANTICHCHINH\";

        public static string fodel_PhanTichBaoCaoPhu = @"D:\CSharp\TEST DATA\BAOCAOPHANTICHPHU\";

        public static string fodel_TrinhKiChinh = @"D:\CSharp\TEST DATA\TRINHKICHINH\";

        public static string fodel_TrinhKiPhu = @"D:\CSharp\TEST DATA\TRINHKIPHU\";
    }
}
