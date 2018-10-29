using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    /// <summary>
    /// 小朋友
    /// </summary>
    class child
    {
        private string name;//姓名
        private string _sex = "男";//性别
        private int height;//身高
        private int _age;

        public string Sex
        {
            get { return _sex; }
            //set { _sex = value; }
        }

        public string Name { get => name; set => name = value; }
        public int Age
        {
            get => _age;
            set
            {
                if (value >= 3 && value <= 7)
                    _age = value;
            }
        }
        public int Height { get => height; set => height = value; }

        /// <summary>
        /// 踢足球
        /// </summary>
        public void PlayBall()//方法声明
        {
            Console.WriteLine("耶！我是小小C罗");
        }
        /// <summary>
        /// 吃糖
        /// </summary>
        /// <param name="sugar">糖的名称</param>
        public void EatSugar(string sugar)
        {
            if (sugar == "榴莲糖")
            {
                Console.WriteLine("哎呀，最怕榴莲糖");
            }
            else
            {
                Console.WriteLine("哈哈，是我最喜欢的糖");
            }

        }
        /// <summary>
        /// 吃糖
        /// </summary>
        /// <param name="count">糖的数量</param>
        public void EatSugar(int count)
        {
            if (count > 3)
            {
                Console.WriteLine("吃糖太多对牙齿不好");
            }
            else
            {
                Console.WriteLine("吃吧，吃糖糖吧");
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sugar"></param>
        /// <param name="count"></param>
        public void EatSugar(string sugar, int count)
        {
            if (sugar == "牛奶糖" && count > 2)
            {
                Console.WriteLine("牛奶糖不能吃太多");
            }
            else if (count > 3)
            {
                Console.WriteLine("糖不能吃太多");
            }
            else
            {
                Console.WriteLine("吃糖糖吧");
            }
        }
        public void EatSugar()
        {
            if (Age < 4)
            {
                Console.WriteLine("年龄太小，不能吃糖");
                return;
            }
            else
            {
                Console.WriteLine("我喜欢吃棉花糖");
                Console.WriteLine("我喜欢吃泡泡糖");
                Console.WriteLine("我喜欢吃水果糖");
                Console.WriteLine("我喜欢吃牛奶糖");
                Console.WriteLine("我喜欢吃太妃糖");
                Console.WriteLine("我喜欢吃巧克力糖");
                Console.WriteLine("我喜欢吃高粱糖");
            }
        }
        /// <summary>
        /// 求和
        /// </summary>
        /// <param name="n1">加数1</param>
        /// <param name="n2">加数2</param>
        public int Add(int n1, int n2)
        {
            int sum = n1 + n2;
            return sum;//返回值
        }
    }

}
