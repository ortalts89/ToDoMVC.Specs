using System;

namespace Calculator.Tests
{
    [TestClass]
    public class RegularCalculatorTests
    {
        [Test("sum test")]
        public void SumTest(int first,int second,int expected)
        {
            RegularCalculator calculator = new RegularCalculator();
            var result = calculator.Sum(1, 2);
            Assert.AreEqual(3, result);
        }
    }

    public class Assert
    {
        public static void AreEqual(int expected, int actual)
        {
            if (expected != actual)
                throw new Exception($"Numbers are not equal, expected:{expected} actual: {actual}");
        }
    }

    public class TestClassAttribute : Attribute
    {
    }

    public class TestAttribute : Attribute
    {
        public string Description { get; }

        public TestAttribute(string description)
        {
            Description = description;
        }
    }
}