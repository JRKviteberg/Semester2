using System;

namespace AgeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int age))
            {
                if (age >= 21)
                {
                    Console.WriteLine("You can buy alcohol in the US.");
                }
                else if (age >= 20)
                {
                    Console.WriteLine("You can buy liquor.");
                }
                else if (age >= 18)
                {
                    Console.WriteLine("You can buy beer.");
                }
                else if (age >= 14)
                {
                    Console.WriteLine("You can buy energy drinks.");
                }
                else
                {
                    Console.WriteLine("You are too young to buy alcohol, liquor, or energy drinks.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}