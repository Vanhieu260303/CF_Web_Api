namespace CF_Web_Api.Data
{
    public class FormDanhGia
    {
        public FormDanhGia()
        {
            ReportAuthorizes = new HashSet<ReportAuthorize>();
            ReportDanhGia = new HashSet<ReportDanhGia>();
        }

        public Guid Id { get; set; }
        public Guid? IdRoom { get; set; }
        public Guid? IdCa { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual Ca? IdCaNavigation { get; set; }
        public virtual Rooms? IdRoomNavigation { get; set; }
        public virtual ICollection<ReportAuthorize> ReportAuthorizes { get; set; }
        public virtual ICollection<ReportDanhGia> ReportDanhGia { get; set; }


    }
}
