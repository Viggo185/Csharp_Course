using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_13__Odd_or_Even_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pleas enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine($"{num1} is even");
            }
            else
            {
                Console.WriteLine($"{num1} is odd");
            }
        }
    }
}
