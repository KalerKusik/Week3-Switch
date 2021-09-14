using System;

namespace InstagramAgeValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter A Username:");
            string UserName = Console.ReadLine();

            Console.WriteLine("Please Enter A Password:");
            Console.ReadLine();

            Console.WriteLine("Please Enter Your Birthyear:");
            int BirthYear = Int32.Parse(Console.ReadLine());

            int Age = 2021 - BirthYear;

            if (Age < 13)
            {
                Console.WriteLine("You Are Too Young To Sign Up");
            }

            else
            {
                Console.WriteLine($"Welcome To Instagram {UserName}!");
            }
        }
    }
}
