using System;

namespace BeFaster.App.Solutions.SUM
{
    public static class SumSolution
    {
        public static int Sum(int x, int y)
        {
            if (!IsValidInput(x))
                throw new ArgumentException("");
            return x + y; 
        }

        private static bool IsValidInput(int val)
            => (val > 0 && val < 100);
    }
}

