namespace _13768.Domain.Entities
{
    public sealed class Contact
    {
        /// <summary>
        /// The unique identifier of the 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Defines the avatar image of the contact to display.
        /// </summary>
        public string? Avatar { get; set; }

        /// <summary>
        /// Defines the email address of the contact.
        /// </summary>
        public string? Email { get; set; }

        /// <summary>
        /// Defines the phone number property of the contact.
        /// </summary>
        public string? Phone { get; set; }

        /// <summary>
        /// Defines the notes for the contact to store additional details about the contact.
        /// </summary>
        public string? Notes { get; set; }

        /// <summary>
        /// Defines the address of the contact.
        /// </summary>
        public string? Address { get; set; }

        /// <summary>
        /// Defines the title of the job of the contact.
        /// </summary>
        public string? JobTitle { get; set; }

        /// <summary>
        /// Defines the name of the contact.
        /// </summary>
        public required string Name { get; set; }

        /// <summary>
        /// Defines the date of birth of the contact.
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        //TODO: configure using the configure using entity type configuration

        /// <summary>
        /// Defines the required foreign key property for the <see cref="Team"/> attribute.
        /// </summary>
        public int TeamId { get; set; }

        /// <summary>
        /// Defines the required reference navigation to principal.
        /// </summary>
        public Team Team { get; set; } = null!;

        /// <summary>
        /// Defines optional foreign key property of the manager attribute.
        /// </summary>
        public int? ReportsTo { get; set; }

        /// <summary>
        /// Defines the optional reference navigation to principal of type <see cref="Contact"/>.
        /// </summary>
        public Contact? Manager { get; set; }

        /// <summary>
        /// Defines collection navigation containing dependents of the manager to employees.
        /// </summary>
        public ICollection<Contact> Reports { get; } = new List<Contact>();

    }
}
