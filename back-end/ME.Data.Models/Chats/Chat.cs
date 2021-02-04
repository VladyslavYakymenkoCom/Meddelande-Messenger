using ME.Data.Models.Messages;
using System;
using System.Collections.Generic;

namespace ME.Data.Models.Chats
{
    public class Chat : 
        Abstractions.IEntity,
        Abstractions.ICreateableEntity,
        Abstractions.IUpdateableEntity,
        Abstractions.IDeactivateableEntity
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Title { get; set; }
        public bool IsDeactivated { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime? UpdatedAt { get; set; }

        #region Navigation properties
        public virtual ICollection<Message> Messages { get; set; } = new List<Message>();
        public virtual ICollection<UserChat> Participants { get; set; } = new List<UserChat>();
        #endregion
    }
}
