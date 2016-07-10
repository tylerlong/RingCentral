namespace RingCentral
{
    public partial class CallLogs
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
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

        public class Paging
        {
            public int? page;
            public int? perPage;
            public int? pageStart;
            public int? pageEnd;
            public int? totalPages;
            public int? totalElements;
        }

        public class Navigation
        {
            public NextPage nextPage;
            public FirstPage firstPage;
            public PreviousPage previousPage;
            public LastPage lastPage;

            public class NextPage
            {
                public string uri;
            }

            public class FirstPage
            {
                public string uri;
            }

            public class PreviousPage
            {
                public string uri;
            }

            public class LastPage
            {
                public string uri;
            }
        }
    }
}