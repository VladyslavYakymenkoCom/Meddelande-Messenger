using System;

namespace ME.Data.Models.Abstractions
{
    public interface ICreateableEntity
    {
        public DateTime CreatedAt { get; set; }
    }
}
