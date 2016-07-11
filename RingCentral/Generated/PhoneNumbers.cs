namespace RingCentral
{
    public partial class PhoneNumbers
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string uri;
            public int? id;
            public string phoneNumber;
            public string paymentType;
            public string location;
            public string type;
            public string usageType;
            public Extension extension;
            public string[] features;
            public string status;

            public class Extension
            {
                public string uri;
                public int? id;
                public string extensionNumber;
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
            public FirstPage firstPage;
            public LastPage lastPage;
            public NextPage nextPage;
            public PreviousPage previousPage;

            public class FirstPage
            {
                public string uri;
            }

            public class LastPage
            {
                public string uri;
            }

            public class NextPage
            {
                public string uri;
            }

            public class PreviousPage
            {
                public string uri;
            }
        }
    }

    public partial class PhoneNumber
    {
        public System.Threading.Tasks.Task<PhoneNumbers> List(object queryParams = null)
        {
            return List<PhoneNumbers>(queryParams);
        }
    }
}