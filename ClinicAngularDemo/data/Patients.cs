using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngularDemo.data
{
    public class Patients
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Phone { get; set; }
        public DateTime? DOB { get; set; }

        [ForeignKey("country")]
        public int Country_Id { get; set; }
        public Country country { get; set; }
    }
}
