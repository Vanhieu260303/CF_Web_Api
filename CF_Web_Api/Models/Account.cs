namespace CF_Web_Api.Data
{
    public class Account
    {

        public Account()
        {
            ReportDanhGia = new HashSet<ReportDanhGia>();
        }

        public Guid Id { get; set; }
        public string? UserName { get; set; }
        public string? Pass { get; set; }
        public string? HoTen { get; set; }
        public bool? IsAdmin { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual ICollection<ReportDanhGia> ReportDanhGia { get; set; }
    }


}

