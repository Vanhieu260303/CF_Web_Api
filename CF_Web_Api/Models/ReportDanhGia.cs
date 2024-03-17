namespace CF_Web_Api.Data
{
    public class ReportDanhGia
    {
        public Guid Id { get; set; }
        public string? GhiChu { get; set; }
        public Guid? FormDanhGiaId { get; set; }
        public Guid? AccountId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual Account? Account { get; set; }
        public virtual FormDanhGia? FormDanhGia { get; set; } = null;
    }
}
