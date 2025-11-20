using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_16_Sort_Reverse_Remove_and_find
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[]
            {
                45, 12, 78, 34, 89, 23
            };

            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            Array.Sort(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

           
            Array.Reverse(numbers);
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            
            int numToRemove = 78;
            numbers = numbers.Where(val => val != numToRemove).ToArray();

            
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            int index = Array.IndexOf(numbers,34);
            if (index != -1)
            {
                Console.WriteLine($"The index of 34 is {index}");
            }
            else
            {
                Console.WriteLine("The index of 34 dosent exist");
            }




        }
    }
}
