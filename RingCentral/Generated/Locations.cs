namespace RingCentral
{
    public partial class Locations
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string city;
            public string areaCode;
            public string npa;
            public string nxx;
            public State state;

            public class State
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
            public PreviousPage previousPage;

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

            public class PreviousPage
            {
                public string uri;
            }
        }
    }
}