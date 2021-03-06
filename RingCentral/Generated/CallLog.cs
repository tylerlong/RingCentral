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
        public Recording recording;

        public class To
        {
            public string phoneNumber;
        }

        public class From
        {
            public string phoneNumber;
            public string location;
        }

        public class Recording
        {
            public string uri;
            public string id;
            public string type;
            public string contentUri;
        }
    }

    public partial class CallLog : Model
    {
        internal CallLog(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "call-log";
            }
        }
    }

    public partial class CallLog : Model
    {
        public CallLog() : base(null) { }

        public System.Threading.Tasks.Task<CallLog> Get(object queryParams = null)
        {
            return Get<CallLog>(queryParams);
        }
    }
}