using System;

namespace Static_Class_Attributes
{
    class Program
    {
        static void Main(string[] args)
        {
            Goals goal1 = new Goals("Palmeiras");
            Goals goal2 = new Goals("São Paulo");

            Console.WriteLine(goal2.getGoals());
        }
    }
}