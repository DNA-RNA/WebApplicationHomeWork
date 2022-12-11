namespace WebApplicationHomeWork.Models
{
    public class Odeme
    {
        public int OdemeId { get; set; }
        public DateTime OdemeTarihi { get; set; }
        public string OdemeTipi { get; set; }
        public string Aciklama { get; set; }

        public int VeliId { get; set; }
        public Veli Veli { get; set; }
        public ICollection<Veli> Veliler { get; set; }

    }
}
