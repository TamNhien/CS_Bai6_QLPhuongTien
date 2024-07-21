using CS_Bai6_QLPhuongTien;

class Program
{
    static void Main(string[] args)
    {
        QLPTGT qlptgt = new QLPTGT();

        while (true)
        {
            Console.WriteLine("Chon chuc nang:");
            Console.WriteLine("1. Nhap dang ky phuong tien");
            Console.WriteLine("2. Tim phuong tien");
            Console.WriteLine("3. Hien thi tat ca phuong tien");
            Console.WriteLine("4. Thoat");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    qlptgt.NhapPTGT();
                    break;
                case 2:
                    qlptgt.TimPTGT();
                    break;
                case 3:
                    qlptgt.HienThiTatCaPTGT();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Chon chuc nang khong hop le. Vui long thu lai.");
                    break;
            }
        }
    }
}