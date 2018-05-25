using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_for循环练习
{
    class Program
    {
        static void Main(string[] args)
        {
            // 求 1-100之间的所有整数和  偶数和 奇数和
            int sum = 0;// 所有整数和
            int sumEven = 0;//偶数和
            int sumOdd = 0;
            int length = 100;
            for (int i = 0; i <= length; i++)
            {
                sum += i;
                if (i % 2 == 0)
                {
                    sumEven += i;
                }
                else
                {
                    sumOdd += i;
                }

            }

            //输出
            Console.WriteLine("整数和：{0}，偶数和：{1}，奇数和：{2}", sum, sumEven, sumOdd);
            Console.ReadKey();

            //水仙花数（100-999）：百位的立方+十位的立方+个位的立方==当前这个百位数字
            // 例如： 153= 1*1*1+5*5*5+3*3*3===1+125+27
            length = 1000;
            int hundreds = 0; //百位             

            int tens = 0;//十位

            int units = 0;//个位
            for (int i = 100; i < length; i++)
            {
                hundreds = i / 100; //百位             

                tens = i % 100 / 10;//十位

                units = i % 10;//个位

                if (i == hundreds * hundreds * hundreds + tens * tens * tens + units * units * units)
                {
                    Console.WriteLine("水仙花数：{0}", i);
                    /*
                    水仙花数：153
                    水仙花数：370
                    水仙花数：371
                    水仙花数：407
                    */

                }
            }
            Console.ReadKey();


        }
    }
}
