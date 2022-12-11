using System.ComponentModel.DataAnnotations;

namespace WebApplicationHomeWork.Models
{
    public class Ogrenci
    {
        [Key]
        public int Id { get; set; }

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
        public int OkulId { get; set; }
        public Okul Okul { get; set; }

        public int OgrenciNo { get; set; }
        [Required]
        public string Ad { get; set; }
        [Required]
        public string Soyad { get; set; }
        public int Sınıf { get; set; }
        
        public string? TcNo { get; set; }

        public string? PassportNo { get; set; }

    }
}
