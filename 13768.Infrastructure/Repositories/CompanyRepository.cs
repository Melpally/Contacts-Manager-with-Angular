using _13768.Application.Dtos;
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
            var company = _dataContext.Companies.FirstOrDefault(x => x.Id == id);
            return company;
        }

        public Task<List<Company>> GetAllAsync()
        {
            return _dataContext.Companies.ToListAsync();
        }

        public void UpdateCompany(int id, CompanyDto company)
        {
            var entity = GetCompany(id);
            
            if (entity != null)
            {
                entity.Website = company.Website;
                entity.Name = company.Name;
            }
            _dataContext.SaveChanges();
            
        }

        public void DeleteCompany(Company company)
        {
            _dataContext.Companies.Remove(company);
            _dataContext.SaveChanges();
        }
    }
}
