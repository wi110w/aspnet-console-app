using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Additor : ICalculator
    {
        public int OperationOrder => 2;
        public string OperationName => "Addition";
        public int Calculate(int x, int y) => x + y;
        public double Calculate(double x, double y) => x + y;
    }
}
