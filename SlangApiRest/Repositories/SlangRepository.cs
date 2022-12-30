using Microsoft.EntityFrameworkCore;
using SlangApiRest.Database;
using SlangApiRest.ModelsDB;
using SlangApiRest.Repositories.Contracts;
using SlangModels;
using SlangApiRest.Helpers;
using SlangModels.Dtos;
using SlangApiRest.Extensions;

namespace SlangApiRest.Repositories
{
    public class SlangRepository : ISlangRepository
    {
        private readonly SlangDbContext db;

        public SlangRepository(SlangDbContext db)
        {
            this.db = db;
        }
        public async Task<ResponseDto> GetSlangs(Pagination pagination, HttpContext httpContext)
        {
            //IEnumerable<Slang>
            try
            {
                var queryable = this.db.Slangs.AsQueryable();

                await httpContext.InsertParameters(queryable, pagination.Quantity);

                var total = this.db.Slangs.Count();
                var list = await queryable.MakePage(pagination).ToListAsync();
                var listDto = list.ConvertToDto();

                var result = new ResponseDto()
                {
                    List = listDto,
                    TotalSlangs = total
                };

                return result;
            }
            catch (Exception)
            {

                return null;
            }
           
        }

        public async Task<Slang> GetSlangById(int id)
        {
            try
            {
                var queryable = this.db.Slangs.AsQueryable();

                return await queryable.Where(x => x.Id == id).FirstAsync();
            }
            catch (Exception)
            {

                return null;
            }
           
        }

        public async Task<int> AddNewSlangAsync(Slang slang) 
        {
            try
            {
                var queryable = this.db.Slangs.AsQueryable();
                var list = await queryable.Where(x=>x.Phrase.Equals(slang.Phrase)).ToListAsync();

                if (list.Count==0)
                {
                    this.db.Slangs.Add(slang);
                    this.db.SaveChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }
     
        }

        public async Task<int> EditSlangAsync(Slang slang)
        {
            try
            {

                var slangUpdate = await this.db.Slangs.FindAsync(slang.Id);
                if (slangUpdate != null) 
                {
                    slangUpdate.Phrase = slang.Phrase;
                    slangUpdate.Meaning = slang.Meaning;

                     this.db.Slangs.Entry(slangUpdate).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                     this.db.SaveChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }

        }

        public async Task<int> DeleteSlangAsync(int id)
        {
            try
            {

                var slangDelete = await this.db.Slangs.FindAsync(id);
                if(slangDelete != null) 
                {
                    db.Slangs.Entry(slangDelete).State = Microsoft.EntityFrameworkCore.EntityState.Deleted;
                    this.db.SaveChanges();
                    return 1;
                }
                return 0;
            }
            catch (Exception)
            {
                return 0;
            }

        }
    }
}
