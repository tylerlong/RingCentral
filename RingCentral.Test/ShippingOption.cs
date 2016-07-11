using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class ShippingOptionTest : BaseTest
    {
        [Test]
        public void TestList()
        {
            var sos = rc.Get<ShippingOptions>("/restapi/v1.0/dictionary/shipping-options",
                                              new { quantity = 100 }).Result;
            Assert.NotNull(sos);
            Assert.Greater(sos.records.Length, 1);

            var sos2 = rc.RestApi().Dictionary().ShippingOption()
                         .List(new { quantity = 100 }).Result;
            DeepEqual(sos, sos2);

            Assert.AreEqual(100, sos.records[0].quantity);
        }
    }
}