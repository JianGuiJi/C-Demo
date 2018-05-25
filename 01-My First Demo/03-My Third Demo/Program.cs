using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_My_Third_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //编程实现计算几天 是几周零几天
            int days = 110;
            int weeks = days / 7;
            int day = days % 7;
            Console.WriteLine("{0}天是{1}周零{2}天", days, weeks, day);
            Console.ReadKey();

            //编程实现 107653秒是几天几小时几分钟几秒？
            int seconds = 100000;
            int secondsDay = 60 * 60 * 24;
            int theDay = seconds / secondsDay;//求得天数
            int secs = seconds % secondsDay;//求完天数后 剩余的秒数
            int hours = secs / 3600;//小时数
            secs = secs % 3600;//求得小时数后 剩余的秒数
            int mins = secs / 60;//求得分钟数
            secs = secs % 60;//最后剩余的秒数
       

            Console.WriteLine("{0}秒是{1}天{2}小时{3}分钟{4}秒", seconds, theDay, hours, mins, secs);
            Console.ReadKey();

        }
    }
}
