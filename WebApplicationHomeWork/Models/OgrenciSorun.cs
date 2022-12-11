namespace WebApplicationHomeWork.Models
{
    public class OgrenciSorun
    {
        public int Id { get; set; }
        public int OgrenciId { get; set; }
        public int SorunId { get; set; }
        public virtual Ogrenci Ogrenci { get; set; } = null!;
        public virtual Sorun Sorun { get; set; } = null!;
    }
}
