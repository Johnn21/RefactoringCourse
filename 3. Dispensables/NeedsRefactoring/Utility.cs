using System;

namespace NeedsRefactoring
{
    public class Utility
    {
        public string ReverseString(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public string ReverseStringDuplicate(string input)
        {
            char[] charArray = input.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        public int CalculateFactorial(int number)
        {
            if (number == 0)
                return 1;
            return number * CalculateFactorial(number - 1);
        }
    }
}
