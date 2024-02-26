using System;



namespace GreetingApp

{

    class GreetingProgram

    {

        static void Main(string[] args)

        {



            Console.Write("Enter your name: ");

            string name = Console.ReadLine();



            Console.Write("Enter the total number of your enrolled courses: ");

            int enrolledCourses = int.Parse(Console.ReadLine());



            Console.Write("Enter the price of your favorite book: ");

            double favoriteBookPrice = double.Parse(Console.ReadLine());



            Console.WriteLine($"Name: {name}");

            Console.WriteLine($"Total enrolled courses: {enrolledCourses}");

            Console.WriteLine($"Price of my favorite book: {favoriteBookPrice}");



            Console.WriteLine("\nPress any key to exit...");

            Console.ReadKey();

        }

    }

}
