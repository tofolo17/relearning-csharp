using System;

namespace For_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ramage = {"Ramage", "Lendário", "Apenas"};
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }

            for (int i = 0; i < ramage.Length; i++)
            {
                Console.WriteLine(ramage[i]);
            }
        }
    }
}