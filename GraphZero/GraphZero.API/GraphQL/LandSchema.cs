using GraphQL;
using GraphQL.Types;

namespace GraphZero.API.GraphQL
{
    public class LandSchema: Schema
    {
        public LandSchema(IDependencyResolver resolver): base(resolver)
        {           
            Query = resolver.Resolve<LandQuery>();
        }
    }
}
