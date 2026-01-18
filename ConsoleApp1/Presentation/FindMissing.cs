using ConsoleApp1.Business.Interfaces;
using ConsoleApp1.DTO;

namespace ConsoleApp1.Presentation
{
    public class FindMissing
    {
        private readonly IInput _input;
        private readonly IArrayLibrary _arrayLibrary;
        private readonly IOutput _output;

        private FindMissingDto _userInput;

        public FindMissing(IInput input, IArrayLibrary arrayLibrary, IOutput output)
        {
            _input = input;
            _arrayLibrary = arrayLibrary;
            _output = output;
        }

        public void Execute()
        {
            // Implementation for finding the missing number
            try
            {
                _userInput = _input.GetUserInput();
                _userInput.MissingNumber = _arrayLibrary.FindMissingNumber(_userInput.Numbers);
                _output.DisplayResult(_userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

        }
    }
}
