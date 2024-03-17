using _13768.Application.Dtos;

namespace _13768.Infrastructure.Repositories
{
    public class ContactRepository
    {
        protected readonly DataContext _dataContext;

        public ContactRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateContact(ContactDto dto)
        {

        }

        public ContactDto GetContact(int id)
        {
            return new ContactDto();
        }
        public ICollection<ContactDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateContact(ContactDto contact)
        {

        }

        public void DeleteContact(ContactDto contact)
        {

        }
    }
}