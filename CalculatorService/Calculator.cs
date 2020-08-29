using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Calculator : ICalculator
    {
        public int Add(int x, int y) => x + y;
        public double Add(double x, double y) => x + y;

        public int Divide(int x, int y) 
        {
            try
            {
                return x / y;
            } catch(DivideByZeroException)
            {
                Console.WriteLine("Dividing by zero is inappropriate operation!");
                return -1;
            }
        }

        public double Divide(double x, double y) 
        {
            try
            {
                return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Dividing by zero is inappropriate operation!");
                return -1;
            }
        }

        public int Multiply(int x, int y) => x * y;
        public double Multiply(double x, double y) => x * y;
        public int Subtract(int x, int y) => x - y;
        public double Subtract(double x, double y) => x - y;
    }
}
