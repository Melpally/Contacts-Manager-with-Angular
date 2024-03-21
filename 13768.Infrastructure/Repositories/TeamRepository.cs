using _13768.Application.Dtos;
using _13768.Application.Interfaces;
using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace _13768.Infrastructure.Repositories
{
    public class TeamRepository : ITeamRepository
    {
        protected readonly DataContext _dataContext;

        public TeamRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(Team team)
        {
            _dataContext.Teams.Add(team);
            _dataContext.SaveChanges();
        }

        public Team? Get(int id)
        {
            return _dataContext.Teams.FirstOrDefault(x => x.Id == id);
        }

        public Task<List<Team>> GetAllAsync()
        {
            return _dataContext.Teams.ToListAsync();
        }

        public void Update(int id, TeamDto team)
        {
            var entity = Get(id);

            if (entity != null)
            {
                entity.CompanyId = team.CompanyId;
                entity.Name = team.Name;
            }
            _dataContext.SaveChanges();
        }

        public void Delete(Team team)
        {
            _dataContext.Teams.Remove(team);
            _dataContext.SaveChanges();
        }
    }
}
