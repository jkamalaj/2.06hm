using System;

namespace homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
           
          
            Console.WriteLine("Username daxil edin:");
            Console.ReadLine();

            Console.WriteLine("Password daxil edin:");
            Console.ReadLine();

            Console.WriteLine(user1.UserName);
            Console.WriteLine(user1.Password);
        }
        
    }
}