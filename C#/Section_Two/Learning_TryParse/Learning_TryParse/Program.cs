using System;

namespace Learning_TryParse
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = "123";
            int parsedValue;
            bool success = int.TryParse(number, out parsedValue);

            if(success)
            {
                Console.WriteLine("Parsing value successful = number is: " + parsedValue);
            }

            else
            {
                Console.WriteLine("Parsing fail");
            }

            Console.Read();
        }
    }
}
