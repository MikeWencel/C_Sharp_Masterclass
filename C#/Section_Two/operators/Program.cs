using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 7;
            int num = 3;

            num = -first;

            Console.WriteLine("num is {0}",num);

            bool isSunnny = true;

            Console.WriteLine("Is it sunny? {0}", !isSunnny);

            int number = 0;
            
            Console.WriteLine("Number is {0}", number);
            Console.WriteLine("Number is {0}", number++);
            Console.WriteLine("Number is {0}", ++number);


            Console.WriteLine("Number is {0}", number);
            Console.WriteLine("Number is {0}", --number);


            int result = first + second;
            Console.WriteLine("Result of {0} + {1} is {2}",first,second,result);
            result = first - second;
            Console.WriteLine("Result of {0} - {1} is {2}",first,second,result);
            result = first * second;
            Console.WriteLine("Result of {0} * {1} is {2}",first,second,result);
            result = first / second;
            Console.WriteLine("Result of {0} / {1} is {2}",first,second,result);
            result = first % second;
            Console.WriteLine("Result of {0} % {1} is {2}",first,second,result);

            bool isLower;
            isLower = first < second;
            Console.WriteLine("Result of {0} < {1} is {2}",first,second,isLower);
            bool isHigher;
            isHigher = first > second;
            Console.WriteLine("Result of {0} > {1} is {2}",first,second,isHigher);

            bool isEqual;
            isEqual = first == second;
            Console.WriteLine("Result of {0} == {1} is {2}",first,second,isEqual);

            
            isEqual = first != second;
            Console.WriteLine("Result of {0} != {1} is {2}",first,second,isEqual);

            

        }
    }
}
