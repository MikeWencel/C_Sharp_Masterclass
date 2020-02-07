using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingSpecific("Masło z pieca spadło");
        }

        public static void WriteSomething(){
            Console.WriteLine("I called from method");
        }

        public static void WriteSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            
        }
    }
}
