using System;

namespace DataTypes_Int_Float_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1;
            int numberTwo = 5;

            Console.WriteLine(numberOne);
            int result = numberOne + numberTwo;
            Console.WriteLine("This is result " + result);
            result = numberTwo * result;
            Console.WriteLine("This is sum of numberTwo * result" + result);
            result = result / numberTwo;
            Console.WriteLine("result / numberTwo:" + result);
            result = result - numberTwo;
            Console.WriteLine("result - numberTwo:" + result);

            double first = 3.5;
            double second = 1.337;

            double SecondResult = first + numberTwo;
            Console.WriteLine(first + " + " + numberTwo + " = " + SecondResult);

            SecondResult = first + second;
            Console.WriteLine(first + " + " + numberTwo + " = " + SecondResult);

        }
    }
}
