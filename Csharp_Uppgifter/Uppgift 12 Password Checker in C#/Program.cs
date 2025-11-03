using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_12_Password_Checker_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a password:");
            string password1 = Console.ReadLine();

            Console.WriteLine("Re-enter your password:");
            string password2 = Console.ReadLine();

            if (string.IsNullOrEmpty(password1) || string.IsNullOrEmpty(password2))
            {
                Console.WriteLine("Pleas enter a password");
            }
            else if (password1.Length <6)
            {
                Console.WriteLine("Passwor must be 6 characters long");
            }
            else if (password1 == password2)
            {
                Console.WriteLine("Password match");
            }
            else
            {
                Console.WriteLine("Passwordss do not match");
            }
                
        }
    }
}
