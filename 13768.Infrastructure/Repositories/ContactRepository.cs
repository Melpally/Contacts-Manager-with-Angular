using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _13768.Infrastructure.Repositories
{
    public class ContactRepository : IContactRepository
    {
        protected readonly DataContext _dataContext;

        public ContactRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        /// <summary>
        /// Creates the contact entity.
        /// </summary>
        /// <param name="contact"></param>
        public void CreateContact(Contact contact)
        {
            _dataContext.Contacts.Add(contact);
            _dataContext.SaveChanges();
        }

        /// <summary>
        /// Gets the contact entity by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Contact? GetContact(int id)
        {
            return _dataContext.Contacts.FirstOrDefault(x => x.Id == id);
        }

        /// <summary>
        /// Retrieves all of the entities from the database. 
        /// </summary>
        /// <returns></returns>
        public Task<List<Contact>> GetAllAsync()
        {
            return _dataContext.Contacts.ToListAsync(); 
        }

        public Task<List<Contact>> GetAllManagersAsync()
        {
            return _dataContext.Contacts
                .Where(x => x.IsManager == true)
                .ToListAsync();
        }

        /// <summary>
        /// Updates the record in the database.
        /// </summary>
        /// <param name="contact">The updated entity of type <see cref="Contact"/></param>
        public void UpdateContact(int id, ContactDto dto)
        {
            var entity = GetContact(id);

            if (entity != null)
            {
                entity.Name = dto.Name;
                entity.Email = dto.Email;
                entity.Notes = dto.Notes;
                entity.Phone = dto.Phone;
                entity.TeamId = dto.TeamId;
                entity.IsManager = dto.IsManager;
                entity.Avatar = dto.Avatar;
                entity.Address = dto.Address;
                entity.JobTitle = dto.JobTitle;
                entity.ReportsTo = dto.ReportsTo;
                entity.DateOfBirth = dto.DateOfBirth;

            }
            _dataContext.SaveChanges();
        }

        /// <summary>
        /// Deletes the record in the database.
        /// </summary>
        /// <param name="contact"></param>
        public void DeleteContact(Contact contact)
        {
            _dataContext.Contacts.Remove(contact);
            _dataContext.SaveChanges();
        }
    }
}