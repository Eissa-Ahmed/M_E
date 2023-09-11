using Movie.BL.Interfaces;
using Movie.BL.Model;
using Movie.DAL.Database;
using Movie.DAL.Entity;

namespace Movie.BL.Repository
{
    public class GenerRepo : IGeners
    {
        private readonly ApplicationDbContext dbContext;
        public GenerRepo(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task AddGener(GenersVM model)
        {
            Gener gener = new Gener()
            {
                Name = model.Name,
            };
            await dbContext.Geners.AddAsync(gener);
            await dbContext.SaveChangesAsync();
        }
    }
}
