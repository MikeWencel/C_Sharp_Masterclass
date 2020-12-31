using System;

namespace String_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = " Mike";
            string lastName = "Wencel";

            string subbed = name.Substring(2,2);

            Console.WriteLine(subbed);

            string low = name.ToLower();

            string high = name.ToUpper();

            string all = name + " " + lastName;

            string trimmed = all.Trim();

            string fullName = string.Concat(" ", name, lastName, " ");



            Console.WriteLine(low);
            Console.WriteLine(high);

            Console.WriteLine(fullName.Trim());
            Console.WriteLine(fullName.IndexOf('M'));

            Console.WriteLine("My name is {0} {1}", name.Trim(), lastName);
            Console.Read();
        }
    }
}
