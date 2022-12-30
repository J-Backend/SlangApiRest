using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlangModels
{
    public class Pagination
    {
        public int Page { get; set; } = 1;
        public int Quantity { get; set; } = 5;
    }
}
