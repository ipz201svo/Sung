using GraphQL.Types;
using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL.Types
{
    public class EntityType : ObjectGraphType<Entity>
    {
        public EntityType()
        {
            Name = "Enity";
            Description = "Parent type for all entities";

            Field<IdGraphType>()
                .Name("Id")
                .Description("Identification number")
                .Resolve(context => context.Source.Id);
        }
    }
}
