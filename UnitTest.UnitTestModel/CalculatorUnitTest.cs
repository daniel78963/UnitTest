
namespace UnitTest.UnitTestModel
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using UnitTest.Model.Data.Entities;

    [TestClass]
    public class CalculatorUnitTest
    {
        [TestMethod]
        public void TestCalculatorAdd()
        {
            Calculator calculator = new Calculator();

            int num1 = 3, num2 = 8;
            var result = calculator.Add(num1, num2);

            Assert.AreEqual(num1 + num2, result);
        }
    }
}
