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
    struct Fish
    {
        int weigth;
        int size;
        int type;
    }
    abstract public class Pet
    {

        protected string _name;
        public uint Age;
        public Pet(string name)
        {
            _name = name;
        }
        public void PrintName()
        {
            Console.WriteLine("Pet's name is " + _name);
        }
        virtual public void Speak()
        {

        }

    }
    interface ICatchMice
    {
        void CatchMice();
    }
    interface IClimbTree
    {
        void Climbtree();
    }
    static class PetGuide
    {
        static public void HowToFeedDog(this Dog dog)
        {
            Console.WriteLine("Play a vedio about how to feed a dog.");
        }
    }
    public class Dog : Pet
    {
        static int Num=0;
        static Dog()
        {

        }
        public Dog(string name):base(name)
        {
            ++Num;
        }
        public new void PrintName()
        {
            Console.WriteLine("宠物名字是 " + _name);
        }
        public sealed override void Speak()
        {
            Console.WriteLine($"{_name} is speaking wangwang");
        }
        static public void ShowNum()
        {
            Console.WriteLine(Num);
        }
    }
    public class Cat : Pet,ICatchMice,IClimbTree
    {
        public Cat(string name) : base(name)
        {
            
        }

        public void CatchMice()
        {
            Console.WriteLine($"{_name} catched Mice");
        }

        public void Climbtree()
        {
            Console.WriteLine($"{_name} climbed tree");
        }

        public override void Speak()
        {
            Console.WriteLine($"{_name} is speaking wow");
        }
    }
    public class Labrador : Dog
    {
        public Labrador(string name) : base(name)
        {

        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pet[] pets = new Pet[] { new Dog("Jack"), new Cat("Tom"),new Dog("Jerry") };
            for (var i=0 ; i < pets.Length; i++)
            {
                pets[i].Speak();
            }
            Cat c1 = new Cat("Tom1");
            c1.CatchMice();
            c1.Climbtree();
            IClimbTree climb = (IClimbTree)c1;
            climb.Climbtree();
            ICatchMice catchMice = (ICatchMice)c1;
            catchMice.CatchMice();
            Dog.ShowNum();
            Dog dog = new Dog("Tommy");
            dog.HowToFeedDog();
            {
                int i = 3;
                object oi = i;
                Console.WriteLine($"i={i} oi={oi}");
                oi = 10;
                Console.WriteLine($"i={i} oi={oi}");
                int j = (int)oi;
                Console.WriteLine("j=" + j);
            }
        }
    }
}
