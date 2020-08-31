using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public interface IAdditor
    {
        int Add(int x, int y);
        double Add(double x, double y);
    }
}
