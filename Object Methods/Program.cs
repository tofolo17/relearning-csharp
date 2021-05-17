using System;

namespace Object_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Gustavo", 8.5);

            Console.WriteLine(student.GreatStudent());
        }
    }
}