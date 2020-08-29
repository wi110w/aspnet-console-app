using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public interface ICalculator
    {
        int Calculate(int x, int y);
        double Calculate(double x, double y);
        int OperationOrder { get; }
        string OperationName { get; }
    }
}
