using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Multiplier : ICalculator
    {
        public int OperationOrder => 1;
        public string OperationName => "Multiply";
        public int Calculate(int x, int y) => x * y;
        public double Calculate(double x, double y) => x * y;
    }
}
