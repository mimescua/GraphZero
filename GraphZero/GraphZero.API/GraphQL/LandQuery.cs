using GraphZero.API.GraphQL.Types;
using GraphZero.API.Repositories;
using GraphQL.Types;

namespace GraphZero.API.GraphQL
{
    public class LandQuery : ObjectGraphType
    {
        public LandQuery(LandRepository landRepository)
        {
            Field<ListGraphType<LotType>>(
                "lots",
                resolve: context => landRepository.GetAllLots()
            );
            Field<ListGraphType<BlockType>>(
                "blocks",
                resolve: context => landRepository.GetAllBlocks()
            );
            Field<BlockType>(
                "block",
                arguments: new QueryArguments(new QueryArgument<NonNullGraphType<IdGraphType>>
                    { Name = "id"}),
                resolve: context =>
                {
                    var id = context.GetArgument<int>("id");
                    return landRepository.GetOneBlock(id);
                }
            );
        }
    }
}