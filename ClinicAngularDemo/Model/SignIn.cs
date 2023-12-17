using System.ComponentModel.DataAnnotations;

namespace ClinicAngularDemo.Model
{
    public class SignIn
    {
        [Required]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
