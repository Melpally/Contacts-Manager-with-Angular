using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _13768.Infrastructure.Repositories
{
    public class ContactRepository
    {
        protected readonly DataContext _dataContext;

        public ContactRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

    }
}
