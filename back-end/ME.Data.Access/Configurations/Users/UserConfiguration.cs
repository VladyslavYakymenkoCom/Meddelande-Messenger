using ME.Data.Models.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ME.Data.Access.Configurations.Users
{
    public class UserConfiguration : Base.Configuration, IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Tag)
                .HasMaxLength(MaxTagLength)
                .IsRequired();
            builder.Property(u => u.HashPassword)
               .HasMaxLength(MaxHashLength)
               .IsRequired();
            builder.Property(u => u.Tag)
                .HasMaxLength(MaxSaltLength)
                .IsRequired();
            builder.Property(u => u.CreatedAt).IsRequired();
        }
    }
}
