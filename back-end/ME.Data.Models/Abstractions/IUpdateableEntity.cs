using System;

namespace ME.Data.Models.Abstractions
{
    public interface IUpdateableEntity
    {
        public DateTime? UpdatedAt { get; set; }
    }
}
