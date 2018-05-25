using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_加加减减
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 50;
            number--;
            Console.WriteLine(number);
        
            number++;
            Console.WriteLine(number);
            Console.ReadKey();

            int num = 10;
            int result = 10 + num++;//20 先运算再加一
            Console.WriteLine(result);
            int res = 10 + ++num;//22 先加一 再运算
            Console.WriteLine(res);
            Console.ReadKey();


            int num2 = 10;
            int result2 = 10 + num2--;//20 先运算再减一
            Console.WriteLine(result2);
            int res2 = 10 + --num2;//18 先减一 再运算
            Console.WriteLine(res2);
            Console.ReadKey();

            int a = 5;
            int b = a++ + ++a * 2 + --a + a++;//5+7*2+6+6=31
            Console.WriteLine(a);//7
            Console.WriteLine(b);//31
            Console.ReadKey();
            // 一元运算符：++ -- 
            // 二元运算符：+ - * / %
            // 如果表达式中， 既有一元运算符 又有二元运算符，我们首先计算一元运算符

            //4、关系运算符 > < >= <= == !=
            //5、bool类型
            //6、逻辑运算符 &&逻辑与 || 逻辑或 !逻辑非
            //7、复合赋值运算符（二元）  += -= *= /= %=



       


        }
    }
}
