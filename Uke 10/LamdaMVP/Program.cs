namespace LamdaMVP
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            // Eksempel 1: Enkel lambda som fungerer som en funksjon
            Func<int, int> square = x => x * x;
            Console.WriteLine($"Kvadratet av 5 er {square(5)}");

            // Eksempel 2: Bruk av lambda med List.ForEach
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            Console.Write("Original numbers: ");
            numbers.ForEach(x => Console.Write(x + " "));
            Console.WriteLine();

            // Eksempel 3: Filtrering med lambda
            var evenNumbers = numbers.Where(x => x % 2 == 0);
            Console.Write("Even numbers: ");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Eksempel 4: Sortering med lambda
            var sortedNumbers = numbers.OrderByDescending(x => x);
            Console.Write("Numbers in descending order: ");
            foreach (var num in sortedNumbers)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            // Eksempel 5: Lambda for å lage en anonym type
            var numberSquares = numbers.Select(x => new { Number = x, Square = x * x });
            foreach (var item in numberSquares)
            {
                Console.WriteLine($"Number: {item.Number}, Square: {item.Square}");
            }

            // Ekstra eksempel: Enkel Kalkulator
            Console.WriteLine("\nEnkel Kalkulator");
            Console.Write("Skriv inn første tall: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Skriv inn andre tall: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Velg operasjon (+, -, *, /): ");
            string operation = Console.ReadLine();

            Func<double, double, double> calculator = operation switch
            {
                "+" => (a, b) => a + b,
                "-" => (a, b) => a - b,
                "*" => (a, b) => a * b,
                "/" => (a, b) => b == 0 ? double.NaN : a / b, // Returnerer NaN hvis forsøk på divisjon med 0
                _ => (_, _) => double.NaN // Ugyldig operasjon gir NaN
            };

            double result = calculator(num1, num2);
            if (double.IsNaN(result))
            {
                Console.WriteLine("Ugyldig operasjon eller feil input.");
            }
            else
            {
                Console.WriteLine($"Resultat: {result}");
            }
        }
    }
}