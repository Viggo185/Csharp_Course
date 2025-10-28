using System;


namespace Uppgift_8_Age_Verification_and_Control_Flow_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            string ageInput = Console.ReadLine();
            int age = Convert.ToInt32(ageInput);

            const int LegalAge = 18;
            
            if (age >= LegalAge)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are undre the leagal age ");
            }

            int counter = 1;

            while (counter <= 5)
            {
                Console.WriteLine("Counter" + counter);
                counter++;
            }
            switch (counter)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                default: Console.WriteLine("Invalid number");
                    break;

            }
            var name = "Jhon";

            Console.WriteLine($"\nWelcome, {name}!");
            Console.WriteLine("The loop has finished!");
            
        }
    }
}
