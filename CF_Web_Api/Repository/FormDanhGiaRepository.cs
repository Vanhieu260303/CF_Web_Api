using CF_Web_Api.Data;
using CF_Web_Api.Interface;

namespace CF_Web_Api.Repository
{
    public class FormDanhGiaRepository : IFormDanhGiaRepository
    {
        private readonly DataContext _dataContext;
        public FormDanhGiaRepository (DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public bool FormDanhGiaExits(Guid Id)
        {
            return _dataContext.FormDanhGia.Any(f => f.Id == Id);
        }

        public FormDanhGia GetFormDG(Guid Id)
        {
            return _dataContext.FormDanhGia.Where(f=>f.Id==Id).FirstOrDefault();
        }

        public ICollection<FormDanhGia> GetFormDGs()
        {
            return _dataContext.FormDanhGia.ToList();
        }
    }
}
