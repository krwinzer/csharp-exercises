using System;

namespace AliceWonderland
{
    class Program
    {
        static void Main(string[] args)
        {
            string alice = "Alice was beginning to get very tired of sitting by her sister on the bank, " +
                "and of having nothing to do: once or twice she had peeped into the book her sister was reading, " +
                "but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice " +
                "'without pictures or conversation?'";

            string input;
            string alice2;
            string input2;

            Console.WriteLine("Search: ");
            input = Console.ReadLine();
            alice2 = alice.ToLower();
            input2 = input.ToLower();
            bool b = alice2.Contains(input2);

            if (b)
            {
                Console.WriteLine("Term was found.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Term was not found.");
                Console.ReadLine();
            }
        }
    }
}