using System.ComponentModel.DataAnnotations;

namespace BilgeShop.WebUI.Models
{
    public class RegisterViewModel
    {
        [Display(Name="Ad")]
        [Required(ErrorMessage ="AD alanı boş bırakılamaz")]
        public string FirstName { get; set; }
        [Display(Name = "Soyad")]
        [Required(ErrorMessage ="SOYAD alanı boş bırakılamaz")]
        public string LastName { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage ="EMAİL alanı boş bırakılamaz")]
        public string Email { get; set; }
        [Display(Name = "Şifre")]
        [Required(ErrorMessage ="ŞİFRE alanı boş bırakılamaz")]
        public string Password { get; set; }
        [Display(Name = "Şifre Tekrar")]
        [Required(ErrorMessage ="ŞİFRE(TEKRAR) alanı boş bırakılamaz")]
        [Compare(nameof(Password),ErrorMessage ="şifreler eşleşmiyor.")]
        public string PasswordConfirm { get; set; }


    }
}
