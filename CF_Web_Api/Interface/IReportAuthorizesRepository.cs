using CF_Web_Api.Data;

namespace CF_Web_Api.Interface
{
    public interface IReportAuthorizesRepository
    {
        ICollection<ReportAuthorize> GetReportAuthorizes();

        ReportAuthorize GetReportAuthorize(Guid Id);

        bool ReportAuthorizeExits(Guid Id);
    }
}
