using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.DTO;

namespace ConsoleApp1.Business.Interfaces
{
    public interface IOutput
    {
        void DisplayResult(FindMissingDto dto);
    }
}
