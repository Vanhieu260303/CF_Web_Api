namespace CF_Web_Api.Dto
{
    public class AccountDto
    {
        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Pass { get; set; }
        public string? HoTen { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime? CreateTime { get; set; } = DateTime.UtcNow;
        public DateTime? UpdateTime { get; set; } = DateTime.UtcNow;
    }
}
