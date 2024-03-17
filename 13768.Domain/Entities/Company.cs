namespace _13768.Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public sealed class Company
    {
        /// <summary>
        /// Defines the unique identifier of the company entity
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Defines the name of the company
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Defines the website of the company
        /// </summary>
        public string? Website { get; set; }

    }
}
