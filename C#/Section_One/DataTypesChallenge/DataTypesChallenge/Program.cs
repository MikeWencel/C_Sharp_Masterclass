using System;

namespace DataTypesChallenge
{
    class Program
    {
        static void Main(string[] args)
        {   
            string name = "Mike";
            int num = 23243;
            double numero = 2.4;
            float number = 2.4F;
            long numeros = 2321312421432L;

            string controller = "I control text";
            string numberString = "233443";

            int newNum = Int32.Parse(numberString);


            Console.WriteLine(newNum);
            Console.WriteLine(newNum.GetType());


            const double PI = 3.14;
            const string birtdate = "20.09.1987";

            Console.Read();
        }
    }
}
