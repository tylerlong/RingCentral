using NUnit.Framework;
using Newtonsoft.Json;

namespace RingCentral.Test
{
    [TestFixture]
    public class SubscriptionTest : BaseTest
    {
        private Subscription _subscription;

        [OneTimeSetUp]
        public void Setup()
        {
            var requestBody = new
            {
                eventFilters = new string[] {
                  "/restapi/v1.0/account/~/extension/~/presence?detailedTelephonyState=true",
                  "/restapi/v1.0/account/~/extension/~/message-store",
                },
                deliveryMode = new
                {
                    transportType = "PubNub",
                    encryption = true,
                },
            };
            var queryParams = new { aggregated = "True" };
            var response = rc.Post("/restapi/v1.0/subscription", requestBody, queryParams).Result;
            var content = response.Content.ReadAsStringAsync().Result;
            _subscription = JsonConvert.DeserializeObject<Subscription>(content);
        }

        [Test]
        public void TestGet()
        {
            var subscription = rc.Get<Subscription>("/restapi/v1.0/subscription/" + _subscription.id).Result;
            Assert.NotNull(subscription);
            Assert.AreEqual("PubNub", subscription.deliveryMode.transportType);

            var subscription2 = rc.RestApi().Subscription(_subscription.id).Get().Result;
            DeepEqual(subscription, subscription2);
        }

        [Test]
        public void TestList()
        {
            var subscriptions = rc.Get<Subscriptions>("/restapi/v1.0/subscription").Result;
            Assert.NotNull(subscriptions);
            Assert.GreaterOrEqual(subscriptions.records.Length, 1);

            var subscriptions2 = rc.RestApi().Subscription().List().Result;
            Assert.AreEqual(subscriptions.records[0].id, subscriptions2.records[0].id);
        }

        [OneTimeTearDown]
        public new void TearDown()
        {
            rc.Delete("/restapi/v1.0/subscription/" + _subscription.id);
        }
    }
}