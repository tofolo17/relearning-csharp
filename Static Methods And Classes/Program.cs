using System;

namespace Static_Methods_And_Classes
{
    class Program
    {
        // This class cannot be instantiated. If we do just a static method, instantiation is still possible.
        static void Main(string[] args)
        {
            Console.WriteLine(Utilities.Sum(5, 7)); // Not instantiated
        }
    }
}