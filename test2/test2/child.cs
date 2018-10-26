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
                if(value>=3&&value<=7)
                    _age = value;
            }
        }
        public int Height { get => height; set => height = value; }

        /// <summary>
        /// 踢足球
        /// </summary>
        public void PlayBall()
        {
            Console.WriteLine("耶！我是小小C罗");
        }

    }

}
