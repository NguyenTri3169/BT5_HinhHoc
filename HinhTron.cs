using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_HinhHoc
{
    internal class HinhTron : HinhHoc
    {
        public double banKinh { get; set; }

        public HinhTron(double bankinh)
        {
            banKinh = bankinh;
        }
        public override double chuVi()
        {
            return 2 * Math.PI * banKinh;
        }

        public override double dienTich()
        {
            return Math.PI * banKinh * banKinh;
        }
    }
}
