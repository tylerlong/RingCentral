using NUnit.Framework;

namespace RingCentral.Test
{
    [TestFixture]
    public class MessageStoreTest : BaseTest
    {
        [Test]
        public void TestListGet()
        {
            var messages = rc.Get<MessageStores>("/restapi/v1.0/account/~/extension/~/message-store/").Result;
            Assert.GreaterOrEqual(messages.records.Length, 1);

            var messages2 = rc.RestApi().Account().Extension().MessageStore().List().Result;
            DeepEqual(messages, messages2);

            var messageId = messages.records[0].id;
            var message = rc.Get<MessageStore>("/restapi/v1.0/account/~/extension/~/message-store/" + messageId).Result;
            Assert.NotNull(message);
            var message2 = rc.RestApi().Account().Extension().MessageStore(messageId + "").Get().Result;
            DeepEqual(message, message2);
        }
    }
}