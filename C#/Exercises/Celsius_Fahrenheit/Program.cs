using System;

namespace Celsius_Fahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write program that will convert Celsius to FahrenHeit

            Converter temp = new Converter(25,15);
            Console.WriteLine(temp.celsius_fahren(0));
            Console.WriteLine(temp.celsius_fahren(100));
            Console.WriteLine(temp.celsius_fahren(-300));
            
        }
    }
}
