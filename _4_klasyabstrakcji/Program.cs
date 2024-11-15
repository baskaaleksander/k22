using System;

namespace MyApplication
{
    class Program
    {
        abstract class Shape
        {
            public abstract float CalculateArea();
            public abstract float CalculatePerimeter();
            public void DisplayInfo(){
                Console.WriteLine("Area: " + CalculateArea());
                Console.WriteLine("Perimeter: " + CalculatePerimeter());
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
