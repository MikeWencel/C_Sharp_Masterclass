using System;

namespace TheSameResult
{
    class Program
    {
        static void Main(string[] args)
        {
        Result test = new Result(2+2,2+2);
        Console.WriteLine(test.theSame(2+2,2*2)); 
        Console.WriteLine(test.theSame(9/3,16-1));
        }
    }
}
