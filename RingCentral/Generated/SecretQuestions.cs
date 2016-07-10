namespace RingCentral
{
    public partial class SecretQuestions
    {
        public string uri;
        public Record[] records;
        public Paging paging;
        public Navigation navigation;

        public class Record
        {
            public string uri;
            public int? id;
            public int? questionType;
            public int? languageId;
            public string questionText;
            public bool? showInSignUp;
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