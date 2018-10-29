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
            XiaoMing.Age = 3;
            XiaoMing.Height = 120;
            //Console.WriteLine("我今年"+XiaoMing.Age+"岁");
            //XiaoMing.PlayBall();
            //XiaoMing.EatSugar("牛奶糖");
            //XiaoMing.EatSugar(4);
            //XiaoMing.EatSugar("水果糖",2);
            //XiaoMing.EatSugar();
            XiaoMing.Add(3,7);
            Console.WriteLine($"和是{XiaoMing.Add(3, 7)}");
            Console.Read();
        }
    }
}
