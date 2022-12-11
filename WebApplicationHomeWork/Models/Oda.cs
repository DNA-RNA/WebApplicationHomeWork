using System.ComponentModel.DataAnnotations;

namespace WebApplicationHomeWork.Models
{
    public class Oda
    {
        
        public int OdaId { get; set; }
        public int YatakId { get; set; }
        public Yatak Yatak { get; set; }
        public string OdaTipi { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}
