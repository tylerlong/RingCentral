using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture()]
    public class Test : BaseTest
    {
        [Test()]
        public void TestCase()
        {
            Assert.IsNotNull(rc);
            Assert.IsNotNull(rc.Token);
            Assert.IsNotNull(rc.Token.access_token);
        }
    }
}