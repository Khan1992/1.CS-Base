using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.流程控制语句switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要查询的录取分数线（比如民办本科，艺术类本科，体育类本科，二本，一本）");
            string strNum = Console.ReadLine();
            switch (strNum)
            {
                case "民办本科":
                    Console.WriteLine("民办本科录取分数线：350");
                    break;
                case "艺术类本科":
                    Console.WriteLine("艺术类本科录取分数线：290");
                    break;
                case "体育类本科":
                    Console.WriteLine("体育类本科录取分数线：280");
                    break;
                case "二本":
                    Console.WriteLine("二本录取分数线：455");
                    break;
                case "一本":
                    Console.WriteLine("一本录取分数线：555");
                    break;
                default:
                    Console.WriteLine("您输入的查询信息有误!");
                    break;
            }
            Console.ReadLine();
        } 
    }
}
