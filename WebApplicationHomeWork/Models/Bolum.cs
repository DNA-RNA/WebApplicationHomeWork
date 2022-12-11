namespace WebApplicationHomeWork.Models
{
    public class Bolum
    {

        public int BolumId { get; set; }
        public string BolumName { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
