using _13768.Application.Dtos;
using _13768.Domain.Entities;

namespace _13768.Application.Interfaces
{
    public interface ITeamService
    {
        public void Create(TeamDto dto);
        public Team? Get(int id);
        public void Update(int id, TeamDto dto);
        public Task<List<Team>> GetAllAsync();
        public void Delete(int id);
    }
}
