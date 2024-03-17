using System.Drawing;

namespace CF_Web_Api.Data
{
    public class Blocks
    {
        public Blocks()
        {
            Floors = new HashSet<Floors>();
        }

        public Guid Id { get; set; }
        public string? BlockCode { get; set; }
        public string? BlockName { get; set; }
        public int? BlockNo { get; set; }
        public Guid? CampusId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual Campus? Campus { get; set; }
        public virtual ICollection<Floors> Floors { get; set; }

    }
}
