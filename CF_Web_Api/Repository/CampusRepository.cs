using CF_Web_Api.Data;
using CF_Web_Api.Interface;
using System.Xml.Linq;

namespace CF_Web_Api.Repository
{
    public class CampusRepository : ICampusRepository
    {
        private readonly DataContext _dbcontext;

        public CampusRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public bool CampusExits(Guid Id)
        {
           return _dbcontext.Campuses.Any(c => c.Id == Id);
        }

        public Campus GetCampus(Guid Id)
        {
            return _dbcontext.Campuses.Where(c => c.Id == Id).FirstOrDefault();
        }

        public Campus GetCampus(string Name)
        {
            return _dbcontext.Campuses.Where(c => c.CampusName == Name).FirstOrDefault();
        }

      
        public ICollection<Campus> GetCampuses()
        {
            return _dbcontext.Campuses.ToList();
        }
    }
}
