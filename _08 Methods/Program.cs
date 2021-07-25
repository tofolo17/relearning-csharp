using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // SayHi()
            SayHi("Guga");
            SayHi("Teteus");

            string name = "Pepe";
            SayHi(name);

            // ReturnName()
            name = ReturnName(name);
            SayHi(name);
        }

        static void SayHi(string name)
        {
            Console.WriteLine("Hello " + name + "!");
        }

        static string ReturnName(string name)
        {
            string newName = name.ToUpper() + " Bimbão";
            return newName;
        }
    }
}