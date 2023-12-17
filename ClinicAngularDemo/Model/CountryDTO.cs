using AutoMapper;
using ClinicAngularDemo.data;
using System.ComponentModel.DataAnnotations;

namespace ClinicAngularDemo.Model
{
    [AutoMap(typeof(Country),ReverseMap =true)]
    public class CountryDTO
    {
        public int? Id { get; set; }
        
        [Required]
        public string Code { get; set; }
        
        [Required]
        public string Name { get; set; }

    }
}
