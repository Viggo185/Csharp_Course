using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_23_TryParse_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            if (TryParse(Console.ReadLine(), out int result))
            {
                Console.WriteLine("succsec: " + result);
            }
            else
            {
                Console.WriteLine("Oh no something went wrong");
            }
        }
        static bool TryParse(string input, out int result)
        {
            result = 0;

            try
            {
                result = Convert.ToInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
