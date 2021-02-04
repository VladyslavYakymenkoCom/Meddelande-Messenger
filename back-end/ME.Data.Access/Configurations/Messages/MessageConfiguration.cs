using ME.Data.Models.Messages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ME.Data.Access.Configurations.Chats
{
    public class MessageConfiguration : Base.Configuration, IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Body)
                .HasMaxLength(MaxBodyLength)
                .IsRequired();
            builder.Property(m => m.CreatedAt).IsRequired();

            builder.HasOne(m => m.Author)
                .WithMany()
                .HasForeignKey(m => m.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
