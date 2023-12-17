using AutoMapper;
using ClinicAngularDemo.data;
using System.ComponentModel.DataAnnotations;

namespace ClinicAngularDemo.Model
{
    [AutoMap(typeof(Patients), ReverseMap = true)]
    public class PatientsDTO
    {
        public int? Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string? Phone { get; set; }
        public DateTime? DOB { get; set; }

        [Required]
        public int Country_Id { get; set; }

        public CountryDTO country { get; set; }
    }
}
