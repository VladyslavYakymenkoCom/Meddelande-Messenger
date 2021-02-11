using ME.Data.Models.Chats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ME.Data.Access.Configurations.Chats
{
    public class ChatConfiguration : Base.Configuration, IEntityTypeConfiguration<Chat>
    {
        public void Configure(EntityTypeBuilder<Chat> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Title)
                .HasMaxLength(MaxTitleLength)
                .IsRequired();
            builder.Property(u => u.CreatedAt).IsRequired();
        }
    }
}
