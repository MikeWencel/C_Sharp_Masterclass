using System;

namespace Console_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print in the same line
            Console.Write("Print in the same line");
            //Print in the next line, cursos in the next line
            Console.WriteLine("Prints and puts cursor in the next line!");
            //Return ASCII value, it's take single input
            Console.Write("Enter a string and press ENTER: ");
            string input = Console.ReadLine();
            Console.WriteLine("You have entered {0}", input);

            Console.Write("Enter ASCII value: ");
            int asciiValue = Console.Read();
            Console.WriteLine("Ascii value is {0}", asciiValue);
            Console.ReadKey();
            

        }
    }
}
