namespace CF_Web_Api.Dto
{
    public class FormDanhGiasDto
    {
        public Guid Id { get; set; }
        public Guid? IdRoom { get; set; }
        public Guid? IdCa { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

    }
}
