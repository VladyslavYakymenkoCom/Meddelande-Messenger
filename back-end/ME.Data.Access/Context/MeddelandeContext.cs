using ME.Data.Models.Chats;
using ME.Data.Models.Messages;
using ME.Data.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace ME.Data.Access.Context
{
    public class MeddelandeContext : DbContext
    {
        public MeddelandeContext()
        {
            Database.EnsureCreated();
        }

        #region User
        public DbSet<User> Users { get; set; }
        #endregion

        #region Message
        public DbSet<Message> Messages { get; set; }
        #endregion

        #region Chat
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserChat> UserChats { get; set; }
        #endregion
    }
}
