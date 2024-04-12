using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IRoomsRepository
    {
        ICollection<Rooms> GetRooms();
        Rooms GetRoom(Guid Id);
        bool  RoomsExist(Guid Id);
    }
}
