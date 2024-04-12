namespace CF_Web_Api.Dto
{
    public class ReportDanhGiaDto
    {
        public Guid Id { get; set; }
        public string? GhiChu { get; set; }
        public Guid? FormDanhGiaId { get; set; }
        public Guid? AccountId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
