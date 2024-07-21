using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai6_QLPhuongTien
{
    internal class PTGT
    {
        public string HangSanXuat { get; set; }
        public int NamSanXuat { set; get; }
        public double GiaBan { set; get; }
        public string Mau { set; get; }

        public PTGT(string hangSanXuat, int namSanXuat, double giaBan, string mau)
        {
            HangSanXuat = hangSanXuat;
            NamSanXuat = namSanXuat;
            GiaBan = giaBan;
            Mau = mau;
        }

        public virtual void HienThi()
        {
            Console.WriteLine($"Hang san xuat: {HangSanXuat}, Nam san xuat: {NamSanXuat}, Gia ban: {GiaBan:C}, Mau: {Mau}");
        }
    }
}
