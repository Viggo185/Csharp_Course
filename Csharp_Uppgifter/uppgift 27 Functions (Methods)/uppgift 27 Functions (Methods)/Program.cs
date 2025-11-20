using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uppgift_27_Functions__Methods_
{
    public class MathOperations
    {
        public int Addition(int a, int b)
        {
            return a + b; 
        }

        public int Subtraction(int a, int b)
        {
            return a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b; 
        }

        public double Division(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return 0.0;
            }

            return (double)a / b;
        }

        public double Power(double baseValue, double exponent)
        {
            return Math.Pow(baseValue, exponent);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MathOperations math = new MathOperations();

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Results ---");
            Console.WriteLine($"Addition: {math.Addition(num1, num2)}");
            Console.WriteLine($"Subtraction: {math.Subtraction(num1, num2)}");
            Console.WriteLine($"Multiplication: {math.Multiplication(num1, num2)}");
            Console.WriteLine($"Division: {math.Division(num1, num2)}");
            Console.WriteLine($"Power ({num1}^{num2}): {math.Power(num1, num2)}");
        }
    }
}
