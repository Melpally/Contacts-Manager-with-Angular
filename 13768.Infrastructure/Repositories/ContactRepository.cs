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
            return _dataContext.Contacts.Find(id);
        }

        //TODO: add pagination maybe>>>

        /// <summary>
        /// Retrieves all of the entities from the database. 
        /// </summary>
        /// <returns></returns>
        public Task<List<Contact>> GetAllAsync()
        {
            return _dataContext.Contacts.AsNoTracking().ToListAsync(); 
        }

        /// <summary>
        /// Updates the record in the database.
        /// </summary>
        /// <param name="contact">The updated entity of type <see cref="Contact"/></param>
        public void UpdateContact(Contact contact)
        {
            _dataContext.Contacts.Update(contact);
        }

        /// <summary>
        /// Deletes the record in the database.
        /// </summary>
        /// <param name="contact"></param>
        public void DeleteContact(Contact contact)
        {
            _dataContext.Contacts.Remove(contact);
        }
    }
}