using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop
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
        public uint _age = 0;
        public Pet(string name)
        {
            _name = name;
        }
        public void PrintName()
        {
            Console.WriteLine("Pet's name is " + _name);
        }
        public void ShowAge()
        {
            Console.WriteLine($"{_name}'Age={_age}");
        }
        virtual public void Speak()
        {

        }
        /// <summary>
        /// 重载操作符++
        /// </summary>
        /// <param name="pet"></param>
        /// <returns></returns>
        public static Pet operator ++(Pet pet)
        {
            ++pet._age;
            return pet;
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
        static int Num = 0;
        static Dog()
        {

        }
        public Dog(string name) : base(name)
        {
            ++Num;
            if (Newdog != null)
            {
                Newdog();
            }
        }
        public delegate void Handler();
        public static event Handler Newdog;
        
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
        public void IsHappy<T>(T target)where T : Pet
        {
            Console.WriteLine("Happy:");
            target.PrintName();
        }
        public static implicit operator Cat(Dog dog)
        {
            return new Cat(dog._name);
        }
        public void WagTail()
        {
            Console.WriteLine($"{_name} wag tail");
        }
    }
    public class Cat : Pet, ICatchMice, IClimbTree
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
        public static explicit operator Dog(Cat cat)
        {
            return new Dog(cat._name);
        }
        public void InnocentLook()
        {
            Console.WriteLine($"{_name} innocentlook");
        }
    }
    public abstract class DogCmd
    {
        public abstract string GetCmd();
    }
    public class SitDogCmd:DogCmd
    {
        public override string GetCmd()
        {
            return "sit";
        }
    }
    public class SpeakCmd : DogCmd
    {
        public override string GetCmd()
        {
            return "WoW";
        }
    }

    public interface IDogLearn<C> where C : DogCmd
    {
        void Act(C cmd);
    }
    public class Labrador : Dog,IDogLearn<DogCmd>
    {
        public Labrador(string name) : base(name)
        {

        }
        public void Act(DogCmd cmd)
        {
            Console.WriteLine(cmd.GetCmd());
        }
    }
    public class Cage<T>
    {
        T[] CageArray;
        readonly int Size=1;
        int num;
        public Cage(int n)
        {
            Size = n;
            num = 0;
            CageArray = new T[Size];
        }
        public void PutIn(T pet)
        {
            if (num < Size)
            {
                CageArray[num++] = pet;
            }
            else
            {
                Console.WriteLine("cage is full");
            }
        }
        public T TakeOut()
        {
            if (num > 0)
            {
                return CageArray[--num];
            }
            else
            {
                Console.WriteLine("cage is empty");
                return default(T);                
            }
        }

    }
    class Person
    {

    }
    class Client
    {
        public void WangADog()
        {
            Console.WriteLine("Great I want to see the new dog.");
        }
    }
    class Program
    {
        delegate void ActCute();
        static void Main(string[] args)
        {
            //Pet[] pets = new Pet[] { new Dog("Jack"), new Cat("Tom"),new Dog("Jerry") };
            //for (var i=0 ; i < pets.Length; i++)
            //{
            //    pets[i].Speak();
            //}
            //Cat c1 = new Cat("Tom1");
            //c1.CatchMice();
            //c1.Climbtree();
            //IClimbTree climb = (IClimbTree)c1;
            //climb.Climbtree();
            //ICatchMice catchMice = (ICatchMice)c1;
            //catchMice.CatchMice();
            //Dog.ShowNum();
            //Dog dog = new Dog("Tommy");
            //dog.HowToFeedDog();
            //{
            //    int i = 3;
            //    object oi = i;
            //    Console.WriteLine($"i={i} oi={oi}");
            //    oi = 10;
            //    Console.WriteLine($"i={i} oi={oi}");
            //    int j = (int)oi;
            //    Console.WriteLine("j=" + j);
            //}
            //Dog dog = new Dog("jack");
            //dog.Speak();
            //Cat cat = dog;
            //cat.Speak();
            //Dog dog2 = (Dog)cat;
            //dog2.Speak();
            //for (int i = 0; i < pets.Length; i++)
            //{
            //    pets[i]++;
            //    pets[i].ShowAge();
            //}
            //var dogCage = new Cage<Dog>(1);
            //dogCage.PutIn(new Dog("tom"));
            //dogCage.PutIn(new Dog("aa"));

            //var dog = dogCage.TakeOut();
            //dog.PrintName();
            //var dog = new Dog("to");
            //dog.IsHappy<Dog>(new Dog("b"));

            //Labrador dog = new Labrador("ss");
            //dog.Act(new SitDogCmd());
            //dog.Act(new SpeakCmd());
            //List<Dog> list = new List<Dog>();
            //list.Add(new Dog("a"));
            //list.Add(new Dog("b"));
            //list.Add(new Dog("c"));
            //list.RemoveAt(0);
            //for (int i = 0; i < list.Count; ++i)
            //{
            //    list[i].PrintName();
            //}

            //Dictionary<string, Dog> dic = new Dictionary<string, Dog>();
            //dic.Add("A",new Dog("a"));
            //dic.Add("B", new Dog("b"));
            //dic.Add("C", new Dog("c"));
            //dic["A"].PrintName();
            //Stack<Pet> stack = new Stack<Pet>();
            //stack.Push(new Dog("a"));
            //stack.Push(new Cat("b"));
            //stack.Peek().PrintName();
            //stack.Pop();
            //stack.Peek().PrintName();
            //Queue<Pet> queue = new Queue<Pet>();
            //queue.Enqueue(new Dog("a"));
            //queue.Enqueue(new Dog("b"));
            //queue.Enqueue(new Dog("c"));
            //queue.Peek().PrintName();
            //queue.Dequeue();
            //queue.Peek().PrintName();
            //queue.Dequeue();
            //queue.Peek().PrintName();
            //queue.Dequeue();
            //ActCute del = null;
            //Dog dog = new Dog("a");
            //Cat cat = new Cat("b");
            //del = dog.WagTail;
            //del += cat.InnocentLook;
            //del +=() =>
            // {
            //     Console.WriteLine("do nothing");
            // };
            //del();
            Client c1 = new Client();
            Client c2 = new Client();
            Dog.Newdog += c1.WangADog;
            //Dog.Newdog += c2.WangADog;
            Dog dog = new Dog("q");
        }
    }
}
