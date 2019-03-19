using GraphQL.Types;//
using GraphZero.API.Data;//
using GraphZero.API.Data.Entities;//
using System;
using System.Collections.Generic;
using System.Text;

namespace GraphZero.API.GraphQL.Types
{
    public class LotType : ObjectGraphType<Lot>
    {
        public LotType()
        {
            Name = "Lot";

            Field(lot => lot.Id).Description("The lot identifier");
            Field(lot => lot.Name).Description("The lot number (name)");
            Field(lot => lot.AreaCode).Description("Geographic location related");
            Field(lot => lot.Area).Description("The lot area");
            Field(lot => lot.UseType).Description("The lot type of use");
            Field(lot => lot.FrontMeasure).Description("The front measurement");
            Field(lot => lot.LeftMeasure).Description("The left measuremente");
            Field(lot => lot.BackMeasure).Description("The back measurement");
            Field(lot => lot.RightMeasure).Description("The right measurement");
        }
    }
}
