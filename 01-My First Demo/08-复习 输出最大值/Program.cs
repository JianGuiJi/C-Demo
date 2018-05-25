using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_复习_输出最大值
{
    class Program
    {
        static void Main(string[] args)
        {
            //调试方法：
            //F11 逐语句调试：单步执行,进入调用的其它函数
            //F10 逐过程调试：单步执行，不进入调用的其它函数
            //断点调试：添加断点 F5
            int max = 0;
            string input = "";
            while (input != "end")
            {
                Console.WriteLine("输入一个数字，输入end 将显示最大值");
                input = Console.ReadLine();
                if (input != "end")
                {
                    try
                    {
                        int number = Convert.ToInt32(input);
                        if (number > max)
                        {
                            max = number;//把大的值赋值给变量max
                        }
                        
                    }
                    catch
                    {
                        Console.WriteLine("输入的字符串不能转换成数字，请重新输入");
                    }

                }
                else
                {
                    Console.WriteLine("输入的是end,最大值：{0}", max);
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
