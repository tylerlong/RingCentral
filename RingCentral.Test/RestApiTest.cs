using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class RestApiTest : BaseTest
    {
        [Test]
        public void TestGet()
        {
            var restApi = rc.Get<RestApi>("/restapi/v1.0").Result;
            Assert.NotNull(restApi);
            Assert.AreEqual("v1.0", restApi.uriString);
            var restApi2 = rc.RestApi().Get().Result;
            DeepEqual(restApi, restApi2);
        }

        [Test]
        public void TestList()
        {
            var restApis = rc.Get<RestApis>("/restapi").Result;
            Assert.NotNull(restApis);
            Assert.AreEqual(1, restApis.apiVersions.Length);
            Assert.AreEqual("v1.0", restApis.apiVersions[0].uriString);
            var restApis2 = rc.RestApi().List().Result;
            DeepEqual(restApis, restApis2);
        }
    }
}