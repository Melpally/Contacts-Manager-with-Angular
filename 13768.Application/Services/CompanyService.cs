using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using _13768.Domain.Entities;

namespace _13768.Application.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        public CompanyService(ICompanyRepository companyRepository) 
        {
            _companyRepository = companyRepository;
        }

        public void CreateCompany(CompanyDto company)
        {
            var entity = new Company {
                Name = company.Name,
                Website = company.Website};
            
            _companyRepository.CreateCompany(entity);
        }

        public void DeleteCompany(int id)
        {
            var company = _companyRepository.GetCompany(id);

            if (company != null)
            {
                _companyRepository.DeleteCompany(company);
            }
        }

        public Task<List<Company>> GetAllAsync()
        {
            return _companyRepository.GetAllAsync();
        }

        public Company? GetCompany(int id)
        {
            return _companyRepository.GetCompany(id);
        }

        public void UpdateCompany(int id, CompanyDto dto)
        {
            _companyRepository.UpdateCompany(id, dto);
            
        }
    }
}
