namespace CF_Web_Api.Data
{
    public class RoomsCategory
    {
        public RoomsCategory()
        {
            Rooms = new HashSet<Rooms>();
        }

        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
        public string? CategoryCode { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}

