namespace _13768.Domain.Entities
{
    public sealed class Team
    {
        public int Id { get; set; }
        public required string Name { get; set; }

        /// <summary>
        /// Defines the collection navigation containing dependents for <see cref="Contact"/>.
        /// </summary>
        public ICollection<Contact> Contacts { get; } = new List<Contact>();

        public int CompanyId { get; set; }

        public Company Company { get; set; } = null!;

        //public int ManagerId { get; set; }
    }
}
