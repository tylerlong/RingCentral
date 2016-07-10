using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class RestClientTest : BaseTest
    {
        [Test]
        public void TestCase()
        {
            Assert.AreEqual("https://platform.ringcentral.com", RestClient.ProductionServer);
            Assert.AreEqual("https://platform.devtest.ringcentral.com", RestClient.SandboxServer);
            Assert.IsNotNull(rc.appKey);
            Assert.IsNotNull(rc.appSecret);
            Assert.IsNotNull(rc.server);
            Assert.IsNotNull(rc.token);
        }
    }
}
