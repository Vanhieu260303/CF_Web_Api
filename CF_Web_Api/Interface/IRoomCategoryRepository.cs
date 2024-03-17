using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IRoomCategoryRepository
    {
       ICollection<RoomsCategory> GetCategories();
        RoomsCategory GetCategory(Guid id);
        bool RoomCategoryExits(Guid id);
    }
}
