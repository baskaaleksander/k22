using System;

namespace _5_interfejsy
{
    public interface IAnimal {
        void MakeSound();
        void Eat();
    }

    public abstract class Animal : IAnimal {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age) {
            Name = name;
            Age = age;
        }
        public void Eat() {
            Console.WriteLine($"{Name} is eating");
        }
        public abstract void MakeSound();
    }
    public class Dog : Animal {
        public Dog(string name, int age) : base(name, age) {}
        public override void MakeSound() {
            Console.WriteLine("Woof");
        }
    }
    public class Cat : Animal {
        public Cat(string name, int age) : base(name, age) {}
        public override void MakeSound() {
            Console.WriteLine("Meow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog animal = new Dog("Burek", 5);
            animal.Eat();
            animal.MakeSound();
            Cat animal2 = new Cat("Mruczek", 3);
            animal2.Eat();
            animal2.MakeSound();
            var animals = new List<Animal>(){
                new Dog("Burek", 5),
                new Cat("Mruczek", 3)
            };
            foreach(var a in animals) {
                a.Eat();
                a.MakeSound();
            }
        }
    }
}