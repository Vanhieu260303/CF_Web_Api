using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IFloorsRepository
    {
        ICollection<Floors> GetFloors();
        Floors GetFloor(Guid id);
        bool FloorsExits (Guid id);
    }
}
