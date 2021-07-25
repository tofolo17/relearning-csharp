using System;

namespace Inheritance
{
    public class Chef
    {
        public void MakeChicken()
        {
            Console.WriteLine("hmmmm chicken.");
        }

        public void MakeSalad()
        {
            Console.WriteLine("hmmmm salad.");
        }

        public virtual void MakeSpecialDish()
        {
            Console.WriteLine("hmmmm rice and beans.");
        }
    }
}