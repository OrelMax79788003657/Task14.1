using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task14._1
{
    public abstract class Animal
    {
        public abstract string name { get; set; }

        public Animal()
        {
            this.name = "Животное";
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine($"Имя: {name}");
            Say();
        }
        public class Cat : Animal
        {
            public override string name { get; set; }
            public Cat(string name)
            {
                this.name = name;
            }
            public override void Say()
            {
                Console.WriteLine("Мяу");
            }
        }
        public class Dog : Animal
        {
            public override string name { get; set; }
            public Dog(string name)
            {
                this.name = name;
            }
            public override void Say()
            {
                Console.WriteLine("Гав");
            }

        }
        internal class Program
        {
            static void Main()
            {
                Console.Write("Введите кличку кота: ");
                string nameCat =Console.ReadLine();

                Console.Write("Введите кличку собаки: ");
                string nameDog=Console.ReadLine();

                Cat cat = new Cat(nameCat);
                cat.Say();
                cat.ShowInfo();

                Dog dog = new Dog(nameDog);
                dog.Say();
                dog.ShowInfo();

                Console.ReadKey();
            }
        }
    }
}
