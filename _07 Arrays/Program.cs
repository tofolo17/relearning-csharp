using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luckyNumbers = {7, 13, 21};
            string[] friends = new string[5];
            friends[0] = "Guga?";

            luckyNumbers[2] = 92;

            Console.WriteLine(friends[0]);
            Console.WriteLine(luckyNumbers[2]);
        }
    }
}