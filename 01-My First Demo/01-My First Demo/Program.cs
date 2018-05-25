using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_My_First_Demo
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            /*  Console.ReadKey(); 是针对 VS.NET 用户的。这使得程序会等待一个按键的动作，防止程序从 Visual Studio .NET 启动时屏幕会快速运行并关闭。 */
            Console.ReadKey();
            Console.Write("output no line break ");
            Console.ReadKey();

            Rectangle r = new Rectangle();
            r.Acceptdetails();
            r.Display();

            Console.ReadKey();        
        }
    }
}
