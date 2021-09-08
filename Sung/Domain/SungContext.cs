using Microsoft.EntityFrameworkCore;
using Sung.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.Domain
{
    public class SungContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public DbSet<Author> Authors { get; set; }

        public SungContext(DbContextOptions<SungContext> options) : base(options)
        {
        }
    }
}
