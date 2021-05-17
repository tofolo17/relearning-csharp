using System;

namespace If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isMale = false;
            bool isTall = false;

            if (isMale && !isTall)
            {
                Console.WriteLine("Male and not tall!");
            }
            else if (!isMale && isTall)
            {
                Console.WriteLine("Female and tall!");
            }
            else
            {
                Console.WriteLine("Crazy!");
            }
        }
    }
}