using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test2
{
    class Program
    {
        static Dog dog;
        static void Main(string[] args)
        {

            //Child child1 = new Child("小白","男",4);//实例化对象
            //Child child2 = new Child();
            //child2.Name = "胡小美";
            //child2.Age = 4;
            //Child child3 = new Child() { Name="周润发",Age=5 };
            //Console.Read();
            //Dog dog = new Dog();
            //dog.Name = "小白";
            //dog.Sing();
            //Console.WriteLine($"我叫{dog.Name}");
            //Child c1 = new Child("梁晓雪", Gender.女, 4);
            //Child c2 = new Child("刘小妞", Gender.男, 5);
            //Console.WriteLine($"我叫{c1.Name},我是{c1.Sex}生");
            //Console.WriteLine($"我叫{c2.Name},我是{c2.Sex}生");
            //Child c1 = new Child("刘有才",Gender.男,3);
            int age = 3;
            //Growth(c1);
            //Growth( age);
            Console.WriteLine($"我现在{age}岁");
            int ly, ny;
            Growth(age, out ly, out ny);
            Console.WriteLine($"我明年{ny},去年{ly}");
        }
        /// <summary>
        /// 长大一岁
        /// </summary>
        /// <param name="child"></param>
        static void Growth(Child child)
        {
            child.Age++;
            Console.WriteLine("我长大一岁");
        }
        static void Growth( int age)
        {
            age++;
            Console.WriteLine("2我长大一岁");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="age">现在的年龄</param>
        /// <param name="lastYear">去年的年龄</param>
        /// <param name="nextYear">明年的年龄</param>
        static void Growth(int age,out int lastYear, out int nextYear)
        {
            lastYear = age - 1;
            nextYear = age + 1;
        }
    }
}
