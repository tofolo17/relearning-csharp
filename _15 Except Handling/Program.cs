using System;

namespace Except_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            try
            {
                Console.Write(1 / num);
            }
            catch (DivideByZeroException e)
            {
                Console.Write("Opa!");
            }
            catch (Exception e)
            {
                Console.Write("Outro erro!");
            }
            finally // executed no matter what
            {
                Console.Write("É!");
            }
        }
    }
}