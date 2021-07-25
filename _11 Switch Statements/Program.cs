using System;

namespace Switch_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(29));
        }

        static string GetDay(int dayNum)
        {
            string dayName;
            switch (dayNum)
            {
                case 0:
                    dayName = "Monday";
                    break;
                case 1:
                    dayName = "Tuesday";
                    break;
                case 2:
                    dayName = "Wednesday";
                    break;
                case 3:
                    dayName = "Thursday";
                    break;
                case 4:
                    dayName = "Friday";
                    break;
                default:
                    dayName = "Invalid";
                    break;
            }

            return dayName;
        }
    }
}