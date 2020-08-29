using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Divider : ICalculator
    {
        public int OperationOrder => 4;
        public string OperationName => "Divide";
        public int Calculate(int x, int y)
        {
            try
            {
                return x / y;
            } catch (DivideByZeroException) {
                Console.WriteLine("Divide by zero is inappropriate operation!");
                return -1;
            }
        }

        public double Calculate(double x, double y)
        {
            try
            {
                return x / y;
            } catch(DivideByZeroException)
            {
                Console.WriteLine("Divide by zero is inappropriate operation!");
                return -1;
            }
        }
    }
}
