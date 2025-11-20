using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift_26_Exception_Handling__Try_Catch_
{
    public class Calculator
    {
        public double Divide(int a, int b)
        {
            try
            {
                return (double)a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0.0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
                return 0.0;
            }
        }

        public int ParseInput(string input)
        {
            try
            {
                return int.Parse(input);
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Input was not a valid number.");
                return -1;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unexpected error: " + ex.Message);
                return -1;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            try
            {
                Console.Write("Enter first number: ");
                int num1 = calc.ParseInput(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = calc.ParseInput(Console.ReadLine());

                double result = calc.Divide(num1, num2);

                Console.WriteLine($"Result: {result}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred during processing: " + ex.Message);
            }
        }
    }
}
