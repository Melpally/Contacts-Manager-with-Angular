using _13768.Application.Interfaces;
using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace _13768.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        protected readonly DataContext _dataContext;

        public CompanyRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void CreateCompany(Company company)
        {
            _dataContext.Companies.Add(company);
            _dataContext.SaveChanges();
        }

        public Company? GetCompany(int id)
        {
            return _dataContext.Companies.Find(id);
        }

        public Task<List<Company>> GetAllAsync()
        {
            return _dataContext.Companies.AsNoTracking().ToListAsync();
        }

        public void UpdateCompany(Company company)
        {
            _dataContext.Companies.Update(company);
        }

        public void DeleteCompany(Company company)
        {
            _dataContext.Companies.Remove(company);
        }
    }
}
