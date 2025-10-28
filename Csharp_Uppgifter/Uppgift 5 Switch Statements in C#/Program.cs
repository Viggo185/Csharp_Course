using System;


namespace Uppgift_5_Switch_Statements_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade dit you get? ");
            int grade = Convert.ToInt32(Console.ReadLine());

            switch (grade)
            {
                case 0:
                    Console.WriteLine("Fail");
                    break;
                case 1:
                    Console.WriteLine("Needs Improvment");
                    break;
                case 2:
                    Console.WriteLine("Ok");
                    break;
                case 3:
                    Console.WriteLine("Satisfactory");
                    break;
                case 4:
                    Console.WriteLine("Good");
                    break;
                case 5:
                    Console.WriteLine("Excellent");
                    break;
            }
            Console.ReadLine();
        }
    }
}
