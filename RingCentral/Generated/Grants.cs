namespace RingCentral
{
    public partial class Grants
    {
        public Record[] records;
        public string uri;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string uri;
            public Extension extension;
            public bool? callPickup;
            public bool? callMonitoring;

            public class Extension
            {
                public string uri;
                public string extensionNumber;
                public string id;
                public string type;
            }
        }

        public class Paging
        {
            public int? page;
            public int? totalPages;
            public int? perPage;
            public int? totalElements;
        }

        public class Navigation
        {
            public FirstPage firstPage;
            public LastPage lastPage;

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
}