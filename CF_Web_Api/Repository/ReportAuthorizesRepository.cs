using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class ReportAuthorizesRepository : IReportAuthorizesRepository
    {
        private readonly DataContext _dbcontext;
        public ReportAuthorizesRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public ReportAuthorize GetReportAuthorize(Guid Id)
        {
            return _dbcontext.ReportAuthorizes.Where(r=>r.IdForm==Id).FirstOrDefault();
        }

        public ICollection<ReportAuthorize> GetReportAuthorizes()   
        {
            return _dbcontext.ReportAuthorizes.ToList();
        }

        public bool ReportAuthorizeExits(Guid Id)
        {
            return _dbcontext.ReportAuthorizes.Any(r => r.IdForm == Id);
        }
    }
}
