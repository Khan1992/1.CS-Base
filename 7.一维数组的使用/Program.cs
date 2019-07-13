using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.一维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] day = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine((i + 1) + "月有" + day[i] + "天");
            }
            Console.ReadLine();
        }
    }
}
