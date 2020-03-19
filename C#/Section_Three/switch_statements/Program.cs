using System;

namespace switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("How old are you?");
            string ageStr = Console.ReadLine();

            int age = Int32.Parse(ageStr);

            switch (age)
            {
                case 15:
                Console.WriteLine("You're too young!");
                break;
                case 25:
                Console.WriteLine("Your good to go!");
                break;
                default:
                Console.WriteLine("so how old are you?");
                break;
            }
        }
    }
}
