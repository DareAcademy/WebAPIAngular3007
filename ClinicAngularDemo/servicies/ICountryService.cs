using ClinicAngularDemo.Model;

namespace ClinicAngularDemo.servicies
{
    public interface ICountryService
    {
        void Create(CountryDTO countryDTO);

        List<CountryDTO> LoadAll();

        void Delete(int Id);

        CountryDTO Get(int Id);

        void Update(CountryDTO countryDTO);
    }
}
