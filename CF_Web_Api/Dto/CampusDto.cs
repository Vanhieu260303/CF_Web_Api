namespace CF_Web_Api.Dto
{
    public class CampusDto
    {
        public Guid Id { get; set; }
        public string? CampusCode { get; set; }
        public string? CampusName { get; set; }
        public string? CampusSymbol { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? CreateTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateTime { get; set; } = DateTime.UtcNow;
    }
}
