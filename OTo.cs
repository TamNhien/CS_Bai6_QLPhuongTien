using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai6_QLPhuongTien
{
    internal class OTo : PTGT
    {
        public int SoChoNgoi {  get; set; }
        public string KieuDongCo {  get; set; }

        public OTo(string hangSanXuat, int namSanXuat, double giaBan, string mau, int soChoNgoi, string kieuDongCo)
            : base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            SoChoNgoi = soChoNgoi;
            KieuDongCo = kieuDongCo;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"So cho ngoi: {SoChoNgoi}, Kieu dong co: {KieuDongCo}");
        }
    }    
}
