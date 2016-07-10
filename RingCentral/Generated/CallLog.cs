namespace RingCentral
{
    public partial class CallLog
    {
        public string uri;
        public string id;
        public string sessionId;
        public string startTime;
        public int? duration;
        public string type;
        public string direction;
        public string action;
        public string result;
        public To to;
        public From from;

        public class To
        {
            public string phoneNumber;
        }

        public class From
        {
            public string phoneNumber;
            public string location;
        }
    }
}