using System;
using System.Linq;


namespace word_reversing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(Solution("Kasiulka"));
            Console.WriteLine(Alternative("Kasiulka"));
            
            
        }

        static string Solution(string word){
        char[] charArr = word.ToCharArray(0,word.Length);      
        Array.Reverse(charArr);
        string newStr = new string(charArr);
        return newStr;

        }

        //Alternative
        static string Alternative(string str){
            return new string(str.ToArray().Reverse().ToArray());
    
        }

    }
}

       
    

