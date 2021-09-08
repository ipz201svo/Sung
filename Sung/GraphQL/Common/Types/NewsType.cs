using GraphQL.Types;
using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL.Common.Types
{
    public class NewsType : ObjectGraphType<News>
    {
        public NewsType()
        {
            Name = "News";
            Description = "A news item";

            Field<NonNullGraphType<GuidGraphType>>()
                .Name("Id")
                .Description("GUID")
                .Resolve(context => context.Source.Id);

            Field<NonNullGraphType<StringGraphType>>()
                .Name("Title")
                .Description("A title of the news")
                .Resolve(context => context.Source.Title);
            
            Field<NonNullGraphType<StringGraphType>>()
                .Name("Subtitle")
                .Description("A subtitle of the news")
                .Resolve(context => context.Source.Subtitle);
            
            Field<NonNullGraphType<StringGraphType>>()
                .Name("Text")
                .Description("A text of the news")
                .Resolve(context => context.Source.Text);

            Field<NonNullGraphType<IdGraphType>>()
                .Name("AuthorId")
                .Description("An author's ID")
                .Resolve(context => context.Source.AuthorId);

            Field<NonNullGraphType<DateGraphType>>()
                .Name("PublishingDate")
                .Description("A date of writing")
                .Resolve(context => context.Source.PublishingDate);

            Field<NonNullGraphType<StringGraphType>>()
                .Name("ImageUrl")
                .Description("A URL of the image of the news")
                .Resolve(context => context.Source.ImageUrl);
        }
    }
}
