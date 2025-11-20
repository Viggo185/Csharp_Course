using System;


namespace Uppgift_6_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How meany times should x loop? ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0 )
            {
                Console.WriteLine("Enter number obove 0 ");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("x");
                }
            }
            Console.WriteLine("Loop done!");
        }
    }
}
