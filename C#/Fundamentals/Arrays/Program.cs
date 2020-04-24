using System;
using System.Linq;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
        
            string [] cars = {"Mercedes","BMW","Mazda","Ford","Audi"};

            int [] numbers = {1,2,3,4,5,6,7,8};
            // Reading an item from array
            Console.WriteLine(cars[1]);
            Console.WriteLine(cars.Length);
            Console.WriteLine("*************");
            Console.WriteLine("For Loop");
            Console.WriteLine("*************");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            Console.WriteLine("*************");
            Console.WriteLine("For Each");
            Console.WriteLine("*************");
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("*************");
            Console.WriteLine("Array sort");
            Console.WriteLine("*************");
            
            Array.Sort(cars);
            foreach (var item in cars)
            {
                Console.WriteLine(item);
            }
            
            Array.Reverse(cars);
            
            Console.WriteLine("*************");
            Console.WriteLine("Reverse Array");
            Console.WriteLine("*************");

            foreach (var item in cars){
                Console.WriteLine(item);
            }

            Console.WriteLine("*************");
            Console.WriteLine("Max,Min,Sum");
            Console.WriteLine("*************");
            Console.WriteLine("You must use 'System.Linq");

            Console.WriteLine(numbers.Max());
            Console.WriteLine(numbers.Min());
            Console.WriteLine(numbers.Sum());

            string[] animals = new string[4];

            foreach (var item in animals)
            {
                Console.WriteLine(animals.Length);
            }

            string[] dogs = new string[4]{"german shepard","Chichuahya","Shih-Tzu","Bulldog"};

            string[] colours = new string []{"red","blue","yellow","orange"};

            string[] people = {"Mark","James","Wacław","Mike"};




        }
    }
}
