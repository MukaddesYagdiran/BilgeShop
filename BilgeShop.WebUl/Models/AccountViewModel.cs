using System.ComponentModel.DataAnnotations;

namespace BilgeShop.WebUI.Models
{
    public class AccountViewModel
    {
        
        [Display(Name ="AD")]
        [Required(ErrorMessage ="Bu alan doldurulmak zorundadır.")]
        public string FirstName { get; set; }

        [Display(Name = "SOYAD")]
        [Required(ErrorMessage = "Bu alan doldurulmak zorundadır.")]
        public string LastName { get; set; }

        [Display(Name = "EPOSTA")]
        [Required(ErrorMessage = "Bu alan doldurulmak zorundadır.")]
        public string Email { get; set; }

        [Display(Name = "EPOSTA (TEKRAR)")]
        [Required(ErrorMessage = "Bu alan doldurulmak zorundadır.")]
        [Compare(nameof(Email),ErrorMessage ="Email adresi eşleşmiyor.")]
        public string EmailConfirm { get; set; }

    }
}
