using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using _13768.Domain.Entities;

namespace _13768.Application.Services
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _repository;

        public TeamService(ITeamRepository teamRepository)
        {
            _repository = teamRepository;   
        }

        public void Create(TeamDto dto)
        {
            var team = new Team { 
                CompanyId = dto.CompanyId,
                Name = dto.Name
            };
            _repository.Create(team);
        }

        public Team? Get(int id)
        {
            return _repository.Get(id);
        }

        public Task<List<Team>> GetAllAsync()
        {
            return _repository.GetAllAsync();
        }

        public void Update(int id, TeamDto dto)
        {
            throw new NotImplementedException();
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
