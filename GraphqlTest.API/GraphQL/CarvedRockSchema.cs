using GraphQL;
using GraphQL.Types;

namespace GraphqlTest.API.GraphQL
{
    public class CarvedRockSchema: Schema
    {
        public CarvedRockSchema(IDependencyResolver resolver): base(resolver)
        {           
            Query = resolver.Resolve<CarvedRockQuery>();
        }
    }
}
