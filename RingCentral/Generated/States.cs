namespace RingCentral
{
    public partial class States
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string uri;
            public string id;
            public string name;
            public string isoCode;
            public Country country;

            public class Country
            {
                public string uri;
                public string id;
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
            public FirstPage firstPage;
            public LastPage lastPage;

            public class NextPage
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
}