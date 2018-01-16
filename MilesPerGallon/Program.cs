using System;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            double miles;
            double gallons;
            double mpg;
            string input;

            Console.WriteLine("Miles: ");
            input = Console.ReadLine();
            miles = double.Parse(input);

            Console.WriteLine("Gallons: ");
            input = Console.ReadLine();
            gallons = double.Parse(input);

            mpg = miles / gallons;
            Console.WriteLine("Miles Per Gallon: " + mpg);
            Console.ReadLine();
        }
    }
}
