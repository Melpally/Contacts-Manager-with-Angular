using _13768.Application.Dtos;

namespace _13768.Infrastructure.Repositories
{
    public class TeamRepository
    {
        protected readonly DataContext _dataContext;

        public TeamRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void Create(TeamDto dto)
        {

        }

        public TeamDto Get(int id)
        {
            throw new NotImplementedException();
        }
        public ICollection<TeamDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(TeamDto dto)
        {

        }

        public void Delete(TeamDto dto)
        {

        }
    }
}
