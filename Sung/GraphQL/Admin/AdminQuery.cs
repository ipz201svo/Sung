using GraphQL.Types;
using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL.Admin
{
    public class AdminQuery : ObjectGraphType
    {
        public AdminQuery()
        {
            Name = "Query";

            Field<SongType>()
                .Name("Song")
                .Resolve(_ => new Song { Id = new Guid(), Name = "Industry baby", AuthorId = new Guid(), Lyrics = "Admin" });
        }
    }
}
