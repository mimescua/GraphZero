using GraphQL.DataLoader;//
using GraphQL.Types;//
using GraphZero.API.Data.Entities;//
using GraphZero.API.Repositories;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.GraphQL.Types
{
    public class FeaturesType : ObjectGraphType<Features>
    {
        public FeaturesType(LandRepository landRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Name = "Features";

            Field(t => t.Type).Description("Feature type");

            Field<BlockGeometryType>(//ENMASCARAR NOMBRE A "geometry"
                "blockGeometry",
                resolve: context => landRepository.GetBlockGeomForFeature(context.Source.Id)
                /*resolve: context =>
                {
                    //var user = (ClaimsPrincipal)context.UserContext;//ADDED 4 AUTHORIZATION
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, Block>
                    (
                        "GetLotsByLotId", landRepository.GetLotForBlocks
                    );
                    return loader.LoadAsync(context.Source.Id);
                }*/
            );
            Field<BlockPropertyType>(
                "blockProperties",
                resolve: context => landRepository.GetBlockPropsForFeature(context.Source.Id)
            );

            Field<LotGeometryType>(
                "lotGeometry",
                resolve: context => landRepository.GetLotGeomForFeature(context.Source.Id)
            );
            Field<LotPropertyType>(
                "lotProperties",
                resolve: context => landRepository.GetLotPropsForFeature(context.Source.Id)
            );
        }
    }
}