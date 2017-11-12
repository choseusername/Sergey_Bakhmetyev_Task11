using System;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MathLibrary.Math.Pow(2.0, 5.0));
            Console.WriteLine(MathLibrary.Math.Factorial(5));
            Console.ReadKey();
        }
    }
}
