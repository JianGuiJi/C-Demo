using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_质数
{
    class Program
    {
        static void Main(string[] args)
        {
            //概念：质数又称素数。一个大于1的自然数，除了1和它自身外，不能被其他自然数整除的数叫做质数；否则称为合数
            //找出100内的所有素数
            int length = 100;
            for (int i = 0; i <= length; i++)
            {
                bool b = true;
                //计算规则：从2 到本身前一位 能不能正常
                for (int j = 2; j < i; j++)
                {
                    //除尽说明不是质数，也就饿没有再往下继续取余的必要了
                    if (i % j == 0)
                    {
                        b = false;
                        break;
                    }
                }
                //输入质数
                if (b)
                {
                    Console.WriteLine("质数：" + i);
                }

            }
            //算法，不是一般人能写的。。。。。
            Console.ReadKey();
        }
    }
}
