﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.二维数组的使用
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "简单客车售票系统";
            string[,] zuo = new string[9, 4];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    zuo[i, j] = "【有票】";
                }
            }

            string s = string.Empty;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\n         简单客车售票系统+\n");
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        System.Console.Write(zuo[i, j]);
                    }
                    Console.WriteLine();
                }

                Console.Write("请输入座位行号和列号（如:0,2）输入q键退出：");
                s = Console.ReadLine();
                if (s == "q") break;
                string[] ss = s.Split(',');
                int one = int.Parse(ss[0]);
                int two = int.Parse(ss[1]);
                zuo[one, two] = "【已售】";
            }


        }
    }
}
