using System.Collections.Generic;
using System.Linq;/////
using System.Threading.Tasks;
using GraphZero.API.Data;
using GraphZero.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphZero.API.Repositories
{
    public class LotRepository
    {
        private readonly LandDbContext _dbContext;

        public LotRepository(LandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Lot>> GetAll()
        {
            return _dbContext.Lots.ToListAsync();
        }

        public async Task<IEnumerable<Lot>> GetForBlock(int blockId)
        {
            return await _dbContext.Lots.Where(lt => lt.BlockId == blockId).ToListAsync();
        }

        public async Task<ILookup<int, Lot>> GetForBlocks(IEnumerable<int> blockIds)
        {
            var reviews = await _dbContext.Lots.Where(lt => blockIds.Contains(lt.BlockId)).ToListAsync();
            return reviews.ToLookup(l => l.BlockId);
        }
    }
}
