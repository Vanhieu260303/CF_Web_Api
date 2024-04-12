using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IFormDanhGiaRepository
    {
        ICollection<FormDanhGia> GetFormDGs();
        FormDanhGia GetFormDG(Guid Id);
        bool FormDanhGiaExits(Guid Id);
    }
}
