using System.Linq;

namespace BeFaster.App.Solutions.FIZ
{
    public static class FizzBuzzSolution
    {
        public static string FizzBuzz(int number)
        {
            var multipleOf3 = IsMultiple(number, 3);
            var multipleOf5 = IsMultiple(number, 5);

            var contains3 = Contains(number, "3");
            var contains5 = Contains(number, "5");

            var greaterThan10 = number > 10;
            var chars = number.ToString().ToCharArray();
            var allIdentical = chars.All(c => c.Equals(chars[0]));

            var fizz = "fizz";
            var buzz = "buzz";
            var deluxe = "deluxe";

            if (multipleOf3 || contains3)
            {
                if (multipleOf5 || contains5)
                {
                    if (greaterThan10 && allIdentical)
                    {
                        return $"{fizz} {buzz} {deluxe}";
                    }

                    return $"{fizz} {buzz}";
                }

                if (greaterThan10 && allIdentical)
                {
                    return $"{fizz} {buzz} {deluxe}";
                }

                return fizz;
            }

            if (multipleOf5 || contains5)
            {
                if (multipleOf3 || contains3)
                {
                    return $"{fizz} {buzz}";
                }

                return buzz;
            }

            return $"{number}";
        }

        private static bool IsMultiple(int number, int multipleOf)
        => number % multipleOf == 0;

        private static bool Contains(int number, string divisibleBy)
            => number.ToString().Contains(divisibleBy);
    }
}




