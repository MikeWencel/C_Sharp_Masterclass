using System;

namespace Parsing
{
    class Program
    {
        static void Main(string[] args)
        {

            String numString = "15";
            String numSecondString = "30";
            String numThreeString = "35a";

            String resultString = numString + numSecondString;
            Console.WriteLine(resultString);

            int firstNum = Int32.Parse(numString);
            int secondNum = Int32.Parse(numSecondString);
            

            int result = firstNum + secondNum;

            Console.WriteLine(result);
        }
    }
}
