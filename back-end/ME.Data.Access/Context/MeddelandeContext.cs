using ME.Data.Models.Chats;
using ME.Data.Models.Messages;
using ME.Data.Models.Users;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ME.Data.Access.Context
{
    public sealed class MeddelandeContext : DbContext
    {
        public MeddelandeContext(DbContextOptions<MeddelandeContext> options) : base(options)
        {
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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
