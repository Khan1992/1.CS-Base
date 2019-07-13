using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.打印九九乘法表for
{
    class Program
    {
        static void Main(string[] args)
        {
            int iRow, iColum;
            for (iRow = 1; iRow < 10; iRow++)
            {
                for (iColum = 1; iColum <= iRow; iColum++)
                {
                    Console.Write("{0}*{1}={2} ", iColum, iRow, iRow * iColum);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
