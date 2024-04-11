using ContactManagement.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactManagement.Infrastructure.Configurations
{
    internal class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasConversion(
            userId => userId.Value,
                value => new UserId(value));

            builder.Property(u => u.Name).HasMaxLength(50);
            builder.Property(u => u.Password).HasMaxLength(50);
            builder.Property(u => u.Email).HasMaxLength(50);
        }
    }
}
