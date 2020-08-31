using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public interface IDivider
    {
        int Divide(int x, int y);
        double Divide(double x, double y);
    }
}
