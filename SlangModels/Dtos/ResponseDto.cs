using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SlangModels.Dtos
{
    public class ResponseDto
    {
        public int TotalSlangs { get; set; }
        public IEnumerable<SlangDto> List{ get; set; }
    }
}
