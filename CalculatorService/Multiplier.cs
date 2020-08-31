using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Multiplier : IMultiplier
    {
        public int Multiply(int x, int y) => x * y;
        public double Multiply(double x, double y) => x * y;
    }
}
