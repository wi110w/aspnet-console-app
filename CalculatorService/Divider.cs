using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Divider : IDivider
    {
        public int Divide(int x, int y)
        {
            try
            {
                return x / y;
            } catch (DivideByZeroException)
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
    }
}
