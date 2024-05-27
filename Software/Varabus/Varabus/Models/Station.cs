using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varabus.Models
{
    internal class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Line { get; set; }
        public string Schedule { get; set; }

        public bool IsValidLine()
        {
            return Line <= 6 && Line >= 0;
        }
    }
}
