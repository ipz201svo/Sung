using System;

namespace Sung.Models
{
    public class News : Entity
    {
        public string Title { get; set; }

        public string Subtitle { get; set; }

        public string Text { get; set; }

        public Guid AuthorId { get; set; }

        public DateTime PublishingDate { get; set; }

        public string ImageUrl { get; set; }

    }
}
