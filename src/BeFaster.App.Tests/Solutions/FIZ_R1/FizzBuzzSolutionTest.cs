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
        [TestCase(53, ExpectedResult = "fizz buzz")]
        [TestCase(90, ExpectedResult = "fizz buzz")]
        [TestCase(43, ExpectedResult = "fizz")]
        [TestCase(571, ExpectedResult = "buzz")]
        [TestCase(371, ExpectedResult = "fizz")]
        public string Fiz_R1_R2(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }

        [TestCase(9999, ExpectedResult = "fizz deluxe")]
        [TestCase(55, ExpectedResult = "buzz deluxe")]
        [TestCase(555, ExpectedResult = "fizz buzz deluxe")]
        [TestCase(1241, ExpectedResult = "1241")]
        public string Fiz_R3(int number)
        {
            return FizzBuzzSolution.FizzBuzz(number);
        }
    }
}

