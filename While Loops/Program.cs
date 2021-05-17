using System;

namespace While_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 1;
            while (index <= 5)
            {
                Console.WriteLine(index);
                index++;
            }

            index = 6;
            do // first it executes
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);
        }
    }
}