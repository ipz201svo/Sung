using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL.Admin
{
    public class AdminMutation : ObjectGraphType
    {
        public AdminMutation()
        {
            Name = "Mutation";
        }
    }
}
