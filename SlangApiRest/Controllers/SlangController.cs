using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SlangApiRest.Extensions;
using SlangApiRest.Repositories.Contracts;
using SlangModels;
using SlangModels.Dtos;



namespace SlangApiRest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlangController : ControllerBase
    {
        private readonly ISlangRepository slangRepository;

        public SlangController(ISlangRepository slangRepository)
        {
            this.slangRepository = slangRepository;
        }

        [HttpGet]
        public async Task<ActionResult<ResponseDto>> ListSlangs([FromQuery]Pagination pagination) {
            try
            {
                var list = await this.slangRepository.GetSlangs(pagination, this.HttpContext);
                

                if (list == null)
                {
                    return NotFound();
                }
                else
                {
                    //var listDto = list.ConvertToDto();
                    //return Ok(listDto);
                    return list;
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<SlangDto>> GetSlang(int id)
        {
            try
            {
                var slang = await this.slangRepository.GetSlangById(id);

                if (slang == null)
                {
                    return NotFound();
                }
                else
                {
                    var slangDto = slang.ConvertToDto();
                    return Ok(slangDto);
                }
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<object> NewSlangAsync(NewSlangDto slangDto) 
        {
            var slangDB = slangDto.ConvertFromDto();

            var result = await this.slangRepository.AddNewSlangAsync(slangDB);

         
            if (result==0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }

            return StatusCode(StatusCodes.Status200OK, "Successful Insertion");
        }

        [HttpPut]
        public async Task<object> EditSlangAsync(SlangDto slangDto)
        {
            var slangDB = slangDto.ConvertFromDto();

            var result = await this.slangRepository.EditSlangAsync(slangDB);

            if (result == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }

            return StatusCode(StatusCodes.Status200OK, "Successful Edition");
        }

        [HttpDelete("{id:int}")]
        public async Task<object> DeleteSlangAsync(int id)
        {
            var result = await this.slangRepository.DeleteSlangAsync(id);

            if (result == 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");
            }

            return StatusCode(StatusCodes.Status200OK, "Successful deletion");
        }
    }
}
