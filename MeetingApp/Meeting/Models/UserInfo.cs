using System.ComponentModel.DataAnnotations;

namespace Meeting.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="İsim Bilgisi Zorunludur")]
        public string? Name { get; set; } //null

        [Required(ErrorMessage ="Telefon Bilgisi  zorunldur")]
        public string? Phone { get; set; }

        [Required(ErrorMessage ="E-Mail Bilgisi Zorunludur")]
        [EmailAddress]
        public string? EMail { get; set; }

        [Required(ErrorMessage ="Katılım Durumunuzu Belirtiniz")]
        public bool? WillAttend { get; set; } 

    }
}
