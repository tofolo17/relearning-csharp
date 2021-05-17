using System;

namespace Classes_And_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.Title = "O Mundo de Sofia";
            book1.Author = "Jostein Gaarder";
            book1.Pages = 491;

            Console.WriteLine(book1.Title);

            Book book2 = new Book();
            book2.Title = "Homo Ludens";
            book2.Author = "Johan Huizinga";
            book2.Pages = 307;

            Console.WriteLine(book2.Title);
        }
    }
}