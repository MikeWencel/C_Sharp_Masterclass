using System;

namespace ArrayTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5 };
            
            string[] fruits = { "Orange", "Banana", "Lemon" };

            Console.WriteLine(fruits[0]);
            
            //Wypisywanie przy pomocy pętli for

            for(int i = 0;i < fruits.Length-1;i++)
            {
                Console.WriteLine(fruits[i]);
            }
            // Wypisywanie przy pomocy pętli foreach
            foreach(string element in fruits) 
            {
                Console.WriteLine(element);
            }

            int[,] twoDimmenstional = new int[3, 4]
            {
                {0,1,2,3 },
                {5,5,5,4 },
                {8,9,2,1 }
            };


            Console.WriteLine(twoDimmenstional[0,2]);

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4;j++)
                {
                    Console.Write(twoDimmenstional[i, j]);
                    Console.Write(" ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine(twoDimmenstional.GetLength(1));




            Console.Read();
        }
    }
}
