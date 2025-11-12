using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_20_Area_of_Circle_Calculation_Task_C_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(1.5);

            double area = circle.CalculateArea();
            Console.WriteLine($"Area of the new circle is: {area}");
        }
    }
    class Circle
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
