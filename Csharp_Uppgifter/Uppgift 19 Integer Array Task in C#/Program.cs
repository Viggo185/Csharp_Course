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
            

          Console.WriteLine($"Array length: {numbers.Length}");

        if (numbers.Length == 0)
        {
           Console.WriteLine("Cannot add up an empty array");
        }
        else
        {
           Console.WriteLine($"The total sum is: {sum}");
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
