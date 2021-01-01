using System;

namespace StringChallengeTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String here:");
            string input = Console.ReadLine();
            Console.WriteLine("Enter index to search: ");
            string indexInput = Console.ReadLine();
            Console.WriteLine(input.IndexOf(indexInput));

            Console.WriteLine("Enter first name");
            string firstName = Console.ReadLine();
            firstName.Trim();
            Console.WriteLine("Enter last name");
            string lastName = Console.ReadLine();
            lastName.Trim();

            Console.WriteLine("{0} {1}", firstName, lastName);

        }
    }
}
