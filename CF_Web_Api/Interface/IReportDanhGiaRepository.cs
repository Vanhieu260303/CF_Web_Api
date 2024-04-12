using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IReportDanhGiaRepository
    {
        ICollection<ReportDanhGia> GetReportDanhGias();

        ReportDanhGia GetReportDanhGia(Guid Id);

        bool ReportDanhGiaExits(Guid Id);
    }
}
