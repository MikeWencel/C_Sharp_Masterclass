using System;

namespace ConstantsC
{
    class Program
    {

        // constants as field
        // We cannot changed const variable

        const double PI = 3.14;
        const int weeks = 52, month = 12;
        const string birthday = "20.09.1987";

        static void Main(string[] args)
        {
            Console.WriteLine("My birthday is always going to be: {0}",birthday);
        }
    }
}
