using System.ComponentModel.DataAnnotations;
using WebApplicationHomeWork.Models.Enums;

namespace WebApplicationHomeWork.Models
{
    public class Veli
    {
       
        public int VeliId { get; set; }
        public string VeliAd { get; set; }
        public string VeliSoyad { get; set; }
        public string Email { get; set; }
        public string  TelefonNo { get; set; }
        public string IbanNo { get; set; }
        public string EvAdresi { get; set; }
        public UserRole Role { get; set; }
        public ICollection<Ogrenci> Ogrenciler { get; set; }

    }
}
