using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai6_QLPhuongTien
{
    internal class XeMay : PTGT
    {
        public double CongSuat {  get; set; }

        public XeMay(string hangSanXuat, int namSanXuat, double giaBan, string mau, double congSuat)
            :base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            CongSuat = congSuat;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Cong Suat: {CongSuat} KW");
        }
    }
}
