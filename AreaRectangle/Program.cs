using System;

namespace AreaRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int length;
            int width;
            int area;
            string input;

            Console.WriteLine("Length: ");
            input = Console.ReadLine();
            length = int.Parse(input);

            Console.WriteLine("Width: ");
            input = Console.ReadLine();
            width = int.Parse(input);

            area = length * width;
            Console.WriteLine("The area of the rectangle is " + area);
            Console.ReadLine();


        }
    }
}