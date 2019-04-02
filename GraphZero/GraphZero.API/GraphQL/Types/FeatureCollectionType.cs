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
    public class FeatureCollectionType : ObjectGraphType<FeatureCollection>
    {
        public FeatureCollectionType(LandRepository landRepository, IDataLoaderContextAccessor dataLoaderAccessor)
        {
            Name = "collection";

            Field(t => t.Type).Description("geometry type");//FEATURECOLLECTION

            Field<ListGraphType<FeaturesType>>(
                "Features",
                //resolve: context => landRepository.GetLotForBlock(context.Source.Id)
                resolve: context =>
                {
                    //var user = (ClaimsPrincipal)context.UserContext;//ADDED 4 AUTHORIZATION
                    var loader = dataLoaderAccessor.Context.GetOrAddCollectionBatchLoader<int, Features>
                    (
                        "GetLotsByLotId", landRepository.GetFeaturesForCollection
                    );
                    return loader.LoadAsync(context.Source.Id);
                }
            );
        }
    }
}