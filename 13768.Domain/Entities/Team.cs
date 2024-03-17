namespace _13768.Domain.Entities
{
    public sealed class Team
    {
        /// <summary>
        /// Defines the unique identifier of the entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Defines the department or team name
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Defines the company foreign key for the team
        /// </summary>
        public int CompanyId { get; set; }
    }
}
