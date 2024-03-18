using _13768.Domain.Entities;

namespace _13768.Application.Interfaces
{
    public interface IContactRepository
    {
        public void CreateContact(Contact contact);
        public Contact? GetContact(int id);
        public void UpdateContact(Contact contact);
        public Task<List<Contact>> GetAllAsync();
        public void DeleteContact(Contact contact);

    }
}
