using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("O Mundo de Sofia", "Jostein Gaarder", 491);
            Console.WriteLine(book1.Title);

            Book book2 = new Book("Homo Ludens", "Johan Huizinga", 307);
            Console.WriteLine(book2.Title);

            Book book3 = new Book();
        }
    }
}