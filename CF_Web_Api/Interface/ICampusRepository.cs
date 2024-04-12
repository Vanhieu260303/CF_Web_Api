using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface ICampusRepository
    {
        ICollection<Campus> GetCampuses();
        Campus GetCampus(Guid Id);
        Campus GetCampus(string Name);
        bool CampusExits(Guid Id);
    }
}
