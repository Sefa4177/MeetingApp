using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        [Required(ErrorMessage ="Katılacağınız Toplantıyı Seçiniz")]
        public int MeetingId{get; set;}
        public int Id { get; set; }

        [Required(ErrorMessage ="Ad Soyad Girişi Yapınız")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon Numarası Girişi Yapınız")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="E-Posta Girişi Yapınız")]
        [EmailAddress(ErrorMessage ="Hatalı E-Posta Girdiniz")]
        public string? Email { get; set; }

        [Required(ErrorMessage ="Katılım Durumunuzu Belirtiniz")]
        public bool? WillAttend { get; set; }
    }
}