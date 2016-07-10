namespace RingCentral
{
    public partial class BlockedNumbers
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string uri;
            public string id;
            public string phoneNumber;
            public string name;
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