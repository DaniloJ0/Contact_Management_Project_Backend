using ContactManagement.Domain.Contacts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ContactManagement.Infrastructure.Configurations
{
    internal class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id).HasConversion(
            customerId => customerId.Value,
                value => new ContactId(value));

            builder.Property(c => c.Name).HasMaxLength(100).IsRequired();
            builder.Property(c => c.Email).HasMaxLength(50).IsRequired();
            builder.Property(c => c.PhoneNumber).HasMaxLength(15).IsRequired();
            builder.Property(c => c.Address).HasMaxLength(50);
            builder.Property(c => c.Company).HasMaxLength(25);
            builder.Property(c => c.Note).HasMaxLength(150);
        }
    }
}
