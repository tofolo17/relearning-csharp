using System;

namespace Inheritance
{
    public class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("hmmmm pasta.");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("hmmmm lasagna.");
        }
    }
}