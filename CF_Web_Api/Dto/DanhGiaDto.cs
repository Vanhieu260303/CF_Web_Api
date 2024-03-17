namespace CF_Web_Api.Dto
{
    public class DanhGiaDto
    {
        public Guid Id { get; set; }
        public string? TenNoiDungDanhGia { get; set; }
        public bool? LoaiDanhGia { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }
    }
}
