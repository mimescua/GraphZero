using GraphZero.API.GraphQL.Types;
using GraphZero.API.Repositories;
using GraphQL.Types;
using GraphZero.API.Data;//

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
        }
    }
}
/*namespace CarvedRock.Api.GraphQL
{
    public class CarvedRockQuery : ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => productRepository.GetAll()
            );
        }
    }
}*/

