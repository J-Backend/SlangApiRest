using System.ComponentModel.DataAnnotations;

namespace SlangApiRest.ModelsDB
{
    public class Slang
    { 
        public int Id { get; set; }
        public string Phrase { get; set; }
        public string Meaning { get; set; }
    }
}
