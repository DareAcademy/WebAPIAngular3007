using System.ComponentModel.DataAnnotations;

namespace ClinicAngularDemo.Model
{
    public class Role
    {
        [Required]
        public string Name { get; set; }
    }
}
