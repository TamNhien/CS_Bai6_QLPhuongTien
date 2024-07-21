using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai6_QLPhuongTien
{
    internal class XeTai : PTGT
    {
        public double TrongTai {  get; set; }

        public XeTai(string hangSanXuat, int namSanXuat, double giaBan, string mau, double trongTai)
            :base(hangSanXuat, namSanXuat, giaBan, mau)
        {
            TrongTai = trongTai;
        }

        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine($"Trong Tai: {TrongTai} Tan");
        }
    }
}
