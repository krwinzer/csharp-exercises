using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double radius;
            double pi;
            string input;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            radius = double.Parse(input);
            pi = 3.14;

            while (radius < 0)
            {
                Console.WriteLine("Please do not use a negative number. Enter a new radius:");
                input = Console.ReadLine();
                radius = double.Parse(input);
            }

            area = pi * radius * radius;
            Console.WriteLine("The area of a circle where radius is " + radius + " is " + area);
            Console.ReadLine();
        }
    }
}
