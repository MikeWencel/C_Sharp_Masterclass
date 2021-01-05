using System;

namespace EasyChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "Krzysztof";
            string two = "Alex";
            string three = "Radek";

            GreetFriend(one);
            GreetFriend(two);
            GreetFriend(three);

            Console.Read();
        }

        public static void GreetFriend(string name) 
        {
            Console.WriteLine("{0}! Hello my friend", name);
        }
    }
}
