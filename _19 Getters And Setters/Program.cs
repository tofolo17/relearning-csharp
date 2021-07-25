using System;

namespace Getters_And_Setters
{
    class Program
    {
        static void Main(string[] args)
        {
            // Good or bad
            Movie movie = new Movie("Sen to Chihiro no Kamikakushi", "Hayao Miyazaki", "Good");
            movie.Rating = "Dog";

            Console.WriteLine(movie.Rating);
        }
    }
}