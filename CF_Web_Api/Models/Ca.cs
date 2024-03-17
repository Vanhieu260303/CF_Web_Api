namespace CF_Web_Api.Data
{
    public class Ca
    {
        public Ca()
        {
            FormDanhGia = new HashSet<FormDanhGia>();
        }

        public Guid Id { get; set; }
        public string? TenCa { get; set; }
        public TimeSpan? ThoiGian { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<FormDanhGia> FormDanhGia { get; set; }
    }
}
