using System.ComponentModel.DataAnnotations;
using WebApplicationHomeWork.Models.Enums;

namespace WebApplicationHomeWork.Models
{
    public class Ogrenci
    {
        [Key]
        public int OgrenciId { get; set; }

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public int OkulId { get; set; }
        public Okul Okul { get; set; }
        public int OdaId { get; set; }
        public Oda Oda { get; set; }
        public int VeliId { get; set; }
        public Veli Veli { get; set; }
        public int OgrenciNo { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        public string Sifre { get; set; }
        public string KapiSifre { get; set; }
        public int Sınıf { get; set; }
        public UserRole Role { get; set; }
        public string? TcNo { get; set; }
        public DateTime KayitTarihi { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string? PassportNo { get; set; }

    }
}
