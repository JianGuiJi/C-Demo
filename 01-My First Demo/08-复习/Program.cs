using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_复习
{
    class Program
    {
        static void Main(string[] args)
        {
            //练习4：不断要求用户输入一个数字， 然后打印这个数字的二倍，当用户输入 q 的时候退出
            //循环体：提示用户输入一个数字 接收 转换 打印2倍
            //循环条件：输入的不是q
            string input = "";
            while (input != "q")
            {
                Console.WriteLine("输入一个数字，将打印出这个数字的2倍");
                input = Console.ReadLine();
                if (input != "q")
                {
                    try {
                        int number = Convert.ToInt32(input);
                        Console.WriteLine("您输入的数字的2倍是：{0}", number * 2);
                    } catch {
                        Console.WriteLine("输入的字符串不能转换成数字，请重新输入");
                    }
                   
                }
                else
                {
                    Console.WriteLine("输入的是q,程序退出");
                    break;
                }
            }
        }
    }
}
