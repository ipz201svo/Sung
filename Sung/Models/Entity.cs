using Sung.Models.Interfaces;
using System;

namespace Sung.Models
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }

    }
}