namespace WebApplicationHomeWork.Models
{
    public class Okul
    {
        public int OkulId { get; set; }
        public string OkulName { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }

    }
}
