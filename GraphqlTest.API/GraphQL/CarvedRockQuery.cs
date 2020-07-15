using GraphQL.Types;
using GraphqlTest.API.GraphQL.Types;
using GraphqlTest.API.Repositories;

namespace GraphqlTest.API.GraphQL
{
    public class CarvedRockQuery: ObjectGraphType
    {
        public CarvedRockQuery(ProductRepository productRepository)
        {
            Field<ListGraphType<ProductType>>(
                "products", 
                resolve: context => productRepository.GetAll()
            );
        }
    }
}
