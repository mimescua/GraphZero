using GraphQL.Types;

namespace GraphZero.API.GraphQL.Types
{
    public class ProductTypeEnumType: EnumerationGraphType<Data.ProductType>
    {
        public ProductTypeEnumType()
        {
            Name = "Type";
            Description = "The type of product";
        }
    }
}
