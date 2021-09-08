using GraphQL.Types;
using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL
{
    public class SongType : ObjectGraphType<Song>
    {
        public SongType()
        {
            Name = "Song";
            Description = "Song from database";

            Field<NonNullGraphType<GuidGraphType>>()
                .Name("Id")
                .Resolve(context => context.Source.Id);

            Field<NonNullGraphType<StringGraphType>>()
                .Name("Name")
                .Resolve(context => context.Source.Name);

            Field<StringGraphType>()
                .Name("Lyrics")
                .Resolve(context => context.Source.Lyrics);
        }
    }
}
