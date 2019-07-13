using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.foreach遍历
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("狼人杀游戏主要身份：");
            string[] roles = { "狼人", "预言家", "村民", "女巫", "丘比特", "猎人", "守卫", };
            foreach (string role in roles)
            {
                Console.Write(role + "  ");
            }
            Console.ReadLine();
        }
    }
}
