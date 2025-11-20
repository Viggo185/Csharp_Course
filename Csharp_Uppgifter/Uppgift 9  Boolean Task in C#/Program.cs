using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_9__Boolean_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.
            int num1 = 5;
            int num2 = 6;
            int num3 = 7;
            int num4 = 8;
            //2.
            bool isTrue = true;
            
            //3.
            bool resultAnd = isTrue && (num1 > num3 && num2 > num4);
            bool resultOr = isTrue || (num1 == num3 && num2 == num4);
            bool resultNot = !isTrue;

            Console.WriteLine(resultAnd);
            Console.WriteLine(resultOr);
            Console.WriteLine(resultNot);
            //4.
            Console.WriteLine($"num1 > num3: {num1 > num2}"); 
            Console.WriteLine($"num2 < num4: {num2 < num4}"); 
            Console.WriteLine($"num1 == num4: {num1 == num4}"); 
            Console.WriteLine($"num2 != num3: {num2 != num3}");

            //5.
            bool expression1 = (num1 > num3) && (num2 < num4);
            bool expression2 = (num1 < num3) || (num2 > num4);
            //6.
            Console.WriteLine($"expression 1: {expression1}");
            Console.WriteLine($"expression 2: {expression2}");

        }
    }
}
