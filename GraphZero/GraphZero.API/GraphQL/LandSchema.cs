using GraphQL;
using GraphQL.Types;
using GraphZero.API.Data.Entities;//
using System;//

namespace GraphZero.API.GraphQL
{
    public class LandSchema: Schema
    {
        public LandSchema(IDependencyResolver resolver): base(resolver)
        {
            //ValueConverter.Register(typeof(string), typeof(Coordinates) ParseCoordinates);
            ValueConverter.Register(typeof(string), typeof(Coordinates), ParseCoordinates);
            this.RegisterValueConverter(new CoordinatesAstValueConverter());
            Query = resolver.Resolve<LandQuery>();
        }

        private object ParseCoordinates(object CoordinatesInput)
        {
            try
            {
                var CoordinatesInputString = (string)CoordinatesInput;
                //var CoordinatesParts = CoordinatesInputString.Split(',');
                //var x = float.Parse(CoordinatesParts[0]);
                //var y = float.Parse(CoordinatesParts[1]);
                //var z = float.Parse(CoordinatesParts[2]);
                //return new Coordinates(x, y, z);
                //return new[] { myString };
                return new[] { CoordinatesInputString };

                /*var conversion = GetConversion(valueType, targetType);
                ValueConverter.Register(
                  typeof(long),
                  typeof(double),
                  value => Convert.ToDouble((long)value, NumberFormatInfo.InvariantInfo));*/
            }
            catch
            {
                throw new FormatException($"Failed to parse {nameof(Coordinates)} from input '{CoordinatesInput}'. Input should be an array");
            }
        }
    }
}
