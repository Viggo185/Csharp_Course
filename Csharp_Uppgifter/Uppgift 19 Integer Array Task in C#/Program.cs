using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_19_Integer_Array_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 0, 1, 2, 3, 4, 5 };
            int sum = SumOfAllNumbers(numbers);
            

            if (sum > -1)
            {
                Console.WriteLine($"The toltal sum is: {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }

            if (sum > 0)
            {
                Console.WriteLine($"The total sum is: {sum}");
            }
            else
            {
                Console.WriteLine("Cannot add up an empty array");
            }
        }

        static int SumOfAllNumbers(int[] numbres)
        {
            int sum = 0;
            for (int i = 0; i < numbres.Length; i++)
            {
                sum += numbres[i];
            }
            return sum;
        }
    }
}
