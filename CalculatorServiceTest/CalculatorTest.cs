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
            IAdditor additor = new Additor();

            Assert.AreEqual(5, additor.Add(3, 2));
            Assert.AreEqual(8, additor.Add(4, 4));
            Assert.AreEqual(-2, additor.Add(-1, -1));
            Assert.AreEqual(0, additor.Add(1, -1));
            Assert.AreEqual(3, additor.Add(1.5, 1.5));
            Assert.AreEqual(4.5, additor.Add(4, 0.5));
        }

        [TestMethod]
        public void TestSubtract()
        {
            ISubtractor subtractor = new Subtractor();

            Assert.AreEqual(1, subtractor.Subtract(3, 2));
            Assert.AreEqual(-3, subtractor.Subtract(3, 6));
            Assert.AreEqual(9, subtractor.Subtract(3, -6));
            Assert.AreEqual(4, subtractor.Subtract(9.5, 5.5));
            Assert.AreEqual(1.5, subtractor.Subtract(6, 4.5));
        }

        [TestMethod]
        public void TestMultiply()
        {
            IMultiplier multiplier = new Multiplier();

            Assert.AreEqual(6, multiplier.Multiply(3, 2));
            Assert.AreEqual(0, multiplier.Multiply(4, 0));
            Assert.AreEqual(-8, multiplier.Multiply(-2, 4));
            Assert.AreEqual(6.25, multiplier.Multiply(2.5, 2.5));
        }

        [TestMethod]
        public void TestDivide()
        {
            IDivider divider = new Divider();

            Assert.AreEqual(3, divider.Divide(6, 2));
            Assert.AreEqual(0, divider.Divide(0, 4));
            Assert.AreEqual(1.2, divider.Divide(6.0, 5.0));
            Assert.AreEqual(-1, divider.Divide(5, 0));
        }


    }
}
