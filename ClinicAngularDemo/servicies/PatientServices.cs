using AutoMapper;
using ClinicAngularDemo.data;
using ClinicAngularDemo.Model;
using Microsoft.EntityFrameworkCore;

namespace ClinicAngularDemo.servicies
{
    public class PatientServices:IPatientServices
    {
        private readonly ClinicContext context;
        private readonly IMapper mapper;

        public PatientServices(ClinicContext _context,IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Insert(PatientsDTO patientDTO)
        {
            Patients newPatient = mapper.Map<Patients>(patientDTO);

            context.patients.Add(newPatient);
            context.SaveChanges();
        }

        public List<PatientsDTO> Search(string name)
        {
            List<Patients> allPatients = context.patients.Include("country").Where(p => p.FirstName.Contains(name) || p.LastName.Contains(name)).ToList();

            List<PatientsDTO> patients = mapper.Map<List<PatientsDTO>>(allPatients);

            return patients;


        }
    }
}
