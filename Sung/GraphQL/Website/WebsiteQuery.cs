using GraphQL.Types;
using Sung.Domain.Repository;
using Sung.GraphQL.Common.Types;
using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.GraphQL
{
    public class WebsiteQuery : ObjectGraphType
    {
        private INewsRepository _newsRepository;

        public WebsiteQuery(INewsRepository newsRepository)
        {
            _newsRepository = newsRepository;

            Name = "Query";

            Field<SongType>()
                .Name("Song")
                .Resolve(_ => new Song { Id = new Guid(), Name = "Industry baby", AuthorId = new Guid(), Lyrics = "Website" });

            Field<ListGraphType<NewsType>>()
                .Name("NewsList")
                .Resolve(_ => new List<News>
                {
                    new News
                {
                    Id = new Guid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = new Guid(),
                    ImageUrl = "/images/img1"
                },
                new News
                {
                    Id = new Guid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = new Guid(),
                    ImageUrl = "/images/img1"
                },
                new News
                {
                    Id = new Guid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = new Guid(),
                    ImageUrl = "/images/img1"
                },
                new News
                {
                    Id = new Guid(),
                    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                    Subtitle = "“Ye ain’t changin’ sh-t for me, it’s set in stone.”",
                    Text = "Longstanding tensions between Drake and Kanye West appear to have sparked anew this weekend after Drizzy took an apparent shot at ‘Ye on Trippie Redd’s new song, “Betrayal.” Kanye’s longtime collaborator Consequence reacted to the bars on Twitter, while Kanye himself shared a cryptic screenshot of a group text on Instagram.",
                    PublishingDate = new DateTime(2021, 8, 21),
                    AuthorId = new Guid(),
                    ImageUrl = "/images/img1"
                },
                });

            Field<ListGraphType<NewsCardType>>()
                .Name("NewsCardList")
                .Resolve(_ => _newsRepository.GetNews().Select(n => new NewsCard
                {
                    Id = n.Id,
                    Title = n.Title,
                    AuthorId = n.AuthorId,
                    Author = "Chris Mench",
                    PublishingDate = n.PublishingDate,
                    ImageUrl = n.ImageUrl,
                }));
                //new List<NewsCard> {
                //    new NewsCard {
                //    Id = new Guid(),
                //    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                //    PublishingDate = new DateTime(2021, 8, 21),
                //    AuthorId = new Guid(),
                //    Author = "Chris Mench",
                //    ImageUrl = "/images/img1"
                //    },
                //    new NewsCard {
                //    Id = new Guid(),
                //    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                //    PublishingDate = new DateTime(2021, 8, 21),
                //    AuthorId = new Guid(),
                //    Author = "Chris Mench",
                //    ImageUrl = "/images/img1"
                //    },
                //    new NewsCard {
                //    Id = new Guid(),
                //    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                //    PublishingDate = new DateTime(2021, 8, 21),
                //    AuthorId = new Guid(),
                //    Author = "Chris Mench",
                //    ImageUrl = "/images/img1"
                //    },
                //    new NewsCard {
                //    Id = new Guid(),
                //    Title = "Tensions Flare Between Drake & Kanye West After Apparent Diss On Trippie Redd’s “Betrayal”",
                //    PublishingDate = new DateTime(2021, 8, 21),
                //    AuthorId = new Guid(),
                //    Author = "Chris Mench",
                //    ImageUrl = "/images/img1"
                //    },
                //});
        }
    }
}
