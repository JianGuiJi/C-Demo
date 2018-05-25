using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            // 打印10次 欢迎光临
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("欢迎光临,前10位客户有优惠哦，您是第{0}位客户", i + 1);
            }

            Console.ReadKey();
        }
    }
}
