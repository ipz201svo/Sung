using GraphQL.Types;
using Microsoft.Extensions.DependencyInjection;
using Sung.GraphQL.Admin;
using Sung.GraphQL.Common.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL
{
    public static class ExtendedGraphQLDI
    {
        public static IServiceCollection AddGraphTypes(this IServiceCollection services)
        {
            //Admin
            services.AddScoped<AdminSchema>();
            services.AddScoped<AdminQuery>();
            //services.AddSingleton<AdminMutation>();

            //Website
            services.AddScoped<WebsiteSchema>();
            services.AddScoped<WebsiteQuery>();
            //services.AddSingleton<WebsiteMutation>();

            //Common
            services.AddScoped<SongType>();
            services.AddScoped<NewsType>();
            services.AddScoped<NewsCardType>();

            return services;
        }
    }
}
