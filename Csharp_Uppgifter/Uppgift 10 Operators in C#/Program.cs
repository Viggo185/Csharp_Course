using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_10_Operators_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 8;
            int num3 = 6;
            int num4 = 2;
            int num5 = 10;
            int num6 = 7;

            Console.WriteLine(num1 + num2);
            Console.WriteLine(num3 * num4);
            Console.WriteLine(num4 % num5);

            num6++;
            Console.WriteLine(num6);
            Console.WriteLine("Prefix increment: " + (++num6));
            Console.WriteLine("Postfix increment: " + (num6++));
            num6--;
            Console.WriteLine(num6);
            Console.WriteLine("Prefix increment: " + (--num6));
            Console.WriteLine("Postfix increment: " + (num6--));

            Console.WriteLine(num5 += 4);
            Console.WriteLine(num5 -= 4);
            Console.WriteLine(num5 *= 4);
            Console.WriteLine(num5 /= 4);
            Console.WriteLine(num5 %= 4);

        }
    }
}
