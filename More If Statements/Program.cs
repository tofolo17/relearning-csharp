using System;

namespace More_If_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMax2(13, 14));
            Console.WriteLine(GetMax3(33, 35, 21));
        }

        static int GetMax2(int number1, int number2)
        {
            int result = number1;
            bool higher = number1 > number2;

            if (!higher)
            {
                result = number2;
            }

            return result;
        }

        static int GetMax3(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}