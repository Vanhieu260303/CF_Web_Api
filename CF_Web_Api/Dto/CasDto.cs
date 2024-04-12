namespace CF_Web_Api.Dto
{
    public class CasDto
    {
        public Guid Id { get; set; }
        public string? TenCa { get; set; }
        public TimeSpan? ThoiGian { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

    }
}
