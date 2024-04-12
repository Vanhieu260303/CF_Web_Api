using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class ReportDanhGiaRepository : IReportDanhGiaRepository
    {
        private readonly DataContext _dbcontext;
        public ReportDanhGiaRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public ReportDanhGia GetReportDanhGia(Guid Id)
        {
            return _dbcontext.ReportDanhGia.Where(r=>r.Id==Id).FirstOrDefault();
        }

        public ICollection<ReportDanhGia> GetReportDanhGias()
        {
           return _dbcontext.ReportDanhGia.ToList();
        }

        public bool ReportDanhGiaExits(Guid Id)
        {
            return _dbcontext.ReportDanhGia.Any(r=>r.Id==Id);
        }
    }
}
