using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Subtractor : ISubtractor
    {
        public int Subtract(int x, int y) => x - y;
        public double Subtract(double x, double y) => x - y;
    }
}
