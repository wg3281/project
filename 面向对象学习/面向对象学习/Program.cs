using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 面向对象学习
{
    /// <summary>
    /// 宠物父类
    /// </summary>
    public class Pet
    {
        public string Name;
        public uint Age;

        public void PrintName()
        {
            Console.WriteLine("Pet's name is "+Name);
        }
    }
    public class Dog : Pet
    {
         new public void PrintName()
        {
            Console.WriteLine("宠物名字是 " + Name);
        }
    }
    public class Cat : Pet
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Name = "Jack";
            dog.PrintName();
            Cat cat = new Cat();
            cat.Name = "Tom";
            cat.PrintName();

        }
    }
}
