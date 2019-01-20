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

            //var greaterThan10 = number > 10;
            //var chars = number.ToString().ToCharArray();
            //var allIdentical = chars.All(c => c.Equals(chars[0]));

            var isOdd = number % 2 == 1;

            var fizz = "fizz";
            var buzz = "buzz";
            var deluxe = "deluxe";
            var fake = "fake deluxe";

            if (multipleOf3 || contains3)
            {
                if (multipleOf5 || contains5)
                {
                    if ((multipleOf3 && contains3) 
                        || (multipleOf5 && contains5))
                    {
                        if (isOdd)
                        {
                            return $"{fizz} {buzz} {fake}";
                        }

                        return $"{fizz} {buzz} {deluxe}";
                    }

                    return $"{fizz} {buzz}";
                }

                if (multipleOf3 && contains3)
                {
                    if (isOdd)
                    {
                        return $"{fizz} {fake}";
                    }

                    return $"{fizz} {deluxe}";
                }

                return fizz;
            }

            if (multipleOf5 || contains5)
            {
                if (multipleOf3 || contains3)
                {
                    return $"{fizz} {buzz}";
                }

                if (multipleOf5 && contains5)
                {
                    if (isOdd)
                    {
                        return $"{buzz} {fake}";
                    }

                    return $"{buzz} {deluxe}";
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


