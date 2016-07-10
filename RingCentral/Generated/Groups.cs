namespace RingCentral
{
    public partial class Groups
    {
        public Record[] records;
        public string uri;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string uri;
            public Contacts contacts;
            public double? id;
            public string notes;
            public string groupName;
            public int? contactsCount;

            public class Contacts
            {
                public string uri;
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