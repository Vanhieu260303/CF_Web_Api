namespace CF_Web_Api.Data
{
    public class DanhGia
    {
        public DanhGia()
        {
            ReportAuthorizes = new HashSet<ReportAuthorize>();
        }

        public Guid Id { get; set; }
        public string? TenNoiDungDanhGia { get; set; }
        public bool? LoaiDanhGia { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<ReportAuthorize> ReportAuthorizes { get; set; }
    }
}
