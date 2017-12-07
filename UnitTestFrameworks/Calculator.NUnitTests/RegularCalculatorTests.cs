using NUnit.Framework;

namespace Calculator.NUnitTests
{
    [TestFixture]
    public class RegularCalculatorTests
    {
        [Test]
        public void SumTest()//UnitOfWork_Scenario_ExpectedResult
        {
            RegularCalculator calculator = new RegularCalculator();
            var result = calculator.Sum(1, 2);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void SumTest2()
        {
        }
        

    }
}