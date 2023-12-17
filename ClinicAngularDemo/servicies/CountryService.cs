using AutoMapper;
using ClinicAngularDemo.data;
using ClinicAngularDemo.Model;

namespace ClinicAngularDemo.servicies
{
    public class CountryService:ICountryService
    {
        private readonly ClinicContext context;
        private readonly IMapper mapper;

        public CountryService(ClinicContext _context, IMapper _mapper)
        {
            context = _context;
            mapper = _mapper;
        }

        public void Create(CountryDTO countryDTO)
        {
            Country country = mapper.Map<Country>(countryDTO);

            context.countries.Add(country);
            context.SaveChanges();

        }

        public void Update(CountryDTO countryDTO)
        {
            Country country = mapper.Map<Country>(countryDTO);

            context.countries.Attach(country);
            context.Entry(country).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();


        }

        public List<CountryDTO> LoadAll()
        {
            List<Country> allCountires = context.countries.ToList();

            List<CountryDTO> countries = mapper.Map<List<CountryDTO>>(allCountires);

            return countries;
        }

        public void Delete(int Id)
        {
            Country country = context.countries.Find(Id);
            context.countries.Remove(country);
            context.SaveChanges();
        }

        public CountryDTO Get(int Id)
        {
            Country country = context.countries.Find(Id);
            CountryDTO countryDTO = mapper.Map<CountryDTO>(country);
            return countryDTO;
        }


    }
}
