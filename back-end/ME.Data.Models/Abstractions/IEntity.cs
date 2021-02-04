using System;

namespace ME.Data.Models.Abstractions
{
    public interface IEntity
    {
        public Guid Id { get; set; }
    }
}
