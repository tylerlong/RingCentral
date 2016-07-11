namespace RingCentral
{
    public partial class Contacts
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;
        public Groups groups;

        public class Record
        {
            public string uri;
            public string availability;
            public int? id;
            public string firstName;
            public string homePhone;
            public string lastName;
            public string businessPhone;
            public string mobilePhone;
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

        public class Groups
        {
            public string uri;
        }
    }

    public partial class Contact
    {
        public System.Threading.Tasks.Task<Contacts> List(object queryParams = null)
        {
            return List<Contacts>(queryParams);
        }
    }
}