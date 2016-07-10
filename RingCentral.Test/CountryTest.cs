using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class CountryTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            var country = rc.Get<Country>("/restapi/v1.0/dictionary/country/46").Result;
            Assert.NotNull(country);
            Assert.AreEqual("China", country.name);

            var country2 = rc.RestApi().Dictionary().Country("46").Get().Result;
            DeepEqual(country, country2);
        }

        [Test]
        public void TestCase2()
        {
            var countries = rc.Get<Countries>("/restapi/v1.0/dictionary/country").Result;
            Assert.NotNull(countries);
            Assert.Greater(countries.records.Length, 1);

            var countries2 = rc.RestApi().Dictionary().Country().List().Result;
            DeepEqual(countries, countries2);
        }
    }
}

