using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <TaiKhoan> DanhSachTaiKhoan = new List <TaiKhoan>();
            DanhSachTaiKhoan.Add(new TaiKhoan(0923511224, 322005, "Bui Duc Trung", 12000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0335048696, 250178, "Doan thi Xuyen", 50000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456781, 123451, "Doan thi Huong", 58000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456782, 123452, "Tran Quang Minh", 7000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456783, 123453, "Le Van Vu", 90000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456784, 123454, "Doan thi Nhung", 990000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456785, 123455, "Vu The Nam", 20000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456786, 123456, "Bui Dinh Chi", 86000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456787, 123457, "Le Hoang Bach", 50000000));
            DanhSachTaiKhoan.Add(new TaiKhoan(0123456788, 123458, "Tran Duc Lam", 59000000));

            Console.WriteLine("Nhap so the: ");
            int sothe = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap ma PIN: ");
            int pin = int.Parse(Console.ReadLine());

            
        }
    }
}
