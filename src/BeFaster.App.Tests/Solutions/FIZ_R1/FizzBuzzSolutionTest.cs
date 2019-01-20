using BeFaster.App.Solutions.FIZ;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.FIZ_R1
{
    [TestFixture]
    public class FizzBuzzSolutionTest
    {
        [TestCase(3, ExpectedResult = "fizz")]
        [TestCase(9, ExpectedResult = "fizz")]
        [TestCase(10, ExpectedResult = "buzz")]
        [TestCase(15, ExpectedResult = "fizz buzz")]
        [TestCase(22, ExpectedResult =  "22")]
        [TestCase(1, ExpectedResult = "1")]
        [TestCase(9999, ExpectedResult = "fizz")]
        public string Fiz_R1(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
    }
}

