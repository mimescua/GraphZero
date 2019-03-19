using GraphZero.API.Data;//
using GraphZero.API.Data.Entities;//
using System;
using System.Collections.Generic;
using System.Linq;//
using System.Text;
using System.Threading.Tasks;//

namespace GraphZero.API.Repositories
{
    /// <inheritdoc />
    /// <summary>
    /// Implementation of <see cref="ILandService"/> using static mock data (not coming from database)
    /// </summary>
    public class StaticLandService : ILandService
    {
        /*
        /// <inheritdoc />
        public async Task<List<Request>> GetRequestsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.Requests)
                : await Task.FromResult(InMemoryData.Requests.Where(request => Ids.Contains(request.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<RequestDetail>> GetRequestDetailsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.RequestDetails)
                : await Task.FromResult(InMemoryData.RequestDetails.Where(rdetail => Ids.Contains(rdetail.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<Consumer>> GetConsumersAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.Consumers)
                : await Task.FromResult(InMemoryData.Consumers.Where(consumer => Ids.Contains(consumer.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<Settlement>> GetSettlementsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.Settlements)
                : await Task.FromResult(InMemoryData.Settlements.Where(settlement => Ids.Contains(settlement.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<SettlementDetail>> GetSettlementDetailsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.SettlementDetails)
                : await Task.FromResult(InMemoryData.SettlementDetails.Where(sdetail => Ids.Contains(sdetail.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<Parcel>> GetParcelsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.Parcels)
                : await Task.FromResult(InMemoryData.Parcels.Where(parcel => Ids.Contains(parcel.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<ParcelDetail>> GetParcelDetailsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.ParcelDetails)
                : await Task.FromResult(InMemoryData.ParcelDetails.Where(pdetail => Ids.Contains(pdetail.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<Block>> GetBlocksAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.Blocks)
                : await Task.FromResult(InMemoryData.Blocks.Where(block => Ids.Contains(block.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<BlockDetail>> GetBlockDetailsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.BlockDetails)
                : await Task.FromResult(InMemoryData.BlockDetails.Where(bdetail => Ids.Contains(bdetail.Id)).ToList());
        }
        */
        /// <inheritdoc />
        public async Task<List<Lot>> GetLotsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.Lots)
                : await Task.FromResult(InMemoryData.Lots.Where(lot => Ids.Contains(lot.Id)).ToList());
        }

        /// <inheritdoc />
        public async Task<List<LotDetail>> GetLotDetailsAsync(List<int> Ids = null)
        {
            return Ids == null || !Ids.Any()
                ? await Task.FromResult(InMemoryData.LotDetails)
                : await Task.FromResult(InMemoryData.LotDetails.Where(ldetail => Ids.Contains(ldetail.Id)).ToList());
        }
    }
}
