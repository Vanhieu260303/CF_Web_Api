using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IDanhGiaRepository
    {
        ICollection<DanhGia> GetDanhGias();
        DanhGia GetDanhGia(Guid Id);

        bool DanhGiaExits(Guid Id);
    }
}
