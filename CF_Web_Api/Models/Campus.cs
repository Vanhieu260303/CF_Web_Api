namespace CF_Web_Api.Data
{
    public class Campus
    {
        public Campus()
        {
            Blocks = new HashSet<Blocks>();
        }

        public Guid Id { get; set; }
        public string? CampusCode { get; set; }
        public string? CampusName { get; set; }
        public string? CampusSymbol { get; set; }
        public int? SortOrder { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<Blocks> Blocks { get; set; }
    }
}
