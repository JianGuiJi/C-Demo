using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_My_Second_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("VS的快捷键：");
            //Console.ReadKey();

            #region 折叠冗余代码--这些代码实现了打印 VS的快捷键
            Console.WriteLine("Ctrl+K+D 快速对齐代码：按住 Ctrl键，按住K键，快速松开 K 键 ，同时按 D键 ");
            Console.WriteLine("Ctrl+Z 撤销");
            Console.WriteLine("Ctrl+S 保存（一定要经常保存）");
            Console.WriteLine("Ctrl+J 快速弹出智能提示");
            Console.WriteLine("Shift+End  Shift+Home 快速选中一行");
            Console.WriteLine("Ctrl+K+C :注释所选代码");
            Console.WriteLine("Ctrl+U 保存（一定要经常保存）");
            Console.WriteLine("F1 转到帮助文档");
            Console.WriteLine("折叠冗余代码: #Region和#endRegion");
            Console.ReadKey();
            #endregion

            //绿色波浪线：警告线
            int number = 0;//声明变量
            Console.WriteLine("使用声明的变量number：" + number);//使用变量 number 后 绿色波浪线消失
            double d = 1.1;//64 位双精度浮点型         
            string str = "我是一个字符串";//字符串类型
            char chr= 'A';//字符类型
            //decimal
            decimal money = 10.6m;//存储金额，值后面需要加一个m  128 位精确的十进制值，28-29 有效位数



        }
    }
}
