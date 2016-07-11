using System.Threading.Tasks;

namespace RingCentral
{
    public partial class Country
    {
        public Task<Countries> List(object queryParams = null)
        {
            return List<Countries>(queryParams);
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