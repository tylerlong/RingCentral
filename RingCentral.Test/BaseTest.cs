using NUnit.Framework;
using System.Threading;

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
            rc.Login(Config.Instance.username, Config.Instance.extension, Config.Instance.password);
        }

        [TearDown]
        public void TearDown()
        {
            Thread.Sleep(3000); // there is a rate limit
        }
    }
}