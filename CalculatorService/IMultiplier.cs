using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public interface IMultiplier
    {
        int Multiply(int x, int y);
        double Multiply(double x, double y);
    }
}
