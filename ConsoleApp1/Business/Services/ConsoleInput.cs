using ConsoleApp1.Business.Interfaces;
using ConsoleApp1.DTO;
using ConsoleApp1.Validators;

namespace ConsoleApp1.Business.Services
{
    public class ConsoleInput : IInput
    {

        public FindMissingDto GetUserInput()
        {
            Console.WriteLine("Enter a list of numbers separated by commas and wrapped in brackets (e.g., [1,2,3,5]):");
            string? input = Console.ReadLine();

            if (input == null || !input.IsNumbersArray())
            {
                throw new ArgumentException("Invalid input format. Please ensure the input is in the correct format.");
            }

            var numbers = input[1..^1]
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(numStr => int.Parse(numStr.Trim()))
                .ToArray();

            return new FindMissingDto
            {
                Numbers = numbers
            };
        }
    }
}
