namespace RingCentral
{
    public partial class MessageStore
    {
        public string uri;
        public int? id;
        public To[] to;
        public From from;
        public string type;
        public string creationTime;
        public string readStatus;
        public string priority;
        public Attachment[] attachments;
        public string direction;
        public string availability;
        public string messageStatus;
        public string lastModifiedTime;
        public string vmTranscriptionStatus;
        public string faxResolution;
        public int? faxPageCount;
        public int? coverIndex;
        public string subject;
        public int? smsSendingAttemptsCount;
        public double? conversationId;
        public Conversation conversation;

        public class To
        {
            public string phoneNumber;
            public string extensionNumber;
            public string name;
            public string location;
            public string messageStatus;
        }

        public class From
        {
            public string phoneNumber;
            public string location;
        }

        public class Attachment
        {
            public int? id;
            public string uri;
            public string type;
            public string contentType;
            public int? vmDuration;
        }

        public class Conversation
        {
            public string id;
            public string uri;
        }
    }

    public partial class MessageStore : Model
    {
        internal MessageStore(Model parent, string _id = null) : base(parent, _id) { }

        protected override string PathSegment
        {
            get
            {
                return "message-store";
            }
        }
    }

    public partial class MessageStore : Model
    {
        public MessageStore() : base(null) { }

        public System.Threading.Tasks.Task<MessageStore> Get(object queryParams = null)
        {
            return Get<MessageStore>(queryParams);
        }
    }
}