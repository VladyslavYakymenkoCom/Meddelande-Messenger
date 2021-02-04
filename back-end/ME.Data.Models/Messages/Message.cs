using ME.Data.Models.Users;
using System;
using System.Collections.Generic;

namespace ME.Data.Models.Messages
{
    public class Message :
        Abstractions.IEntity,
        Abstractions.ICreateableEntity,
        Abstractions.IUpdateableEntity,
        Abstractions.IDeactivateableEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid AuthotId { get; set; }

        public string Body { get; set; }
        public int State { get; set; }
        public bool IsDeactivated { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        #region Navigation properties
        public virtual User Author { get; set; }
        #endregion
    }
}
