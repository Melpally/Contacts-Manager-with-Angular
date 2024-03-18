using _13768.Application.Dtos;
using _13768.Domain.Entities;

namespace _13768.Application.Interfaces
{
    public interface ICompanyService
    {
        public void CreateCompany(CompanyDto company);
        public Company? GetCompany(int id);
        public Task<List<Company>> GetAllAsync();
        public void UpdateCompany(int id, CompanyDto company);
        public void DeleteCompany(int id);
    }
}
