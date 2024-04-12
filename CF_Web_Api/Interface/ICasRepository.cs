using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface ICasRepository
    {

        ICollection<Ca> GetCas();
         Ca GetCa(Guid Id);
        bool CasExits(Guid Id);
    }
}
