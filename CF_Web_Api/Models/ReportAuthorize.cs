namespace CF_Web_Api.Data
{
    public class ReportAuthorize
    {
        public Guid IdForm { get; set; }
        public Guid IdDanhGia { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual DanhGia IdDanhGiaNavigation { get; set; } = null!;
        public virtual FormDanhGia IdFormNavigation { get; set; } = null!;
    }
}
