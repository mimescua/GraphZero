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
        public Task<List<Lot>> GetAllLots()//QUERY TODOS LOS LOTES
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

        //manzanas
        public Task<List<Block>> GetAllBlocks()//QUERY TODOS LAS MANZANAS
        {
            return _dbContext.Blocks.ToListAsync();
        }

        public async Task<Block> GetOneBlock(int id)//UN BLOQUE POR ID
        {
            return await _dbContext.Blocks.SingleOrDefaultAsync(p => p.Id == id);
        }

        //geojson
        public Task<List<FeatureCollection>> GetFeatureCollection()
        {
            return _dbContext.FeatureCollection.ToListAsync();
        }

        public async Task<ILookup<int, Features>> GetFeaturesForCollection(IEnumerable<int> _fkeys)
        {
            var reviews = await _dbContext.Features.Where(lt => _fkeys.Contains(lt._fkey)).ToListAsync();
            return reviews.ToLookup(t => t._fkey);
        }

        public async Task<Block> GetBlockGeomForFeature(int id)
        {
            var result = _dbContext.Blocks.Where(t => t.Id == id).Select(t => new Block{ Type=t.Type, Coordinates=t.Coordinates} ).SingleOrDefaultAsync();

            return await result;
        }

        public async Task<Block> GetBlockPropsForFeature(int id)
        {
            var result = _dbContext.Blocks.Where(t => t.Id == id)
                .Select(t => new Block { Name = t.Name, AreaCode = t.AreaCode, Area = t.Area, UseType = t.UseType, LotsQty = t.LotsQty }).SingleOrDefaultAsync();

            return await result;
        }

        public async Task<Lot> GetLotGeomForFeature(int id)
        {
            var result = _dbContext.Lots.Where(t => t.Id == id)
                .Select(t => new Lot { Type = t.Type, Coordinates = t.Coordinates }).SingleOrDefaultAsync();

            return await result;
        }

        public async Task<Lot> GetLotPropsForFeature(int id)
        {
            var result = _dbContext.Lots.Where(t => t.Id == id)
                .Select(t => new Lot { Name = t.Name, AreaCode = t.AreaCode, Area = t.Area, UseType = t.UseType,
                    FrontMeasure = t.FrontMeasure, LeftMeasure = t.LeftMeasure, BackMeasure = t.BackMeasure, RightMeasure = t.RightMeasure
                }).SingleOrDefaultAsync();

            return await result;
        }
    }
}