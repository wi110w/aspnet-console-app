using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public class Additor : IAdditor
    {
        public int Add(int x, int y) => x + y;
        public double Add(double x, double y) => x + y;
    }
}
