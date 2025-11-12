using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_14_Array_Multiplication_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 7;
            int length = 6; 

            int[]table = new int[length];

            for (int i = 0; i < length; i++)
            {
                table[i] = num * (i + 1);
            }
            Console.WriteLine($"Multiplication Table for {num}:");

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine($"{num} x {i + 1} = {table[i]}");
            }
        }
    }
}
