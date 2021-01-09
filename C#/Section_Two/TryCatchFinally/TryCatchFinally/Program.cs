using System;

namespace TryCatchFinally
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            Console.WriteLine("Please enter second a number");
            string secondUserInput = Console.ReadLine();

            try
            {
                int userInputasInt = int.Parse(userInput);
                int secondInputasInt = int.Parse(secondUserInput);

                int result = userInputasInt / secondInputasInt;
            }

            //Exception is generic error
            catch(FormatException)
            {
                //When you delete and add 'throw', you'll got a type of error
                //throw;
                Console.WriteLine("Format exception, please enter the correct type!");
            }
            catch(OverflowException)
            {
                Console.WriteLine("Overflow Exception - number was to long for int32");
            }
            catch(ArgumentNullException)
            {
                Console.WriteLine("Argument Null Exception");
            }

            catch(DivideByZeroException)
            {
                Console.WriteLine("You can't divide by zero!");
            }

            finally
            {
                Console.WriteLine("This is called anyways");
            }

            Console.Read();
        }
    }
}
