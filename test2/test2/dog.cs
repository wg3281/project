using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    /// <summary>
    /// 狗（结构）
    /// </summary>
    struct Dog
    {
        string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }
        public void Sing()
        {
            Console.WriteLine("旺旺");
        }
        public Dog(string name)
        {
            _name = name;
        }
    }
}
