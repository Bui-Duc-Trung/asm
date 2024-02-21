using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm
{
    internal class TaiKhoan
    {
        public int SoThe { get; set; }
        public int PIN { get; set; }
        public string TenChuTaiKhoan { get; set; }
        public double SoDu {  get; set; }

        public TaiKhoan(int soThe, int pIN, string tenChuTaiKhoan, double soDu)
        {
            SoThe = soThe;
            PIN = pIN;
            TenChuTaiKhoan = tenChuTaiKhoan;
            SoDu = soDu;
        }

        public TaiKhoan()
        {
        }
    }
}
