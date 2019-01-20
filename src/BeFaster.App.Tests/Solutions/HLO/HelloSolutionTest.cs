using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("John", ExpectedResult = "Hello, World!")]
        [TestCase("Lucy", ExpectedResult = "Hello, World!")]
        [TestCase("", ExpectedResult = "Hello, World!")]
        [TestCase(null, ExpectedResult = "Hello, World!")]
        public string SaysHello(string name)
            => HelloSolution.Hello(name);

        [TestCase("John", ExpectedResult = "Hello, John!")]
        [TestCase("Lucy", ExpectedResult = "Hello, Lucy!")]
        public string SaysHello2(string name)
            => HelloSolution.Hello2(name);
    }
}

