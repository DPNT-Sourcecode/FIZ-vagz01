using BeFaster.App.Solutions.HLO;
using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("John", ExpectedResult = "Hello, John!")]
        [TestCase("Lucy", ExpectedResult = "Hello, Lucy!")]
        public string SaysHello(string name)
            => HelloSolution.Hello(name);
    }
}


