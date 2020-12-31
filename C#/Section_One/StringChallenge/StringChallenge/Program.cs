using System;

namespace StringChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            String input;
            Console.WriteLine("Enter your name");
            input = Console.ReadLine();

            Console.WriteLine(input.ToUpper());
            Console.WriteLine(input.ToLower());
            Console.WriteLine(input.Trim());
            Console.WriteLine(input.Substring(0,3));

            Console.Read();


        }
    }
}
