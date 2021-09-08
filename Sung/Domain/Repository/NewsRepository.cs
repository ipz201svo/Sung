using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.Domain.Repository
{
    public class NewsRepository : INewsRepository
    {
        private List<News> news;

        public NewsRepository()
        {
            news = new List<News>
            {
                new News
                {
                    Id = Guid.NewGuid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = Guid.NewGuid(),
                    ImageUrl = "/images/img1"
                },
                new News
                {
                    Id = Guid.NewGuid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = Guid.NewGuid(),
                    ImageUrl = "/images/img1"
                },
                new News
                {
                    Id = Guid.NewGuid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = Guid.NewGuid(),
                    ImageUrl = "/images/img1"
                },
                new News
                {
                    Id = Guid.NewGuid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = Guid.NewGuid(),
                    ImageUrl = "/images/img1"
                },
            };
        }

        public News GetNews(Guid id)
        {
            return news.First(n => n.Id == id);
        }

        public IEnumerable<News> GetNews()
        {
            return news;
        }
    }
}
