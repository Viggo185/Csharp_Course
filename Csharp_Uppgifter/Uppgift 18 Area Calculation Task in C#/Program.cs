using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_18_Area_Calculation_Task_in_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter width of the triangle: ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the height of the triangle: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = CalculateArea(width, height);
            Console.WriteLine($"The area of the triangle is {area}");
        }

        static double CalculateArea(double witdth, double height)
        {
            return (witdth + height) / 2;
        }
    }
}
