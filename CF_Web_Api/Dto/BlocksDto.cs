namespace CF_Web_Api.Dto
{
    public class BlocksDto
    {
        public Guid Id { get; set; }
        public string? BlockCode { get; set; }
        public string? BlockName { get; set; }
        public int? BlockNo { get; set; }
        public Guid? CampusId { get; set; }
        public DateTime? CreateTime { get; set; }= DateTime.UtcNow;
        public DateTime? UpdateTime { get; set; }=DateTime.UtcNow;
    }
}
