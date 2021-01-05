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
    }
}
