using System;

namespace User_input
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(Calculator());
        }

        public static double Calculator(){
            Console.WriteLine("Please enter the number:");
            string firstInput = Console.ReadLine();
            Console.WriteLine("Please enter second number");
            String secondInput = Console.ReadLine();
            int first = Int32.Parse(firstInput);
            int second = Int32.Parse(secondInput);
            Console.WriteLine("What do you want to do ? Please type number");
            Console.WriteLine("add, odd, multiply, divided");
            string answer = Console.ReadLine();

            switch(answer){
                case "add":
                return first + second;
                case "odd":
                return first - second;
                case "multiply":
                return first * second;
                case "divided":
                return first / second;
                default:
                return -1;
            }
        
        }
    }
}
