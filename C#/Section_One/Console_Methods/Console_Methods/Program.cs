using System;

namespace Console_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a string and press ENTER: ");
            string input = Console.ReadLine();
            Console.WriteLine("You have entered {0}", input);

            Console.Write("Enter letter: ");
            int valueAscii = Console.Read();
            Console.WriteLine("Ascii value is {0}", valueAscii);


            Console.ReadLine();


        }
    }
}
