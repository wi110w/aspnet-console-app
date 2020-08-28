using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorService
{
    public interface ICalculator
    {
        int Add(int x, int y);
        double Add(double x, double y);

        int Subtract(int x, int y);
        double Subtract(double x, double y);

        int Multiply(int x, int y);
        double Multiply(double x, double y);

        int Divide(int x, int y);
        double Divide(double x, double y);
    }
}
