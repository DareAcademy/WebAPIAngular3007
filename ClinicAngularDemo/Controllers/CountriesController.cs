using ClinicAngularDemo.Model;
using ClinicAngularDemo.servicies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClinicAngularDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles ="Admin")]
    public class CountriesController : ControllerBase
    {
        private readonly ICountryService countryService;

        public CountriesController(ICountryService _countryService)
        {
            countryService = _countryService;
        }

        [HttpPost]
        public void Create(CountryDTO countryDTO)
        {
            countryService.Create(countryDTO);
        }

        [HttpGet]
        [Route("GetAll")]
        public List<CountryDTO> GetAll()
        {
            return countryService.LoadAll();
        }

        [HttpDelete]
        public void Delete(int Id)
        {
            countryService.Delete(Id);
        }

        [HttpGet]
        [Route("Get")]
        public CountryDTO Get(int Id)
        {
            return countryService.Get(Id);
        }

        [HttpPut]
        public void Update(CountryDTO countryDTO)
        {
            countryService.Update(countryDTO);
        }
    }
}
