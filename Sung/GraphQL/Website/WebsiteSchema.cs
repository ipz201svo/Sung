using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL
{
    public class WebsiteSchema : Schema
    {
        public WebsiteSchema(IServiceProvider provider)
            : base(provider)
        {
            Query = provider.GetRequiredService<WebsiteQuery>();
            //Mutation = provider.GetRequiredService<WebsiteMutation>();
        }
    }
}
