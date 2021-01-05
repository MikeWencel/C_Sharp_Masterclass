using System;

namespace userInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculate());
            Console.Read();

        }

        public static double Calculate()
        {
            Console.WriteLine("Please write your first number!");
            string first = Console.ReadLine();
            double numOne = Double.Parse(first);
            Console.WriteLine("Please write your second number!");
            string second = Console.ReadLine();
            double numTwo = Double.Parse(second);

            return numOne + numTwo;
        }
        
    }
}
