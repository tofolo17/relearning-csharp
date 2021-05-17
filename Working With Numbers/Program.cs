using System;

namespace Working_With_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(5 + 2);
            Console.WriteLine(5 - 2);
            Console.WriteLine(5 * 2);
            Console.WriteLine(5 / 2.0); // Operations between integers always have a integer as an anwser
            Console.WriteLine(5 % 2);
            Console.WriteLine((4 + 3) * 2);

            int num = 6;
            num--;

            Console.WriteLine(num);

            Console.WriteLine(Math.Pow(num, 2));
            Console.WriteLine(Math.Round(6 + 0.7));
        }
    }
}