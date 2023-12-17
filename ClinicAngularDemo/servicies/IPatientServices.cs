using ClinicAngularDemo.Model;

namespace ClinicAngularDemo.servicies
{
    public interface IPatientServices
    {
        void Insert(PatientsDTO patientDTO);

        List<PatientsDTO> Search(string name);
    }
}
