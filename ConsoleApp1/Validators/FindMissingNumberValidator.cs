using System.Text.RegularExpressions;

namespace ConsoleApp1.Validators
{
    public static class FindMissingNumberValidator
    {
        private const string _regexPattern = @"\d+(,\d+)*";
       

        public static bool IsNumbersArray(this string input)
        {
            if (string.IsNullOrEmpty(input)
                ||
                input.Length < 3
                ||
                (!input.StartsWith('[')
                 || !input.EndsWith(']')))
            {
                return false;
            }

            var match = Regex.Match(input[1..^1], _regexPattern);


            return match.Success;
        }
    }
}
