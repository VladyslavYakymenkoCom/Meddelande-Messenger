using ME.Data.Models.Chats;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ME.Data.Access.Configurations
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

            builder.HasOne(m => m.Messages)
                .WithMany()
                .HasForeignKey(m => m.Id)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
