using System;


namespace Uppgift_7_While_Loops_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Counter = 1;

            while (Counter <= 5)
            {
                Console.WriteLine(Counter);
                Counter++;
            }
            Console.WriteLine("Loop has finished");
        }
    }
}
