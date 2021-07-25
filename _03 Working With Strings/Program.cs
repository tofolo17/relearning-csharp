using System;

namespace Working_With_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello + "\n\"World\"!");

            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.Contains("llo"));
            Console.WriteLine(hello.Substring(0, 2));
        }
    }
}