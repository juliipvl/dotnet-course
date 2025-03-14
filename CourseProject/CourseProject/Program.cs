using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using Application.Abstractions;
using Application.Implementations;
using Core.Models;

namespace CourseProject
{
    internal class Program
    {
        //class Cat
        //{
        //    public string Name;
        //}
        static void Main(string[] args)
        {

            UserService userService = new UserService();
            User user = userService.GetUser((user) => user.UserId == 1);

            BookService bookService = new BookService();
            bookService.FilterBooks((book) => book.Author == "John Doe"); 

            /*
            // Value Type
            Console.WriteLine("VALUE TYPE");
            int firstVal = 5;
            int secondVal = firstVal;
            Console.WriteLine($"First value is: {firstVal}");
            Console.WriteLine($"Second value equals {secondVal} when we initialize it by first value");

            secondVal = 15;

            Console.WriteLine("\n---After changing the value in the second variable---");
            Console.WriteLine($"Second value will change: {secondVal}, but first is still {firstVal}");

            // Reference Type
            Console.WriteLine("\nREFERENCE TYPE");

            Cat cat1 = new Cat() { Name = "Sam" } ;
            Console.WriteLine($"Name of first cat: {cat1.Name}");

            Cat cat2 = cat1;
            Console.WriteLine($"Second cat will have address of first cat: {cat2.Name}");

            cat2.Name = "Jenny";

            Console.WriteLine("\n---After changing the value in the second cat---");
            Console.WriteLine($"Second cat will change name: {cat2.Name}");
            Console.WriteLine($"Both cats point to the same address, so the name of the first one will also change: {cat1.Name}");
            */

        }
    }
}
