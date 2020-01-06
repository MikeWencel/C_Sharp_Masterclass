using System;

namespace DataTypes_Int_Float_Double
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 1;
            int numberTwo = 5;
            // We can create variables without assignment
            int num, num2, num3, num4, num5;
            double numDou = 3.5;
            
            // We need to add "F"
            float numFlou = 3.5F;

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

            SecondResult = numberTwo / first;
            Console.WriteLine(numberTwo  + " / " + first + " = " + SecondResult);

            // We need to use casting, when we want to work with other types of datatypes in one math.
            int thirdResult = numberTwo * first;
            Console.WriteLine(numberTwo  + " * " + first + " = " + thirdResult);



        }
    }
}
