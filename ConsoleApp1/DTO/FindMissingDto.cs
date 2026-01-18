using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DTO
{
    public class FindMissingDto
    {
        public int[] Numbers { get; set; }
        public int? MissingNumber { get; set; }
    }
}
