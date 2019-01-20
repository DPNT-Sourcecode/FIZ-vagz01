using BeFaster.App.Solutions.SUM;
using NUnit.Framework;
using System;

namespace BeFaster.App.Tests.Solutions.SUM
{
    [TestFixture]
    public class SumSolutionTest
    {
        [TestCase(1, 1, ExpectedResult = 2)]
        [TestCase(99, 99, ExpectedResult = 198)]
        [TestCase(10, 5, ExpectedResult = 15)]
        [TestCase(100, 50, ExpectedResult = 150)]
        [TestCase(100, 100, ExpectedResult = 200)]
        [TestCase(0, 0, ExpectedResult = 0)]
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(-1, -1)]
        [TestCase(10, -1)]
        [TestCase(101, 1)]
        [TestCase(101, 101)]
        public void ComputeSum_Throws(int x, int y)
        {
            Assert.That(() => SumSolution.Sum(x, y), Throws.TypeOf<ArgumentException>());
        }
    }
}



