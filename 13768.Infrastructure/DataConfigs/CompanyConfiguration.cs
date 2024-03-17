using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _13768.Infrastructure.DataConfigs
{
    public class CompanyConfiguration : IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.HasMany<Team>()
                .WithOne()
                .HasForeignKey(x => x.CompanyId)
                .IsRequired();
        }
    }
}
