﻿using System;

namespace return_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(2,5));
        }

        public static int Add(int first, int second){

            return first + second;
        }
    }
}
