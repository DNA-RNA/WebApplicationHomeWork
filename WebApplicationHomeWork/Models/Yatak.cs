namespace WebApplicationHomeWork.Models
{
    public class Yatak
    {
        public int YatakId { get; set; }
        public string YatakSırası { get; set; }
        public ICollection<Oda> Odalar { get; set; }
    }
}
