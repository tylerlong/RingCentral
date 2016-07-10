namespace RingCentral
{
    public partial class Subscription
    {
        public string uri;
        public string id;
        public string creationTime;
        public string status;
        public string[] eventFilters;
        public string expirationTime;
        public int? expiresIn;
        public DeliveryMode deliveryMode;

        public class DeliveryMode
        {
            public string transportType;
            public bool? encryption;
            public string address;
            public string subscriberKey;
            public string encryptionAlgorithm;
            public string encryptionKey;
        }
    }
}