using System.Collections.Generic;
using System.Linq;/////
using System.Threading.Tasks;
using GraphZero.API.Data;
using GraphZero.API.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace GraphZero.API.Repositories
{
    public class LandRepository
    {
        private readonly LandDbContext _dbContext;

        public LandRepository(LandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        //lotes
        public Task<List<Lot>> GetAllLots()
        {
            return _dbContext.Lots.ToListAsync();
        }

        public async Task<IEnumerable<Lot>> GetLotForBlock(int blockId)
        {
            return await _dbContext.Lots.Where(lt => lt.BlockId == blockId).ToListAsync();
        }

        public async Task<ILookup<int, Lot>> GetLotForBlocks(IEnumerable<int> blockIds)
        {
            var reviews = await _dbContext.Lots.Where(lt => blockIds.Contains(lt.BlockId)).ToListAsync();
            return reviews.ToLookup(l => l.BlockId);
        }

        public Task<List<Block>> GetAllBlocks()
        {
            return _dbContext.Blocks.ToListAsync();
        }

        /*public async Task<IEnumerable<Block>> GetBlockForLot(int lotId)
        {
            return await _dbContext.Blocks.Where(lt => lt.LotId == lotId).ToListAsync();
        }

        public async Task<ILookup<int, Block>> GetBlockForLots(IEnumerable<int> lotIds)
        {
            var reviews = await _dbContext.Blocks.Where(lt => lotIds.Contains(lt.LotId)).ToListAsync();
            return reviews.ToLookup(r => r.LotId);
        }*/
    }
}
