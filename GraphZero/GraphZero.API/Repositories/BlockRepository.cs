using System.Collections.Generic;
using System.Linq;/////
using System.Threading.Tasks;
using GraphZero.API.Data;
using GraphZero.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphZero.API.Repositories
{
    public class BlockRepository
    {
        private readonly LandDbContext _dbContext;

        public BlockRepository(LandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Block>> GetAll()
        {
            return _dbContext.Blocks.ToListAsync();
        }

        /*public async Task<IEnumerable<Block>> GetForLot(int lotId)
        {
            return await _dbContext.Blocks.Where(lt => lt.LotId == lotId).ToListAsync();
        }

        public async Task<ILookup<int, Block>> GetForLots(IEnumerable<int> lotIds)
        {
            var reviews = await _dbContext.Blocks.Where(lt => lotIds.Contains(lt.LotId)).ToListAsync();
            return reviews.ToLookup(r => r.LotId);
        }*/
    }
}