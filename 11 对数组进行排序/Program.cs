using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_对数组进行排序
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 3, 9, 27, 6, 18, 12, 21, 15 };
            Array.Sort(arr);

            foreach (int arrs in arr)
            {
                Console.Write(arrs + " ");
            }

            Console.ReadLine();
        }
    }
}
