using _13768.Application.Dtos;

namespace _13768.Infrastructure.Repositories
{
    public class CompanyRepository
    {
        protected readonly DataContext _dataContext;

        public CompanyRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateCompany(ContactDto dto)
        {

        }

        public CompanyDto GetCompany(int id)
        {
            var company = new CompanyDto{ Name = "Random" };
            return company;
        }
        public ICollection<CompanyDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void UpdateCompany(CompanyDto company)
        {

        }

        public void DeleteCompany(CompanyDto company)
        {

        }
    }
}
