namespace CF_Web_Api.Dto
{
    public class RoomsDto
    {
        public Guid Id { get; set; }
        public string? RoomCode { get; set; }
        public string? RoomName { get; set; }
        public Guid? IdCate { get; set; }
        public Guid? FloorsId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
