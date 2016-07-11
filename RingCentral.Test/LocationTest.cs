using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class LocationTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            var locations = rc.Get<Locations>("/restapi/v1.0/dictionary/location", new {  stateId = "16" }).Result;
            Assert.NotNull(locations);
            Assert.Greater(locations.records.Length, 1);

            var locations2 = rc.RestApi().Dictionary().Location().List(new { stateId = "16" }).Result;
            DeepEqual(locations, locations2);

            Assert.AreEqual("16", locations.records[0].state.id);
        }
    }
}