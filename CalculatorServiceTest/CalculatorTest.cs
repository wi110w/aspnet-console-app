using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorService;

namespace CalculatorServiceTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            ICalculator calculator = new Calculator();

            Assert.AreEqual(5, calculator.Add(3, 2));
            Assert.AreEqual(8, calculator.Add(4, 4));
            Assert.AreEqual(-2, calculator.Add(-1, -1));
            Assert.AreEqual(0, calculator.Add(1, -1));
            Assert.AreEqual(3, calculator.Add(1.5, 1.5));
            Assert.AreEqual(4.5, calculator.Add(4, 0.5));
        }

        [TestMethod]
        public void TestSubtract()
        {
            ICalculator calculator = new Calculator();

            Assert.AreEqual(1, calculator.Subtract(3, 2));
            Assert.AreEqual(-3, calculator.Subtract(3, 6));
            Assert.AreEqual(9, calculator.Subtract(3, -6));
            Assert.AreEqual(4, calculator.Subtract(9.5, 5.5));
            Assert.AreEqual(1.5, calculator.Subtract(6, 4.5));
        }

        [TestMethod]
        public void TestMultiply()
        {
            ICalculator calculator = new Calculator();

            Assert.AreEqual(6, calculator.Multiply(3, 2));
            Assert.AreEqual(0, calculator.Multiply(4, 0));
            Assert.AreEqual(-8, calculator.Multiply(-2, 4));
            Assert.AreEqual(6.25, calculator.Multiply(2.5, 2.5));
        }

        [TestMethod]
        public void TestDivide()
        {
            ICalculator calculator = new Calculator();

            Assert.AreEqual(3, calculator.Divide(6, 2));
            Assert.AreEqual(0, calculator.Divide(0, 4));
            Assert.AreEqual(1.2, calculator.Divide(6.0, 5.0));
        }


    }
}
