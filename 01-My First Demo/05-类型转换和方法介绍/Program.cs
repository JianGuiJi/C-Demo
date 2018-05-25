using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_类型转换和方法介绍
{
    class Program
    {
        static void Main(string[] args)
        {
            //int.Parse

            int numberOne = Convert.ToInt32("12");// 若参数不是数值字符串，会报异常
            int number = int.Parse("123");// 若参数不是数值字符串，会报异常
            double numD;
            double.TryParse("12.3",out numD);
            Console.WriteLine(numD);

            int numTry=1;
            bool b=int.TryParse("123a",out numTry);//成功 返回 true ,赋值numTry为解析的数值; 失败 返回 false, 赋值numTry为0;

            Console.WriteLine(number);
            Console.WriteLine(numTry);
            Console.WriteLine(b);

            Console.ReadKey();
        }
    }
}
