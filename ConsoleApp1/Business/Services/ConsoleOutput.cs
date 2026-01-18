using ConsoleApp1.Business.Interfaces;
using ConsoleApp1.DTO;

namespace ConsoleApp1.Business.Services
{
    public class ConsoleOutput : IOutput
    {
        public void DisplayResult(FindMissingDto dto)
        {
            if (dto == null)
            {
                throw new ArgumentNullException(nameof(dto), "DTO cannot be null.");
            }
            if (dto.MissingNumber == null)
            {
                throw new ArgumentException("Missing number has not been calculated.", nameof(dto));
            }

            Console.WriteLine($"The missing number is: {dto.MissingNumber}");
        }
    }
}
