using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
    public class UserSignInViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı giriniz.")]
        public string username { get; set; }

        [Required(ErrorMessage = "Lütfen parolanızı giriniz.")]
        public string password { get; set; }

    }
}
