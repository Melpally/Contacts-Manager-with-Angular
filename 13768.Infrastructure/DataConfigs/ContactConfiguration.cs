using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _13768.Infrastructure.DataConfigs
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.HasOne(x => x.Manager)
                .WithMany(x => x.Subordinates)
                .HasForeignKey(x => x.ReportsTo)
                .IsRequired(false);
        }
    }
}
