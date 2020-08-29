using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorService;
using System;

namespace CalculatorServiceTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void TestAdd()
        {
            ICalculator additor = new Additor();

            Assert.AreEqual(5, additor.Calculate(3, 2));
            Assert.AreEqual(8, additor.Calculate(4, 4));
            Assert.AreEqual(-2, additor.Calculate(-1, -1));
            Assert.AreEqual(0, additor.Calculate(1, -1));
            Assert.AreEqual(3, additor.Calculate(1.5, 1.5));
            Assert.AreEqual(4.5, additor.Calculate(4, 0.5));
        }

        [TestMethod]
        public void TestSubtract()
        {
            ICalculator subtractor = new Subtractor();

            Assert.AreEqual(1, subtractor.Calculate(3, 2));
            Assert.AreEqual(-3, subtractor.Calculate(3, 6));
            Assert.AreEqual(9, subtractor.Calculate(3, -6));
            Assert.AreEqual(4, subtractor.Calculate(9.5, 5.5));
            Assert.AreEqual(1.5, subtractor.Calculate(6, 4.5));
        }

        [TestMethod]
        public void TestMultiply()
        {
            ICalculator mutiplier = new Multiplier();

            Assert.AreEqual(6, mutiplier.Calculate(3, 2));
            Assert.AreEqual(0, mutiplier.Calculate(4, 0));
            Assert.AreEqual(-8, mutiplier.Calculate(-2, 4));
            Assert.AreEqual(6.25, mutiplier.Calculate(2.5, 2.5));
        }

        [TestMethod]
        public void TestDivide()
        {
            ICalculator divider = new Divider();

            Assert.AreEqual(3, divider.Calculate(6, 2));
            Assert.AreEqual(0, divider.Calculate(0, 4));
            Assert.AreEqual(1.2, divider.Calculate(6.0, 5.0));
            Assert.AreEqual(-1, divider.Calculate(5, 0));
        }


    }
}
