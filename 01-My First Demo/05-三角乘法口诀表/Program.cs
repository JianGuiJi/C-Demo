using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_三角乘法口诀表
{
    class Program
    {
        static void Main(string[] args)
        {
            //三角乘法口诀表
            //
            //乘法口诀 嵌套for 循环
            for (int i = 1; i < 10; i++)
            {
                // i小于等于j
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("{0}*{1}={2}\t", i, j, i * j);

                }
                Console.WriteLine();

            }

            Console.WriteLine("=========================================");
            for (int i = 0, j = 6; i <=6; i++, j--)
            {
                Console.WriteLine("{0}+{1}={2}", i, j, i + j);

            }
            Console.ReadKey();
        }
    }
}
