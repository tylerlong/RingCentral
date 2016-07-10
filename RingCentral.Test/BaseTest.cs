using NUnit.Framework;
using System.Threading;
using Newtonsoft.Json;

namespace RingCentral.Test
{
    [TestFixture]
    public class BaseTest
    {
        protected RestClient rc;

        [OneTimeSetUp]
        public void SetUp()
        {
            if (Config.Instance == null)
            {
                Assert.Ignore();
            }
            rc = new RestClient(Config.Instance.appKey, Config.Instance.appSecret);
            rc.Authorize(Config.Instance.username, Config.Instance.extension, Config.Instance.password);
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000); // there is a rate limit
        }

        protected void DeepEqual(object obj1, object obj2)
        {
            Assert.AreEqual(JsonConvert.SerializeObject(obj1), JsonConvert.SerializeObject(obj2));
        }
    }
}