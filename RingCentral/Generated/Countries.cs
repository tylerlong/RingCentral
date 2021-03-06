namespace RingCentral
{
    public partial class Countries
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
            public string callingCode;
            public bool? emergencyCalling;
            public bool? numberSelling;
            public bool? loginAllowed;
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

    public partial class Country
    {
        public System.Threading.Tasks.Task<Countries> List(object queryParams = null)
        {
            return List<Countries>(queryParams);
        }
    }
}