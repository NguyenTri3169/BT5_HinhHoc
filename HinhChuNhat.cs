using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_HinhHoc
{
    internal class HinhChuNhat : HinhHoc
    {
        public double chieuDai { get; set; }
        public double chieuRong { get; set; }

        public HinhChuNhat(double chieudai, double chieurong)
        {
            chieuDai = chieudai;
            chieuRong = chieurong;
        }
        public override double chuVi()
        {
            return 2 * (chieuDai + chieuRong);
        }

        public override double dienTich()
        {
            return chieuRong * chieuDai;
        }
    }
}
