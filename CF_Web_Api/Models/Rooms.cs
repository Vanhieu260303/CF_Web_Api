using System.Drawing;

namespace CF_Web_Api.Data
{
    public class Rooms
    {
        public Rooms()
        {
            FormDanhGia = new HashSet<FormDanhGia>();
        }

        public Guid Id { get; set; }
        public string? RoomCode { get; set; }
        public string? RoomName { get; set; }
        public Guid? IdCate { get; set; }
        public Guid? FloorsId { get; set; }
        public DateTime? CreateTime { get; set; }
        public DateTime? UpdateTime { get; set; }

        public virtual Floors? Floors { get; set; }
        public virtual RoomsCategory? IdCateNavigation { get; set; }
        public virtual ICollection<FormDanhGia> FormDanhGia { get; set; }
    }
}
