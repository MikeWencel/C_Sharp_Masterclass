using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Mike";
            string lastName = "Wencel";

            Console.WriteLine(name + " " + lastName);

            string capsMessage = lastName.ToUpper();

            Console.WriteLine(name + " " + capsMessage);

            string lowerCase = name.ToLower();

            Console.WriteLine(lowerCase + " " + capsMessage);
        }
    }
}
