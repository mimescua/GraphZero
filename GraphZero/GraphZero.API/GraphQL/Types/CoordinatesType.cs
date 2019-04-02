using GraphQL.Types;//
using GraphQL.Language.AST;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphZero.API.Data.Entities;//

namespace GraphZero.API.GraphQL.Types
{
    public class CoordinatesType: ScalarGraphType
    {
        public CoordinatesType() => Name = "Coordinates";

        public override object ParseLiteral(IValue value)
        {
            //throw new NotImplementedException();
            if (value is CoordinatesValue coordinatesValue)
                return ParseValue(coordinatesValue.Value);

            return value is StringValue stringValue
                ? ParseValue(stringValue.Value)
                : null;
        }
        public override object ParseValue(object value)
        {
            //throw new NotImplementedException();
            return ValueConverter.ConvertTo(value, typeof(Coordinates));
        }
        public override object Serialize(object value)
        {
            //throw new NotImplementedException();
            return ValueConverter.ConvertTo(value, typeof(Coordinates));
        }
    }
}
