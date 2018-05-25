using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Convert类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //类型兼容：显示（强制）类型转换，自动类型转换
            //int --double  double--int

            //字符串转换成整型：类型不兼容 使用Convert 前提条件：面上要过得去，即字符串内容是数字
            String s = "3.14";
            double d = Convert.ToDouble(s);
            int n = Convert.ToInt32("12");

            char c = Convert.ToChar("a");

            Console.WriteLine(d);
            Console.WriteLine(n);
            Console.WriteLine(c);
            Console.ReadKey();

            //让用户输入姓名 语文 数学 英语三门课程的成绩
            //然后给用户显示：xx ,你的总成绩为xx分，平均成绩为xx分
            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();           
       
            Console.WriteLine("请输入语文成绩");
            string strChinese = Console.ReadLine();

            Console.WriteLine("请输入数学成绩");
            string strMath = Console.ReadLine();

            Console.WriteLine("请输入英语成绩");
            string strEnglinsh = Console.ReadLine();

            //类型转换前需要检验一下字符串的必须是数值 方法：http://www.jb51.net/article/85861.htm

            //字符串相加会变成相连，最终会变成相连接。先转换成int或者 double
            //int chinese = Convert.ToInt32(strChinese);
            //int math = Convert.ToInt32(strMath);
            //int english = Convert.ToInt32(strEnglinsh);

            //int total = chinese + math + english;
            //double agv = (double)total / 3; //或者乘以1.0

            double chinese = Convert.ToDouble(strChinese);
            double math = Convert.ToDouble(strMath);
            double english = Convert.ToDouble(strEnglinsh);

            double total = chinese + math + english;
            double agv = total / 3;
            Console.WriteLine("{0}你的总成绩是{1}，平均成绩{2:0.00}", name, total, agv);

            Console.ReadKey();


        }
    }
}
