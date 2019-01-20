using NUnit.Framework;

namespace BeFaster.App.Tests.Solutions.HLO
{
    [TestFixture]
    public class HelloSolutionTest
    {
        [TestCase("John", ExpectedResult = "Hello")]
        [TestCase("Lucy", ExpectedResult = "Hello")]
        [TestCase("", ExpectedResult = "Hello")]
        [TestCase(null, ExpectedResult = "Hello")]
        public string SaysHello(string name)
            => "Hello";
    }
}
