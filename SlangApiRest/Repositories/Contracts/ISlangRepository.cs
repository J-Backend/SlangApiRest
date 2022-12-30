
using SlangApiRest.ModelsDB;
using SlangModels;
using SlangModels.Dtos;

namespace SlangApiRest.Repositories.Contracts
{
    public interface ISlangRepository
    {
        public Task<ResponseDto> GetSlangs(Pagination pagination, HttpContext httpContext);

        public Task<Slang> GetSlangById(int id);

        public Task<int> AddNewSlangAsync(Slang slang);

        public Task<int> EditSlangAsync(Slang slang);

        public Task<int> DeleteSlangAsync(int id);
    }
}
