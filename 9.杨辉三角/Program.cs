using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.杨辉三角
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] Array_int = new int[10][];                  //定义一个10行的二维数组
            for (int i = 0; i < Array_int.Length; i++)          //遍历行数
            {
                Array_int[i] = new int[i + 1];                  //定义二维数组的列数
                for (int j = 0; j < Array_int[i].Length; j++)    //遍历二维数组的列数
                {
                    if (i <= 1)
                    {
                        Array_int[i][j] = 1;
                    }
                    else
                    {
                        if (j == 0 || j == Array_int[i].Length - 1)  //如果是行首或者行尾
                        {
                            Array_int[i][j] = 1;
                        }
                        else
                        {
                            Array_int[i][j] = Array_int[i - 1][j - 1] + Array_int[i - 1][j];
                        }
                    }
                }
            }

            for (int i = 0; i <= Array_int.Length; i++)            //输出杨辉三角
            {
                //循环控制每行前面打印的空格数
                for (int k = 0; k <= Array_int.Length - i; k++)
                {
                    Console.Write("   ");
                }
                //循环控制每行打印的数据
                for (int j = 0; j < Array_int[i].Length; j++)
                {
                    Console.Write("{0}    ", Array_int[i][j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
