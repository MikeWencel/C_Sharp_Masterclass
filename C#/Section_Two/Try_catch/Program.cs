using System;

namespace Try_catch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            string userInput = Console.ReadLine();
            try {
                int userInputNumber = int.Parse(userInput);
            }
            catch (FormatException){
                Console.WriteLine("Format exception, please enter the correct type next time.");
            }
            catch(OverflowException){
                Console.WriteLine("The number was too long or too short for an Int32");
            }
            finally
            {
                Console.WriteLine("It works anyway");
            }
            

        }
    }
}
