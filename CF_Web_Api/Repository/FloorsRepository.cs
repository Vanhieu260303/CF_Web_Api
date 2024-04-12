using CF_Web_Api.Data;
using CF_Web_Api.Interface;
using Microsoft.EntityFrameworkCore;

namespace CF_Web_Api.Repository
{
    public class FloorsRepository : IFloorsRepository
    {
        private readonly DataContext _dbcontext;

        public FloorsRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool FloorsExits(Guid id)
        {
            return _dbcontext.Floors.Any(f => f.Id == id);
        }

        public Floors GetFloor(Guid id)
        {
            return _dbcontext.Floors.Where(f => f.Id == id).FirstOrDefault();
        }

        public ICollection<Floors> GetFloors()
        {
            return _dbcontext.Floors.ToList();
        }
    }
}
