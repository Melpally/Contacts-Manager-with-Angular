using _13768.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13768.Application.Interfaces
{
    public interface ITeamRepository
    {
        public void Create(Team team);
        public Team? Get(int id);
        public void Update(Team team);
        public Task<List<Team>> GetAllAsync();
        public void Delete(Team team);
    }
}
