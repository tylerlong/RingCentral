namespace RingCentral
{
    public partial class PhoneNumber
    {
        public string uri;
        public int? id;
        public string phoneNumber;
        public string paymentType;
        public string location;
        public string type;
        public string usageType;
        public string[] features;
        public string status;
        public Extension extension;

        public class Extension
        {
            public string uri;
            public int? id;
            public string extensionNumber;
        }
    }

    public partial class PhoneNumber : Model
    {
        public PhoneNumber() : base(null) { }

        protected override string PathSegment
        {
            get
            {
                return "phonenumber";
            }
        }
    }
}