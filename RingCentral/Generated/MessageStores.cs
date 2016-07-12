namespace RingCentral
{
    public partial class MessageStores
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
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
            public string subject;
            public string messageStatus;
            public int? smsSendingAttemptsCount;
            public double? conversationId;
            public Conversation conversation;
            public string lastModifiedTime;
            public string faxResolution;
            public int? faxPageCount;
            public int? coverIndex;
            public string vmTranscriptionStatus;

            public class To
            {
                public string phoneNumber;
                public string location;
                public string messageStatus;
                public string extensionNumber;
                public string name;
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

        public class Paging
        {
            public int? page;
            public int? totalPages;
            public int? perPage;
            public int? totalElements;
            public int? pageStart;
            public int? pageEnd;
        }

        public class Navigation
        {
            public NextPage nextPage;
            public PreviousPage previousPage;
            public FirstPage firstPage;
            public LastPage lastPage;

            public class NextPage
            {
                public string uri;
            }

            public class PreviousPage
            {
                public string uri;
            }

            public class FirstPage
            {
                public string uri;
            }

            public class LastPage
            {
                public string uri;
            }
        }
    }

    public partial class MessageStore
    {
        public System.Threading.Tasks.Task<MessageStores> List(object queryParams = null)
        {
            return List<MessageStores>(queryParams);
        }
    }
}