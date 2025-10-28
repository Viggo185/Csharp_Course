using System;


namespace Uppgift_3_Input_and_Output_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
