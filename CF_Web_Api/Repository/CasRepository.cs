using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class CasRepository : ICasRepository
    {
        private readonly DataContext _dbcontext;
        
        public CasRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public bool CasExits(Guid Id)
        {
            return _dbcontext.Cas.Any(c => c.Id == Id);
        }

        public ICollection<Ca> GetCas()
        {
            return _dbcontext.Cas.ToList();
        }

        public Ca GetCa(Guid Id)
        {
            return _dbcontext.Cas.Where(c=> c.Id==Id).FirstOrDefault();
        }
    }
}
