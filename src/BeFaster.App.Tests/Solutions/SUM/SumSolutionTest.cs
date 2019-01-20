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
        
        public int ComputeSum(int x, int y)
        {
            return SumSolution.Sum(x, y);
        }

        [TestCase(0, 0)]
        [TestCase(100, 100)]
        public void ComputeSum_Throws(int x, int y)
        {
            Assert.That(() => SumSolution.Sum(x, y), Throws.TypeOf<ArgumentException>());
        }
    }
}

