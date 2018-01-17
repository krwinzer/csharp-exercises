using System;

namespace AreaCircle
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a radius: ");
                string input = Console.ReadLine();
                double radius = double.Parse(input);

                while (radius < 0)
                {
                    Console.WriteLine("Please do not use a negative number. Enter a new radius:");
                    input = Console.ReadLine();
                    radius = double.Parse(input);
                }

                double area = Math.PI * radius * radius;
                Console.WriteLine(string.Format("The area of a circle where radius is {0} is {1:.00}", radius, area));
                Console.ReadLine();
            }
        }
    }
}
