using _13768.Application.Dtos;
using _13768.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13768.Application.Interfaces
{
    public interface ICompanyRepository
    {
        public void CreateCompany(Company company);
        public Company? GetCompany(int id);
        public Task<List<Company>> GetAllAsync();
        public void UpdateCompany(int id, CompanyDto company);
        public void DeleteCompany(Company company);

    }
}
