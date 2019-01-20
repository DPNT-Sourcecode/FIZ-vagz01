using BeFaster.Runner.Exceptions;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var multipleOf3 = IsMultiple(number, 3);
            var multipleOf5 = IsMultiple(number, 5);
            var fizz = "fizz";
            var buzz = "buzz";
            if (multipleOf3)
            {
                return "Fizz";
            }
        }

        private static bool IsMultiple(int number, int multipleOf)
        => number % multipleOf == 0;
    }
}


