using System;

namespace SPIN_PL
{
    class Program
    {
        static void Main(string[] args)
        {
            String word = Console.ReadLine();
            int num = Int32.Parse(word);
            int count = 0;

            while(count < num){
                String tempWord = Console.ReadLine();
                String [] tempTable = tempWord.Split(",");
                // Console.WriteLine(tempTable[1]);

                String [] tempNumberOne = tempTable[0].Split("=");
                String [] tempNumberTwo = tempTable[1].Split("=");

                int n = Int32.Parse(tempNumberOne[1]);
                int m = Int32.Parse(tempNumberTwo[1]);
                

                count++;
            }
        }
    }
}
