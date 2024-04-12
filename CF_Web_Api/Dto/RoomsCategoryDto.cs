namespace CF_Web_Api.Dto
{
    public class RoomsCategoryDto
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
