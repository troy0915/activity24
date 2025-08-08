using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Hardcoded username and password
            string correctUsername = "admin";
            string correctPassword = "1234";

            string username;
            string password;

            // Loop until both username and password match
            while (true)
            {
                // Prompt user for username
                Console.Write("Enter username: ");
                username = Console.ReadLine();

                // Prompt user for password
                Console.Write("Enter password: ");
                password = Console.ReadLine();

                // Check if both username and password are correct

                if (username == correctUsername && password == correctPassword)
                {
                    Console.WriteLine("Login successful");
                    break; // Exit the loop
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
    }
}







