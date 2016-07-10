namespace RingCentral
{
    public partial class Extensions
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string uri;
            public int? id;
            public string extensionNumber;
            public Contact contact;
            public string name;
            public string type;
            public string status;
            public Permissions permissions;
            public ProfileImage profileImage;

            public class Contact
            {
                public string firstName;
                public string lastName;
                public string email;
                public string company;
                public string businessPhone;
                public string department;
            }

            public class Permissions
            {
                public Admin admin;
                public InternationalCalling internationalCalling;

                public class Admin
                {
                    public bool? enabled;
                }

                public class InternationalCalling
                {
                    public bool? enabled;
                }
            }

            public class ProfileImage
            {
                public string uri;
                public string etag;
                public string contentType;
                public string lastModified;
                public Scale[] scales;

                public class Scale
                {
                    public string uri;
                }
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
        }
    }
}