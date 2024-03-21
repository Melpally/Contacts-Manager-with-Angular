using _13768.Application.Dtos;
using _13768.Domain.Entities;

namespace _13768.Application.Interfaces
{
    public interface ITeamRepository
    {
        public void Create(Team team);
        public Team? Get(int id);
        public void Update(int id, TeamDto team);
        public Task<List<Team>> GetAllAsync();
        public void Delete(Team team);
    }
}
