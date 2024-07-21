using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Bai6_QLPhuongTien
{
    internal class QLPTGT
    {
        List<PTGT> danhSachPTGT = new List<PTGT>();

        public void NhapPTGT()
        {
            Console.WriteLine("Chon loai phuong tien de nhap (1: O To, 2: Xe May, 3: Xe Tai):");
            int loaiPT = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap hang san xuat: ");
            string hangSanXuat = Console.ReadLine();

            Console.WriteLine("Nhap nam san xuat: ");
            int namSanXuat = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap gia ban: ");
            double giaBan = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap mau: ");
            string mau = Console.ReadLine();

            switch(loaiPT)
            {
                case 1:
                    Console.WriteLine("Nhap so cho ngoi: ");
                    int soChoNgoi = int.Parse(Console.ReadLine());

                    Console.WriteLine("Nhap kieu dong co: ");
                    string kieuDongCo = Console.ReadLine();

                    OTo oTo = new OTo(hangSanXuat, namSanXuat, giaBan, mau, soChoNgoi, kieuDongCo);
                    danhSachPTGT.Add(oTo);
                    break;

                case 2:
                    Console.WriteLine("Nhap cong suat (KW): ");
                    double congSuat = double.Parse(Console.ReadLine());

                    XeMay xeMay = new XeMay(hangSanXuat, namSanXuat, giaBan, mau, congSuat);
                    danhSachPTGT.Add(xeMay);
                    break;

                case 3:
                    Console.WriteLine("Nhap trong tai (Tan): ");
                    double trongTai = double.Parse(Console.ReadLine());

                    XeTai xeTai = new XeTai(hangSanXuat, namSanXuat, giaBan, mau, trongTai);
                    danhSachPTGT.Add(xeTai);
                    break;
            }
            Console.WriteLine("Da them phuong tien giao thong thanh cong.");
        }

        public void TimPTGT()
        {
            Console.WriteLine("Chon tieu chi tim kiem (1: Mau, 2: Nam San Xuat): ");
            int tieuChi = int.Parse(Console.ReadLine());

            switch(tieuChi)
            {
                case 1:
                    Console.WriteLine("Nhap mau can tim: ");
                    string mau = Console.ReadLine();

                    var ketQuaTheoMau = danhSachPTGT.Where(pt => pt.Mau.ToLower() == mau.ToLower()).ToList();
                    HienThiDanhSachPTGT(ketQuaTheoMau);
                    break;

                case 2:
                    Console.WriteLine("Nhap nam san xuat can tim: ");
                    int namSanXuat = int.Parse(Console.ReadLine());

                    var ketQuaTheoNam = danhSachPTGT.Where(pt => pt.NamSanXuat == namSanXuat).ToList();
                    HienThiDanhSachPTGT(ketQuaTheoNam);
                    break;

                default:
                    Console.WriteLine("Tieu chi tim kiem khong hop le.");
                    break;
            }
        }

        private void HienThiDanhSachPTGT(List<PTGT> danhSach)
        {
            if (danhSach.Count == 0)
            {
                Console.WriteLine("Khong tim thay phuong tien nao.");
            }
            else
            {
                foreach (var ptgt in danhSach)
                {
                    ptgt.HienThi();
                    Console.WriteLine();
                }
            }
        }

        public void HienThiTatCaPTGT()
        {
            foreach (var ptgt in danhSachPTGT)
            {
                ptgt.HienThi();
                Console.WriteLine();
            }
        }
    }
}
