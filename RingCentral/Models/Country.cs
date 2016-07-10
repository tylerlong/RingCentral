using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Country : Model
    {
        public Task<Country> Get(object queryParameters = null)
        {
            return Get<Country>(queryParameters);
        }

        public Task<Countries> List(object queryParameters = null)
        {
            return List<Countries>(queryParameters);
        }
    }

    public static class CountryExtensions
    {
        public static Country Country(this Dictionary dictionary, string _id = null)
        {
            return new Country(dictionary, _id);
        }
    }
}