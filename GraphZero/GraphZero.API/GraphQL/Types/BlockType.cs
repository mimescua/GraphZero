using GraphQL.DataLoader;//
using GraphQL.Types;//
using GraphZero.API.Data.Entities;//
using GraphZero.API.Repositories;//
using System;
using System.Collections.Generic;
using System.Linq;//
using System.Security.Claims;//
using System.Text;

namespace GraphZero.API.GraphQL.Types
{
    public class BlockType : ObjectGraphType<Block>
    {
        public BlockType(LandRepository landRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Name = "Block";

            Field(block => block.Id).Description("The block identifier");
            Field(block => block.Name).Description("The block number (name)");
            Field(block => block.AreaCode).Description("Geographic location related");
            Field(block => block.Area).Description("Block area");
            Field(block => block.UseType).Description("Block use type");
            Field(block => block.LotsQty).Description("Amount of lots contained in the block");
            Field<ListGraphType<LotType>>(
                "LotIds",
                //resolve: context => landRepository.GetLotForBlock(context.Source.Id)
                resolve: context =>
                {
                    //var user = (ClaimsPrincipal)context.UserContext;//ADDED 4 AUTHORIZATION
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, Lot>
                    (
                        "GetLotsByLotId", landRepository.GetLotForBlocks
                    );
                    return loader.LoadAsync(context.Source.Id);
                }
            );
        }
    }
}
