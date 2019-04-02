using GraphQL.Types;//
using GraphZero.API.Data.Entities;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.GraphQL.Types
{
    public class LotGeometryType : ObjectGraphType<Lot>
    {
        public LotGeometryType()
        {
            Name = "geometry";

            Field(t => t.Type).Description("geometry type");
            Field(t => t.Coordinates).Description("The lot number (name)");
        }
    }
}
