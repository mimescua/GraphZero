using GraphQL.Types;//
using GraphZero.API.Data.Entities;//
using GraphZero.API.Repositories;//
using System;
using System.Collections.Generic;
using System.Linq;//
using System.Text;

namespace GraphZero.API.GraphQL.Types
{
    public class BlockType : ObjectGraphType<Block>
    {
        public BlockType(LandRepository landRepository)
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
                resolve: context => landRepository.GetLotForBlock(context.Source.Id)
                /*var loader =
                        dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, ProductReview>(
                            "GetReviewsByProductId", reviewRepository.GetForProducts);
            return loader.LoadAsync(context.Source.Id);*/
                /*{
                    try
                    {
                        var request = new List<int> { context.Source.Id };
                        var details = service.GetBlockDetailsAsync(request).Result;
                        return details;
                    }
                    catch
                    {
                        //I would usually add logs here. Skipping that for demo simplicity
                        return new List<BlockDetail>();
                    }
                }*/);
        }
    }
}
