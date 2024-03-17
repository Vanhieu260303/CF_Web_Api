using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class RoomsRepository : IRoomsRepository
    {
        private readonly DataContext _dbcontext;
        public RoomsRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public Rooms GetRoom(Guid Id)
        {
            return _dbcontext.Rooms.Where(r => r.Id == Id).FirstOrDefault();
        }

        public ICollection<Rooms> GetRooms()
        {
            return _dbcontext.Rooms.ToList();
        }

        public bool RoomsExist(Guid Id)
        {
            return _dbcontext.Rooms.Any(r=>r.Id==Id);
        }
    }
}
