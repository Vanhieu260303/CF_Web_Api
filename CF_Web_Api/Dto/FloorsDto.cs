namespace CF_Web_Api.Dto
{
    public class FloorsDto
    {
        public Guid Id { get; set; }
        public string? FloorCode { get; set; }
        public string? FloorName { get; set; }
        public int? FloorOrder { get; set; }
        public int? FloorNotes { get; set; }
        public Guid? BlockId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; } 
    }
}
