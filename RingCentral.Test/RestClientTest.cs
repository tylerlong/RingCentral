using NUnit.Framework;
using System.Net;
using Newtonsoft.Json;

namespace RingCentral.Test
{
    [TestFixture]
    public class RestClientTest : BaseTest
    {
        [Test]
        public void TestProperties()
        {
            Assert.AreEqual("https://platform.ringcentral.com", RestClient.ProductionServer);
            Assert.AreEqual("https://platform.devtest.ringcentral.com", RestClient.SandboxServer);
            Assert.IsNotNull(rc.appKey);
            Assert.IsNotNull(rc.appSecret);
            Assert.IsNotNull(rc.server);
            Assert.IsNotNull(rc.token);
        }

        [Test]
        public void TestPostDelete()
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
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            var content = response.Content.ReadAsStringAsync().Result;
            var subscription = JsonConvert.DeserializeObject<Subscription>(content);
            Assert.AreEqual("PubNub", subscription.deliveryMode.transportType);

            response = rc.Delete("/restapi/v1.0/subscription/" + subscription.id).Result;
            Assert.AreEqual(HttpStatusCode.NoContent, response.StatusCode);
        }

        [Test]
        public void TestPut()
        {
            var messages = rc.RestApi().Account().Extension().MessageStore().List().Result;
            var messageId = messages.records[0].id;
            var response = rc.Put("/restapi/v1.0/account/~/extension/~/message-store/" + messageId, new { readStatus = "Read" }).Result;
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);

            var readStatus = rc.RestApi().Account().Extension().MessageStore(messageId + "").Get().Result.readStatus;
            Assert.AreEqual("Read", readStatus);

            response = rc.Put("/restapi/v1.0/account/~/extension/~/message-store/" + messageId, new { readStatus = "Unread" }).Result;
            Assert.AreEqual(HttpStatusCode.OK, response.StatusCode);
            readStatus = rc.RestApi().Account().Extension().MessageStore(messageId + "").Get().Result.readStatus;
            Assert.AreEqual("Unread", readStatus);
        }
    }
}