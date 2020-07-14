
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
            //Arrangement
            Calculator calculator = new Calculator();

            //Action
            int num1 = 3, num2 = 8;
            var result = calculator.Add(num1, num2);

            //Asert
            Assert.AreEqual(num1 + num2, result);
        }
    }
}
