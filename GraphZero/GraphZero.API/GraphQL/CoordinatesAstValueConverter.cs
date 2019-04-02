using GraphQL.Language.AST;//
using GraphQL.Types;//
using GraphZero.API.Data.Entities;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.GraphQL
{
    public class CoordinatesAstValueConverter : IAstFromValueConverter
    {
        public IValue Convert(object value, IGraphType type)
        {
            return new CoordinatesValue((Coordinates)value);
        }

        public bool Matches(object value, IGraphType type)
        {
            return value is Coordinates;
        }
    }
}
