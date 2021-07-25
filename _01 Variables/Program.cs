using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Gustavo";
            int age;
            age = 19;

            Console.WriteLine(name + " is " + age + " years old.");

            age = 24;

            Console.WriteLine(name + " is not " + age + " years old");
        }
    }
}