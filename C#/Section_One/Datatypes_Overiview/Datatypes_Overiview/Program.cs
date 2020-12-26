using System;

namespace Datatypes_Overiview
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte a = 120;
            short b = 30000;
            int c = 200000000;
            long d = 20000000000000;
            //It's important to add f as last letter! It will read as double!
            float e = 99.99f;
            double f = 1.5;
            decimal g = 2.3232312321M;
            bool h = true;
            char singleLetter = 'A';
            string username = "Jason";
            //Smaller date, that you wnato to store - use smaller datatypes

            int first_num = 2;
            int second_num = 4;
            first_num++;

            int sum;
            sum = first_num + second_num;

            double third_num = 2.5;
            double fourth_num = 1.6;

            double second_sum = third_num / fourth_num;

            Console.WriteLine(second_num);

            sum = second_num / first_num;

      



            Console.WriteLine(sum);
            Console.Read();


            
            


        }
    }
}
