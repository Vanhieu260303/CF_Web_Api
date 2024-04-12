namespace CF_Web_Api.Dto
{
    public class ReportAuthorizesDto
    {
        public Guid IdForm { get; set; }
        public Guid IdDanhGia { get; set; }
        public bool? IsDelete { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

    }
}
