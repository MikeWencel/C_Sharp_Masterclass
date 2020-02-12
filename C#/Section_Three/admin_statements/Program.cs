using System;

namespace admin_statements
{
    class Program
    {
        static void Main(string[] args)
        {   

            bool isAdmin = false;
            bool isRegistered = true;
            
            Console.WriteLine("Please enter username");
            string username = Console.ReadLine();

            if(isRegistered && username != "" && username.Equals("Admin")){
                Console.WriteLine("Hi there, registered user");

            }

            if(isAdmin || isRegistered){
                Console.WriteLine("You're logged in");
            }

            
        }
    }
}
