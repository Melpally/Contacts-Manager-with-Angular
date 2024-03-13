namespace _13768.Domain.Entities
{
    public sealed class Company
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public string? Website { get; set; }

        public ICollection<Team> Teams { get; } = new List<Team>();
    }
}
