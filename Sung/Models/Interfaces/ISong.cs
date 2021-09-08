using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.Models
{
    public interface ISong
    {
        public string Name { get; set; }

        public string Lyrics { get; set; }

        public Guid AuthorId { get; set; }

    }
}
