using GraphQL.Language.AST;//
using GraphZero.API.Data.Entities;//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphZero.API.GraphQL
{
    public class CoordinatesValue: ValueNode<Coordinates>
    {
        public CoordinatesValue(Coordinates value)
        {
            Value = value;
        }

        protected override bool Equals(ValueNode<Coordinates> node)
        {
            return Value.Equals(node.Value);
        }
    }
}
