using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            child XiaoMing = new child();//实例化对象
            XiaoMing.Name = "马小明";
            //XiaoMing.Sex = "男";
            XiaoMing.Age = 6;
            XiaoMing.Height = 120;
            Console.WriteLine("我今年"+XiaoMing.Age+"岁");
            //XiaoMing.PlayBall();
            Console.Read();
        }
    }
}
