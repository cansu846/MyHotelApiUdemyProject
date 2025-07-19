
using System.ComponentModel.DataAnnotations;

namespace HotelProject.WebUI.Dtos.AppUserDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage="Kullanıcı adı zorunlu")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Şifre zorunlu")]
        public string Password { get; set; }

    }
}
