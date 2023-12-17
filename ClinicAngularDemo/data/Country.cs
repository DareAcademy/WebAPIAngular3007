using System.ComponentModel.DataAnnotations.Schema;

namespace ClinicAngularDemo.data
{
    [Table("Countries")]
    public class Country
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        public List<Patients> patients { get; set; }
    }
}
