using GraphQL.DataLoader;
using GraphQL.Types;//
using GraphZero.API.Data.Entities;//
using GraphZero.API.Repositories;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.GraphQL.Types
{
    public class BlockPropertyType : ObjectGraphType<Block>
    {
        public BlockPropertyType(LandRepository landRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Name = "properties";

            Field(block => block.Id).Description("The block identifier");
            Field(block => block.Name).Description("The block number (name)");
            Field(block => block.AreaCode).Description("Geographic location related");
            Field(block => block.Area).Description("Block area");
            Field(block => block.UseType).Description("Block use type");
            Field(block => block.LotsQty).Description("Amount of lots contained in the block");
        }
    }
}
