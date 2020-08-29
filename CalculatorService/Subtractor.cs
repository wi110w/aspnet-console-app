using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Subtractor : ICalculator
    {
        public int OperationOrder => 3;
        public string OperationName => "Subtraction";
        public int Calculate(int x, int y) => x - y;
        public double Calculate(double x, double y) => x - y;
    }
}
