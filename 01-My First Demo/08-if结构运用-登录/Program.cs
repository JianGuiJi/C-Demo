using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_if结构运用_登录
{
    class Program
    {
        static void Main(string[] args)
        {
            //让用户输入用户和密码；如果用户名为admin ，密码为888888 ，则提示登录成功
            int count = 0;//登录次数
            BeginLogin:
            count++;

            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string pwd = Console.ReadLine();
            //是否 提示重新登录
            bool needReLogin = true;
            if (name == "admin" && pwd == "888888")
            {
                Console.WriteLine("登录成功");
                needReLogin = false;
            }
            else if (name == "admin")
            {

                Console.WriteLine("登录失败，密码错误");
            }


            if (needReLogin)
            {
                Console.WriteLine("登录失败(第{0}次)：账号密码不正确", count);

                if (count >= 5)
                {
                    count--;
                    Console.WriteLine("登录失败{0}次，结束！", count);
                }
                else
                {                    
                    Console.WriteLine("是否重新登录？(Y/N 默认:Y)");
                    String reLogin = Console.ReadLine();
                    if (reLogin != "N" || reLogin != "n")
                    {
                        goto BeginLogin; //重新登录                  
                    }
                }

            }

            Console.ReadKey();
        }
    }
}
