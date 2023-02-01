using System;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine("Результат сложения: ");
            Console.WriteLine(int.Parse(a) + int.Parse(b));
            Console.WriteLine("Hello World");
        }
    }
}