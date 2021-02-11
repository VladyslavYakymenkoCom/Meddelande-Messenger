using ME.Data.Models.Chats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ME.Data.Access.Configurations.Chats
{
    public class UserChatConfiguration : Base.Configuration, IEntityTypeConfiguration<UserChat>
    {
        public void Configure(EntityTypeBuilder<UserChat> builder)
        {
            builder.HasKey(uch => new { uch.UserId, uch.ChatId });

            builder.HasOne(m => m.User)
                .WithMany(u => u.Chats)
                .HasForeignKey(m => m.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(m => m.Chat)
                .WithMany(ch => ch.Participants)
                .HasForeignKey(m => m.ChatId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
