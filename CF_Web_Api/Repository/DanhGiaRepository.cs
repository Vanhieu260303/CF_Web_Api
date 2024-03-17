using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class DanhGiaRepository : IDanhGiaRepository
    {
        private readonly DataContext _dbcontext;
        public DanhGiaRepository(DataContext dbcontext)
        {
            _dbcontext = dbcontext;
        }

        public bool DanhGiaExits(Guid Id)
        {
            return _dbcontext.DanhGia.Any(d=>d.Id==Id);
        }

        public DanhGia GetDanhGia(Guid Id)
        {
            return _dbcontext.DanhGia.Where(d=>d.Id==Id).FirstOrDefault();
        }

        public ICollection<DanhGia> GetDanhGias()
        {
           return _dbcontext.DanhGia.ToList();
        }
    }
}
