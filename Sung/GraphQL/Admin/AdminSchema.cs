using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL.Admin
{
    public class AdminSchema : Schema
    {
        public AdminSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<AdminQuery>();
            //Mutation = provider.GetRequiredService<AdminMutation>();
        }
    }
}
