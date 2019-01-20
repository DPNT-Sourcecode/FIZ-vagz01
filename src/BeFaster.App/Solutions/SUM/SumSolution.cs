using System;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            if (!IsValidInput(x))
                throw new ArgumentException("must be a positive integer between 0-100", "x");
            if (!IsValidInput(y))
                throw new ArgumentException("must be a positive integer between 0-100", "y");

            return x + y; 
        }

        private static bool IsValidInput(int val)
            => (val > 0 && val < 100);
    }
}
