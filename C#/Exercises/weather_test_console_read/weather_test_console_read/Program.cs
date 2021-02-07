using System;

namespace weather_test_console_read
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's temperature is outside?");
            string input = Console.ReadLine();
            int temp = 0;
            temp = Int32.Parse(input);

            if (temp < 10) 
            {
                Console.WriteLine("Take your coat!!");
            }
            else if(temp >= 10 && temp < 15 )
            {
                Console.WriteLine("You don't need coat! Take your sweet!");
            }
            else 
            {
                Console.WriteLine("It's summer, go to the beach");
            }

            Console.Read();


        }
    }
}
