using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage ="Lütfen adınızı giriniz.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı giriniz.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Lütfen mailin adresinizi giriniz.")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı giriniz.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı tekrar giriniz.")]
        [Compare("Password",ErrorMessage ="Parolalar aynı değil.")]
        public string ConfirmPassword { get; set; }
    }
}
