using System;
using System.Data;


namespace Uppgift_4_If_statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = int.Parse(ageInput);

            if (age >= 18)
            {
                Console.WriteLine("Allowed to vote");
            }
            else if (age <= 18)
            {
                Console.WriteLine("Not allowed to vote");
            }
        }
    }
}
