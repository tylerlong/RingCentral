using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class TimezoneTest : BaseTest
    {
        [Test]
        public void TestGet()
        {
            var timezone = rc.Get<Timezone>("/restapi/v1.0/dictionary/timezone/6").Result;
            Assert.NotNull(timezone);
            Assert.AreEqual("Europe/Berlin", timezone.name);

            var timezone2 = rc.RestApi().Dictionary().Timezone("6").Get().Result;
            DeepEqual(timezone, timezone2);
        }

        [Test]
        public void TestList()
        {
            var timezones = rc.Get<Timezones>("/restapi/v1.0/dictionary/timezone").Result;
            Assert.NotNull(timezones);
            Assert.Greater(timezones.records.Length, 1);

            var timezones2 = rc.RestApi().Dictionary().Timezone().List().Result;
            DeepEqual(timezones, timezones2);
        }
    }
}