using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public interface ISubtractor
    {
        int Subtract(int x, int y);
        double Subtract(double x, double y);
    }
}
