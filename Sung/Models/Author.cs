using Sung.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sung.Models
{
    public class Author : Entity, IAuthor
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
