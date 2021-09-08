using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.Domain.Repository
{
    public interface INewsRepository
    {
        public News GetNews(Guid id);

        public IEnumerable<News> GetNews();
    }
}
