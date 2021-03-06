namespace RingCentral
{
    public partial class Languages
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
            public string localeCode;
            public bool? ui;
            public bool? greeting;
            public bool? formattingLocale;
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

    public partial class Language
    {
        public System.Threading.Tasks.Task<Languages> List(object queryParams = null)
        {
            return List<Languages>(queryParams);
        }
    }
}