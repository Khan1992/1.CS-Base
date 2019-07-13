using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.显式类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 198.99;
            int y = Convert.ToInt32(x);
            Console.WriteLine("y = " + y);

            long l = 3000000000;
            int i = Convert.ToInt32(l);
            Console.WriteLine("i = " + i);

            Console.ReadLine();
        }
    }
}
