using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit conversion! Is cutting everything after DOT
            double myDouble = 13.37;
            int myInt;
            myInt = (int)myDouble;
            Console.WriteLine(myInt);


            //Impcit conversion!
            int num = 123494;
            long bigNum = num;
            float myFloat = 13.37F;
            double myNewDouble = myFloat;


            //Type Conversion
            String number;
            number = myDouble.ToString();

            Console.WriteLine(number);

            Console.WriteLine(number + myDouble);

            String secondNumber = bigNum.ToString();

            Console.WriteLine(secondNumber);

            Console.Read();

        }
    }
}
