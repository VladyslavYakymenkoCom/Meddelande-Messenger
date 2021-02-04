using ME.Data.Models.Abstractions;
using ME.Data.Models.Chats;
using System;
using System.Collections.Generic;

namespace ME.Data.Models.Users
{
    public class User : 
        IEntity,
        ICreateableEntity,
        IUpdateableEntity,
        IDeactivateableEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Tag { get; set; }
        public string HashPassword { get; set; }
        public string Salt { get; set; }
        public bool IsDeactivated { get; set; }

        public DateTime? ActiveAt { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        #region Navigation properties
        public virtual ICollection<UserChat> Chats { get; set; } = new List<UserChat>();
        #endregion
    }
}
