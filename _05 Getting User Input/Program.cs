using System;

namespace Getting_User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");

            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
        }
    }
}