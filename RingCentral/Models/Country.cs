namespace RingCentral
{
    public partial class Country
    {
    }

    public static class CountryExtensions
    {
        public static Country Country(this Dictionary dictionary, string _id = null)
        {
            return new Country(dictionary, _id);
        }
    }
}