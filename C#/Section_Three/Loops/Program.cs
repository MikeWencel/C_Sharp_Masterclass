using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {   String hole = " ";
            for (int i = 0; i < 5; i++)
            
            {
                System.Console.WriteLine("*");
                for(int j = 0; j < 5;j++){
                    if(i == 0){
                        System.Console.WriteLine("*");
                    }else if((i == 1 || i == 5) & j == 1){

                        System.Console.WriteLine("*");
                    }
                    
                }
            }
        }
    }
}
