using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class RoomsCategoryRepository : IRoomCategoryRepository
    {
        private readonly DataContext _dbcontext;
        public RoomsCategoryRepository (DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public ICollection<RoomsCategory> GetCategories()
        {
           return _dbcontext.RoomCategories.ToList();
        }

        public RoomsCategory GetCategory(Guid id)
        {
            return _dbcontext.RoomCategories.Where(r => r.Id == id).FirstOrDefault();
        }

        public bool RoomCategoryExits(Guid id)
        {
           return _dbcontext.RoomCategories.Any(r=>r.Id==id);
        }
    }
}
