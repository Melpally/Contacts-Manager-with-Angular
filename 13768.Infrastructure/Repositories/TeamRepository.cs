using _13768.Application.Interfaces;
using _13768.Domain.Entities;
using Microsoft.EntityFrameworkCore;

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
            return _dataContext.Teams.Find(id);
        }

        public Task<List<Team>> GetAllAsync()
        {
            return _dataContext.Teams.AsNoTracking().ToListAsync();
        }

        public void Update(Team team)
        {
            _dataContext.Teams.Update(team);
        }

        public void Delete(Team team)
        {
            _dataContext.Teams.Remove(team);
        }
    }
}
