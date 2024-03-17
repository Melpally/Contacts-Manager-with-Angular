using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace _13768.Infrastructure.DataConfigs
{
    public class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.Property(x => x.Id)
                .UseIdentityColumn()
                .IsRequired();

            builder.HasMany<Contact>()
                .WithOne()
                .HasForeignKey(x => x.TeamId)
                .IsRequired();
        }
    }
}
