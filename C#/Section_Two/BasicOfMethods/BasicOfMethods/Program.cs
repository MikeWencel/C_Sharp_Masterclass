using System;

namespace BasicOfMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
        
            Console.WriteLine();

            WriteSomethingPara("Mike");
            int result = Add(245, 654);
            Console.WriteLine(result);

            int bigRes = Add(Add(245, 768), Add(435, 434));


            double res = Multiply(4, 15.4, 20.4);

            Console.WriteLine(bigRes);

            Console.WriteLine("Multiply result is {0}", res);
            Console.Read();

        }

        public static void WriteSomething()
        {
            string word = Console.ReadLine();
        }

        public static void WriteSomethingPara(string text)
        {
            Console.WriteLine(text);
        }

        public static int Add(int numberOne, int numberTwo) 
        {
            return numberOne + numberTwo;
        }

        public static double Multiply(double numberOne, double numberTwo, double numberThree)
        {
            return numberOne * numberTwo * numberThree;
        }


















    }
}
