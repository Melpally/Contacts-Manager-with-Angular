using _13768.Application.Dtos;
using _13768.Domain.Entities;

namespace _13768.Application.Interfaces
{
    public interface IContactService
    {
        public void CreateContact(ContactDto contact);
        public Contact? GetContact(int id);
        public void UpdateContact(int id, ContactDto contact);
        public Task<List<Contact>> GetAllAsync();
        public Task<List<Contact>> GetAllManagers();
        public void DeleteContact(int id);
    }
}
