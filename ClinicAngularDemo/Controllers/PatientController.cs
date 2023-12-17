using ClinicAngularDemo.Model;
using ClinicAngularDemo.servicies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAngularDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Patients")]
    public class PatientController : ControllerBase
    {
        private readonly IPatientServices patientService;

        public PatientController(IPatientServices _patientService)
        {
            patientService = _patientService;
        }

        [HttpPost]
        public void Create(PatientsDTO patientDTO)
        {
            patientService.Insert(patientDTO);
        }

        [HttpGet]
        public List<PatientsDTO> Search(string Name)
        {
            return patientService.Search(Name);
        }
    }
}
