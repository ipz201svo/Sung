using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.Models
{
    public class NewsCard
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public Guid AuthorId { get; set; }

        public string Author { get; set; }

        public DateTime PublishingDate { get; set; }

        public string ImageUrl { get; set; }
    }
}
