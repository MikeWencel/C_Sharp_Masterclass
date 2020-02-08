using System;

namespace return_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,5));
            Console.WriteLine(Multiply(2,5));
            Console.WriteLine(divided(25,13));
        }

        public static int Add(int first, int second){

            return first + second;
        }

        public static int Multiply(int first, int second){
            return first * second;
        }

        public static double divided(double first, double second){
            return first/second;
        }
    }
}
