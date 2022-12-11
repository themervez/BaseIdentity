using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BaseIdentity.PresentationLayer.Models
{
    public class AppUserRegisterViewModel
    {
        [Required(ErrorMessage ="Kullanıcı Adı Boş Geçilemez!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Ad Boş Geçilemez!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyad Boş Geçilemez!")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "E-mail Boş Geçilemez!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre Boş Geçilemez!")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre Tekrar Boş Geçilemez!")]
        public string ConfirmPassword { get; set; }
    }
}
