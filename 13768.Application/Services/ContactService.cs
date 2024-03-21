using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using _13768.Domain.Entities;

namespace _13768.Application.Services
{
    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
              _contactRepository = contactRepository;
        }

        public void CreateContact(ContactDto contact)
        {
            var entity = new Contact
            {
                Name = contact.Name,
                Email = contact.Email,
                Notes = contact.Notes,
                Phone = contact.Phone,
                TeamId = contact.TeamId,
                Avatar = contact.Avatar,
                Address = contact.Address,
                JobTitle = contact.JobTitle,
                IsManager = contact.IsManager,
                ReportsTo = contact.ReportsTo,
                DateOfBirth = contact.DateOfBirth
            };

            _contactRepository.CreateContact(entity);

        }

        public void DeleteContact(int id)
        {
            var contact = _contactRepository.GetContact(id);

            if (contact != null)
            {
                _contactRepository.DeleteContact(contact);
            }
        }

        public Task<List<Contact>> GetAllAsync()
        {
            return _contactRepository.GetAllAsync();
        }

        public Task<List<Contact>> GetAllManagers()
        {
            return _contactRepository.GetAllManagersAsync();
        }

        public Contact? GetContact(int id)
        {
            return _contactRepository.GetContact(id);
        }

        public void UpdateContact(int id, ContactDto dto)
        {
            _contactRepository.UpdateContact(id, dto);
            
        }
    }
}
