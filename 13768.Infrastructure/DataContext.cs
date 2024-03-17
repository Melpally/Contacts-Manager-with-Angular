using _13768.Domain.Entities;
using _13768.Infrastructure.DataConfigs;
using Microsoft.EntityFrameworkCore;

namespace _13768.Infrastructure;

///  <summary>
/// The class <see cref="DataContext"/> presents database context
/// </summary>
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    /// <summary>s
    /// Gets or sets the DbSet for managing contact entities in the database.
    /// </summary>
    public DbSet<Contact> Contacts { get; set; }

    /// <summary>s
    /// Gets or sets the DbSet for managing team entities in the database.
    /// </summary>
    public DbSet<Team> Teams { get; set; }

    /// <summary>s
    /// Gets or sets the DbSet for managing company entities in the database.
    /// </summary>
    public DbSet<Company> Companies { get; set; }

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfiguration(new TeamConfiguration());
        modelBuilder.ApplyConfiguration(new CompanyConfiguration());
        modelBuilder.ApplyConfiguration(new ContactConfiguration());
    }

    /// <inheritdoc/>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("WAD.Database.13768");
        }
    }
}

