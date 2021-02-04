using ME.Data.Models.Users;
using System;

namespace ME.Data.Models.Chats
{
    public class UserChat
    {
        public Guid UserId { get; set; }
        public Guid ChatId { get; set; }

        #region Navigation properties
        public virtual User User { get; set; }
        public virtual Chat Chat { get; set; }
        #endregion
    }
}
