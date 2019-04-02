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
    public class LotPropertyType : ObjectGraphType<Lot>
    {
        public LotPropertyType()
        {
            Name = "properties";

            Field(t => t.Id).Description("The lot identifier");
            Field(t => t.BlockId).Description("The lot identifier");
            Field(t => t.Name).Description("The lot number (name)");
            Field(t => t.AreaCode).Description("Geographic location related");
            Field(t => t.Area).Description("Lot area");
            Field(t => t.UseType).Description("Lot use type");
            Field(t => t.FrontMeasure).Description("Front measure of the lot");
            Field(t => t.LeftMeasure).Description("Left measure of the lot");
            Field(t => t.BackMeasure).Description("Back measure of the lot");
            Field(t => t.RightMeasure).Description("Right measure of the lot");
        }
    }
}