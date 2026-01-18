using ConsoleApp1.Business.Interfaces;

namespace ConsoleApp1.Business.Services
{
    public class ArrayLibrary : IArrayLibrary
    {
        public int FindMissingNumber(int[] numbers)
        {
            var counter = new bool[numbers.Length + 1];

            foreach (var number in numbers)
            {
                if (number < 0 ||
                    number > counter.Length-1)
                {
                    throw new ArgumentOutOfRangeException(nameof(numbers), $"Invalid input {number} cannot be greater than {counter.Length - 1}.");
                }
                if (counter[number] == true)
                {
                    throw new ArgumentException($"Duplicate number found: {number}", nameof(numbers));
                }

                counter[number] = true;
            }

            return Array.IndexOf(counter, false);
        }
    }
}
