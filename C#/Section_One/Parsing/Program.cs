using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "15";
            string mySecString = "13";
            string result = myString + mySecString;
            int numOne = Int32.Parse(myString);
            int numTwo = Int32.Parse (mySecString);
            int resultInt = numOne + numTwo;
            Console.WriteLine(result);
            Console.WriteLine(resultInt);
        }
    }
}
