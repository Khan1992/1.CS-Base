using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.数据类型
{
    class Program
    {
        static void Main(string[] args)
        {
            double height = 1.78;
            int weight = 75;

            double exponent = weight / (height * height);
            Console.WriteLine("你的身高为：" + height);
            Console.WriteLine("你的体重为：" + weight);
            Console.WriteLine("你的BIM指数为：" + exponent);
            Console.Write("你的体重属于：");
            if (exponent < 18.5)
            {
                Console.WriteLine("体重过轻");
            }
            else if(exponent >= 18.5 && exponent < 24.9)
            {
                Console.WriteLine("正常范围");
            }
            else if (exponent >= 24.9 && exponent < 29.9)
            {
                Console.WriteLine("体重过重");
            }
            else if (exponent > 29.9)
            {
                Console.WriteLine("肥胖");
            }

            Console.ReadLine();
        }
    }
}
