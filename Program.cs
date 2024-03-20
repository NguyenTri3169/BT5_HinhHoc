using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT5_HinhHoc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HinhChuNhat hcn = new HinhChuNhat(10, 20);
            HinhTron ht = new HinhTron(5);
            Console.WriteLine($"Chu vi và dien tich HCN: {hcn.chuVi()} và {hcn.dienTich()}");
            Console.WriteLine($"Chu vi và dien tich HT: {ht.chuVi()} và {ht.dienTich()}");
            Console.ReadLine();

        }
    }
}
