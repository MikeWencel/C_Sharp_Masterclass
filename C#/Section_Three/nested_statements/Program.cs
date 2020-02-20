using System;

namespace nested_statements
{
    class Program
    {
        static void Main(string[] args)
        {   
            
        
            string userName;
            string password;

            Console.WriteLine("Welcome, if you want register, click '1'");
            string options = Console.ReadLine();
            if(options.Equals("1")){
                Console.WriteLine("Write your username");
                userName = Console.ReadLine();
                Console.WriteLine("Write you password");
                password = Console.ReadLine();

                    
                    Console.WriteLine("Write your username");
                    string loginCheck = Console.ReadLine();
                    Console.WriteLine("Write your password");
                    string passCheck = Console.ReadLine();
                    if(loginCheck.Equals(userName) && passCheck.Equals(password)){
                        Console.WriteLine("You're logged in");

                    }else {
                    
                    Console.WriteLine("Wrong username or password");
                    }
                    
            
                
            }else {
                Console.WriteLine("Goodbye! Anonymous");
            }
        }
            
          
        }
    }

