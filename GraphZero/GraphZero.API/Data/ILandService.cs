using GraphZero.API.Data.Entities;//
using System;
using System.Collections.Generic;//
using System.Threading.Tasks;//

namespace GraphZero.API.Data
{
    /// <summary>
    /// Available functionality related to Land Requests
    /// </summary>
    public interface ILandService
    {
        /*
        /// <summary>
        /// Gets a list of <see cref="Request"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of request order Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="Request"/></returns>
        Task<List<Request>> GetRequestsAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="RequestDetail"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of request detail Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="RequestDetail"/></returns>
        Task<List<RequestDetail>> GetRequestDetailsAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="Consumer"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of consumer Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="Consumer"/></returns>
        Task<List<Consumer>> GetConsumersAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="Settlement"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of settlement Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="Settlement"/></returns>
        Task<List<Settlement>> GetSettlementsAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="SettlementDetail"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of settlement detail Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="SettlementDetail"/></returns>
        Task<List<SettlementDetail>> GetSettlementDetailsAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="Parcel"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of parcel Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="Parcel"/></returns>
        Task<List<Parcel>> GetParcelsAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="ParcelDetail"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of parcel detail Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="ParcelDetail"/></returns>
        Task<List<ParcelDetail>> GetParcelDetailsAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="Block"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of block Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="Block"/></returns>
        Task<List<Block>> GetBlocksAsync(List<int> Ids = null);

        /// <summary>
        /// Gets a list of <see cref="BlockDetail"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of block detail Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="BlockDetail"/></returns>
        Task<List<BlockDetail>> GetBlockDetailsAsync(List<int> Ids = null);*/

        /// <summary>
        /// Gets a list of <see cref="Lot"/> asynchronously based on the given parameters
        /// </summary>
        /// <param name="Ids">(optional) The list of lot Ids to search and retrieve</param>
        /// <returns>When found, returns the list of <see cref="Lot"/></returns>
        Task<List<Lot>> GetLotsAsync(List<int> Ids = null);
    }
}
