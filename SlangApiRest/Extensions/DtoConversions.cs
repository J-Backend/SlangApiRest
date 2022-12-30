using SlangApiRest.ModelsDB;
using SlangModels.Dtos;

namespace SlangApiRest.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<SlangDto> ConvertToDto(this IEnumerable<Slang> listDB) { 
            
            var listDto = (from oSlang in listDB
                          select new SlangDto()
                          {
                              Id = oSlang.Id,
                              Meaning = oSlang.Meaning, 
                              Phrase = oSlang.Phrase
                          }).ToList();
            return listDto;
        }

        public static SlangDto ConvertToDto(this Slang slangDB)
        {

            var slangDto = new SlangDto()
            {
                Id = slangDB.Id,
                Meaning = slangDB.Meaning,
                Phrase = slangDB.Phrase
            };
            return slangDto;
        }

        public static Slang ConvertFromDto(this SlangDto slangDto)
        {

            var slangDB = new Slang()
            {
                Id= slangDto.Id,
                Meaning = slangDto.Meaning,
                Phrase = slangDto.Phrase
            };
            return slangDB;
        }

        public static Slang ConvertFromDto(this NewSlangDto slangDto)
        {

            var slangDB = new Slang()
            {
                Meaning = slangDto.Meaning,
                Phrase = slangDto.Phrase
            };
            return slangDB;
        }
    }
}
