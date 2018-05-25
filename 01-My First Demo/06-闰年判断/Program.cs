using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_闰年判断
{
    class Program
    {
        static void Main(string[] args)
        {
            BeginYear:

            //判断闰年
            Console.WriteLine("请输入要判断的年份");
            int year = Convert.ToInt32(Console.ReadLine());
            //年份被400整除
            //年份能够被4整除但是不能被100整除
            //逻辑与的优先级高于逻辑或
            bool b = year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
            if (b)
            {
                Console.WriteLine("{0}年是闰年", year);
            }
            else
            {
                Console.WriteLine("{0}年不是闰年", year);
            }

            Console.WriteLine("输入 “1” 继续，否则 结束");
            string ct = Console.ReadLine();
            if (ct == "1") {
                goto BeginYear;
            }
            
            Console.ReadKey();
        }
    }
}
