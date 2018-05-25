using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_乘法口诀表
{
    class Program
    {
        static void Main(string[] args)
        {
            //乘法口诀 嵌套for 循环
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {

                    Console.Write("{0}*{1}={2}\t", i, j, i * j);

                }
                Console.WriteLine();

            }
            Console.ReadKey();

          

        }
    }
}
