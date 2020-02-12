using System;

namespace Intro_statements
{
    class Program
    {
        static void Main(string[] args)
        {
            string temperature = Console.ReadLine();
            int temp;
            int number;
            bool numberEntered = int.TryParse(temperature, out number);

            if(numberEntered){
                temp = number;
            }
            else
            {
                temp = 0;
                Console.WriteLine("Temperature is set to {0}, you should type a number!", temp);
            }

            if(temp <= 15){
                Console.WriteLine("You need to take coat!!");
            }else if (temp > 15 && temp <= 21){
                Console.WriteLine("You don't need coat!!");
            }else
            {
                Console.WriteLine("Take the sunglasses!");
            }
          
        }
    }
}
