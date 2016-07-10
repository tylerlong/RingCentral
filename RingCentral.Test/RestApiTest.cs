using NUnit.Framework;
using Newtonsoft.Json;

namespace RingCentral.Test
{
    [TestFixture]
    public class RestApiTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            var str = rc.Get("/restapi").Result;
            Assert.NotNull(str);
            Assert.Greater(str.Length, 1);
            var restApis = rc.Get<RestApis>("/restapi").Result;
            Assert.NotNull(restApis);
            Assert.AreEqual(1, restApis.apiVersions.Length);
            Assert.AreEqual("v1.0", restApis.apiVersions[0].uriString);
        }

        [Test]
        public void TestCase2()
        {
            var restApis = rc.Get<RestApis>("/restapi").Result;
            var restApis2 = rc.RestApi().List().Result;
            Assert.AreEqual(JsonConvert.SerializeObject(restApis),
                            JsonConvert.SerializeObject(restApis2));
        }

        [Test]
        public void TestCase3()
        {
            var restApi = rc.Get<RestApi>("/restapi/v1.0").Result;
            var restApi2 = rc.RestApi().Get().Result;
            Assert.AreEqual(JsonConvert.SerializeObject(restApi),
                            JsonConvert.SerializeObject(restApi2));
        }
    }
}